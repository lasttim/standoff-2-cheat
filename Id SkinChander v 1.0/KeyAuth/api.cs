using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace KeyAuth
{
	// Token: 0x02000002 RID: 2
	public class api
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00003070 File Offset: 0x00001270
		public api(string name, string ownerid, string secret, string version)
		{
			if (ownerid.Length != 10 || secret.Length != 64)
			{
				Process.Start("https://youtube.com/watch?v=RfDTdiBq4_o");
				Process.Start("https://keyauth.cc/app/");
				Thread.Sleep(2000);
				api.error("Application not setup correctly. Please watch the YouTube video for setup.");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00003124 File Offset: 0x00001324
		public void init()
		{
			string text = encryption.iv_key();
			api.enckey = text + "-" + this.secret;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "init";
			nameValueCollection["ver"] = this.version;
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = text;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (!response_structure.success)
			{
				if (response_structure.message == "invalidver")
				{
					this.app_data.downloadLink = response_structure.download;
				}
			}
			else
			{
				if (response_structure.newSession)
				{
					Thread.Sleep(100);
				}
				api.sessionid = response_structure.sessionid;
				this.initialized = true;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00003264 File Offset: 0x00001464
		public void CheckInit()
		{
			if (!this.initialized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00003290 File Offset: 0x00001490
		public string expirydaysleft(string Type, int subscription)
		{
			this.CheckInit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[subscription].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			string text = Type.ToLower();
			string a = text;
			string result;
			if (!(a == "months"))
			{
				if (!(a == "days"))
				{
					if (!(a == "hours"))
					{
						result = null;
					}
					else
					{
						result = Convert.ToString(timeSpan.Hours);
					}
				}
				else
				{
					result = Convert.ToString(timeSpan.Days);
				}
			}
			else
			{
				result = Convert.ToString(timeSpan.Days / 30);
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00003364 File Offset: 0x00001564
		public void register(string username, string pass, string key, string email = "")
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "register";
			nameValueCollection["username"] = username;
			nameValueCollection["pass"] = pass;
			nameValueCollection["key"] = key;
			nameValueCollection["email"] = email;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00003450 File Offset: 0x00001650
		public void forgot(string username, string email)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "forgot";
			nameValueCollection["username"] = username;
			nameValueCollection["email"] = email;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000034EC File Offset: 0x000016EC
		public void login(string username, string pass)
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = username;
			nameValueCollection["pass"] = pass;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000035BC File Offset: 0x000017BC
		public void logout()
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "logout";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003640 File Offset: 0x00001840
		public void web_login()
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			HttpListener httpListener;
			HttpListenerRequest request;
			HttpListenerResponse httpListenerResponse;
			for (;;)
			{
				httpListener = new HttpListener();
				string text = "handshake";
				text = "http://localhost:1337/" + text + "/";
				httpListener.Prefixes.Add(text);
				httpListener.Start();
				HttpListenerContext context = httpListener.GetContext();
				request = context.Request;
				httpListenerResponse = context.Response;
				httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
				httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
				httpListenerResponse.AddHeader("Via", "hugzho's big brain");
				httpListenerResponse.AddHeader("Location", "your kernel ;)");
				httpListenerResponse.AddHeader("Retry-After", "never lmao");
				httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
				if (!(request.HttpMethod == "OPTIONS"))
				{
					break;
				}
				httpListenerResponse.StatusCode = 200;
				Thread.Sleep(1);
				httpListener.Stop();
			}
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			string rawUrl = request.RawUrl;
			string text2 = rawUrl.Replace("/handshake?user=", "");
			text2 = text2.Replace("&token=", " ");
			string text3 = text2;
			string value2 = text3.Split(Array.Empty<char>())[0];
			string value3 = text3.Split(new char[]
			{
				' '
			})[1];
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = value2;
			nameValueCollection["token"] = value3;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			bool flag = true;
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
				httpListenerResponse.StatusCode = 420;
				httpListenerResponse.StatusDescription = "SHEESH";
			}
			else
			{
				Console.WriteLine(response_structure.message);
				httpListenerResponse.StatusCode = 200;
				httpListenerResponse.StatusDescription = response_structure.message;
				flag = false;
			}
			byte[] bytes = Encoding.UTF8.GetBytes("Whats up?");
			httpListenerResponse.ContentLength64 = (long)bytes.Length;
			Stream outputStream = httpListenerResponse.OutputStream;
			outputStream.Write(bytes, 0, bytes.Length);
			Thread.Sleep(1);
			httpListener.Stop();
			if (!flag)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000391C File Offset: 0x00001B1C
		public void button(string button)
		{
			this.CheckInit();
			HttpListener httpListener = new HttpListener();
			string uriPrefix = "http://localhost:1337/" + button + "/";
			httpListener.Prefixes.Add(uriPrefix);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse httpListenerResponse = context.Response;
			httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
			httpListenerResponse.AddHeader("Via", "hugzho's big brain");
			httpListenerResponse.AddHeader("Location", "your kernel ;)");
			httpListenerResponse.AddHeader("Retry-After", "never lmao");
			httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
			httpListenerResponse.StatusCode = 420;
			httpListenerResponse.StatusDescription = "SHEESH";
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			httpListener.Stop();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003A2C File Offset: 0x00001C2C
		public void upgrade(string username, string key)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "upgrade";
			nameValueCollection["username"] = username;
			nameValueCollection["key"] = key;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003AD0 File Offset: 0x00001CD0
		public void license(string key)
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "license";
			nameValueCollection["key"] = key;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003B94 File Offset: 0x00001D94
		public void check()
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "check";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003C18 File Offset: 0x00001E18
		public void setvar(string var, string data)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "setvar";
			nameValueCollection["var"] = var;
			nameValueCollection["data"] = data;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public string getvar(string var)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "getvar";
			nameValueCollection["var"] = var;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003D5C File Offset: 0x00001F5C
		public void ban(string reason = null)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "ban";
			nameValueCollection["reason"] = reason;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003DEC File Offset: 0x00001FEC
		public string var(string varid)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "var";
			nameValueCollection["varid"] = varid;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003E94 File Offset: 0x00002094
		public List<api.users> fetchOnline()
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "fetchOnline";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			List<api.users> result;
			if (response_structure.success)
			{
				result = response_structure.users;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003F28 File Offset: 0x00002128
		public void fetchStats()
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "fetchStats";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_app_data(response_structure.appinfo);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003FC0 File Offset: 0x000021C0
		public List<api.msg> chatget(string channelname)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "chatget";
			nameValueCollection["channel"] = channelname;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			List<api.msg> result;
			if (response_structure.success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00004060 File Offset: 0x00002260
		public bool chatsend(string msg, string channelname)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "chatsend";
			nameValueCollection["message"] = msg;
			nameValueCollection["channel"] = channelname;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004110 File Offset: 0x00002310
		public bool checkblack()
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "checkblacklist";
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000041C4 File Offset: 0x000023C4
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "webhook";
			nameValueCollection["webid"] = webid;
			nameValueCollection["params"] = param;
			nameValueCollection["body"] = body;
			nameValueCollection["conttype"] = conttype;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			string result;
			if (!response_structure.success)
			{
				result = null;
			}
			else
			{
				result = response_structure.response;
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004294 File Offset: 0x00002494
		public byte[] download(string fileid)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "file";
			nameValueCollection["fileid"] = fileid;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			byte[] result;
			if (!response_structure.success)
			{
				result = null;
			}
			else
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004340 File Offset: 0x00002540
		public void log(string message)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "log";
			nameValueCollection["pcuser"] = Environment.UserName;
			nameValueCollection["message"] = message;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000043C8 File Offset: 0x000025C8
		public void changeUsername(string username)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "changeUsername";
			nameValueCollection["newUsername"] = username;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004458 File Offset: 0x00002658
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000044DC File Offset: 0x000026DC
		public static void error(string message)
		{
			string text = "Logs";
			string path = Path.Combine(text, "ErrorLogs.txt");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (!File.Exists(path))
			{
				using (File.Create(path))
				{
					File.AppendAllText(path, DateTime.Now.ToString() + " > This is the start of your error logs file");
				}
			}
			File.AppendAllText(path, DateTime.Now.ToString() + " > " + message + Environment.NewLine);
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000045D4 File Offset: 0x000027D4
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(api.smethod_0));
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.2/", post_data);
					stopwatch.Stop();
					api.responseTime = stopwatch.ElapsedMilliseconds;
					//ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
					api.sigCheck(Encoding.Default.GetString(bytes), webClient.ResponseHeaders["signature"], post_data.Get(0));
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004724 File Offset: 0x00002924
		private static bool smethod_0(object sender, X509Certificate certificate, object chain, SslPolicyErrors sslPolicyErrors)
		{
			bool result;
			if ((certificate.Issuer.Contains("Cloudflare Inc") || certificate.Issuer.Contains("Google Trust Services") || certificate.Issuer.Contains("Let's Encrypt")) && sslPolicyErrors <= SslPolicyErrors.None)
			{
				result = true;
			}
			else
			{
				api.error("SSL assertion fail, make sure you're not debugging Network. Disable internet firewall on router if possible. & echo: & echo If not, ask the developer of the program to use custom domains to fix this.");
				result = false;
			}
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004788 File Offset: 0x00002988
		private static void sigCheck(string resp, string signature, string type)
		{
			if (!(type == "log") && !(type == "file"))
			{
				try
				{
					string str = encryption.HashHMAC((!(type == "init")) ? api.enckey : api.enckey.Substring(17, 64), resp);
					if (!encryption.CheckStringsFixedTime(str, signature))
					{
						api.error("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: " + resp);
						Environment.Exit(0);
					}
				}
				catch
				{
					api.error("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: " + resp);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004830 File Offset: 0x00002A30
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004894 File Offset: 0x00002A94
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004908 File Offset: 0x00002B08
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000002 RID: 2
		public string name;

		// Token: 0x04000003 RID: 3
		public string ownerid;

		// Token: 0x04000004 RID: 4
		public string secret;

		// Token: 0x04000005 RID: 5
		public string version;

		// Token: 0x04000006 RID: 6
		public static long responseTime;

		// Token: 0x04000007 RID: 7
		private static string sessionid;

		// Token: 0x04000008 RID: 8
		private static string enckey;

		// Token: 0x04000009 RID: 9
		private bool initialized;

		// Token: 0x0400000A RID: 10
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400000B RID: 11
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400000C RID: 12
		public api.response_class response = new api.response_class();

		// Token: 0x0400000D RID: 13
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000003 RID: 3
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000025 RID: 37 RVA: 0x00002242 File Offset: 0x00000442
			// (set) Token: 0x06000026 RID: 38 RVA: 0x00004938 File Offset: 0x00002B38
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000027 RID: 39 RVA: 0x0000224A File Offset: 0x0000044A
			// (set) Token: 0x06000028 RID: 40 RVA: 0x0000494C File Offset: 0x00002B4C
			[DataMember]
			public bool newSession { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000029 RID: 41 RVA: 0x00002252 File Offset: 0x00000452
			// (set) Token: 0x0600002A RID: 42 RVA: 0x00004960 File Offset: 0x00002B60
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600002B RID: 43 RVA: 0x0000225A File Offset: 0x0000045A
			// (set) Token: 0x0600002C RID: 44 RVA: 0x00004974 File Offset: 0x00002B74
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600002D RID: 45 RVA: 0x00002262 File Offset: 0x00000462
			// (set) Token: 0x0600002E RID: 46 RVA: 0x00004988 File Offset: 0x00002B88
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600002F RID: 47 RVA: 0x0000226A File Offset: 0x0000046A
			// (set) Token: 0x06000030 RID: 48 RVA: 0x0000499C File Offset: 0x00002B9C
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000031 RID: 49 RVA: 0x00002272 File Offset: 0x00000472
			// (set) Token: 0x06000032 RID: 50 RVA: 0x000049B0 File Offset: 0x00002BB0
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000033 RID: 51 RVA: 0x0000227A File Offset: 0x0000047A
			// (set) Token: 0x06000034 RID: 52 RVA: 0x000049C4 File Offset: 0x00002BC4
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00002282 File Offset: 0x00000482
			// (set) Token: 0x06000036 RID: 54 RVA: 0x000049D8 File Offset: 0x00002BD8
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000037 RID: 55 RVA: 0x0000228A File Offset: 0x0000048A
			// (set) Token: 0x06000038 RID: 56 RVA: 0x00002292 File Offset: 0x00000492
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000039 RID: 57 RVA: 0x0000229B File Offset: 0x0000049B
			// (set) Token: 0x0600003A RID: 58 RVA: 0x000022A3 File Offset: 0x000004A3
			[DataMember]
			public List<api.users> users { get; set; }
		}

		// Token: 0x02000004 RID: 4
		public class msg
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600003C RID: 60 RVA: 0x000022AC File Offset: 0x000004AC
			// (set) Token: 0x0600003D RID: 61 RVA: 0x00004A04 File Offset: 0x00002C04
			public string message { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600003E RID: 62 RVA: 0x000022B4 File Offset: 0x000004B4
			// (set) Token: 0x0600003F RID: 63 RVA: 0x00004A18 File Offset: 0x00002C18
			public string author { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000040 RID: 64 RVA: 0x000022BC File Offset: 0x000004BC
			// (set) Token: 0x06000041 RID: 65 RVA: 0x00004A2C File Offset: 0x00002C2C
			public string timestamp { get; set; }
		}

		// Token: 0x02000005 RID: 5
		public class users
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000043 RID: 67 RVA: 0x000022C4 File Offset: 0x000004C4
			// (set) Token: 0x06000044 RID: 68 RVA: 0x00004A40 File Offset: 0x00002C40
			public string credential { get; set; }
		}

		// Token: 0x02000006 RID: 6
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000046 RID: 70 RVA: 0x000022CC File Offset: 0x000004CC
			// (set) Token: 0x06000047 RID: 71 RVA: 0x00004A54 File Offset: 0x00002C54
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000048 RID: 72 RVA: 0x000022D4 File Offset: 0x000004D4
			// (set) Token: 0x06000049 RID: 73 RVA: 0x00004A68 File Offset: 0x00002C68
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600004A RID: 74 RVA: 0x000022DC File Offset: 0x000004DC
			// (set) Token: 0x0600004B RID: 75 RVA: 0x00004A7C File Offset: 0x00002C7C
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600004C RID: 76 RVA: 0x000022E4 File Offset: 0x000004E4
			// (set) Token: 0x0600004D RID: 77 RVA: 0x00004A90 File Offset: 0x00002C90
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600004E RID: 78 RVA: 0x000022EC File Offset: 0x000004EC
			// (set) Token: 0x0600004F RID: 79 RVA: 0x00004AA4 File Offset: 0x00002CA4
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000050 RID: 80 RVA: 0x000022F4 File Offset: 0x000004F4
			// (set) Token: 0x06000051 RID: 81 RVA: 0x000022FC File Offset: 0x000004FC
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000007 RID: 7
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000053 RID: 83 RVA: 0x00002305 File Offset: 0x00000505
			// (set) Token: 0x06000054 RID: 84 RVA: 0x00004AB8 File Offset: 0x00002CB8
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000055 RID: 85 RVA: 0x0000230D File Offset: 0x0000050D
			// (set) Token: 0x06000056 RID: 86 RVA: 0x00004ACC File Offset: 0x00002CCC
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000057 RID: 87 RVA: 0x00002315 File Offset: 0x00000515
			// (set) Token: 0x06000058 RID: 88 RVA: 0x00004AE0 File Offset: 0x00002CE0
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000059 RID: 89 RVA: 0x0000231D File Offset: 0x0000051D
			// (set) Token: 0x0600005A RID: 90 RVA: 0x00004AF4 File Offset: 0x00002CF4
			[DataMember]
			public string version { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600005B RID: 91 RVA: 0x00002325 File Offset: 0x00000525
			// (set) Token: 0x0600005C RID: 92 RVA: 0x00004B08 File Offset: 0x00002D08
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600005D RID: 93 RVA: 0x0000232D File Offset: 0x0000052D
			// (set) Token: 0x0600005E RID: 94 RVA: 0x00004B1C File Offset: 0x00002D1C
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x02000008 RID: 8
		public class app_data_class
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000060 RID: 96 RVA: 0x00002335 File Offset: 0x00000535
			// (set) Token: 0x06000061 RID: 97 RVA: 0x00004B30 File Offset: 0x00002D30
			public string numUsers { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000062 RID: 98 RVA: 0x0000233D File Offset: 0x0000053D
			// (set) Token: 0x06000063 RID: 99 RVA: 0x00004B44 File Offset: 0x00002D44
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00002345 File Offset: 0x00000545
			// (set) Token: 0x06000065 RID: 101 RVA: 0x00004B58 File Offset: 0x00002D58
			public string numKeys { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000066 RID: 102 RVA: 0x0000234D File Offset: 0x0000054D
			// (set) Token: 0x06000067 RID: 103 RVA: 0x00004B6C File Offset: 0x00002D6C
			public string version { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00002355 File Offset: 0x00000555
			// (set) Token: 0x06000069 RID: 105 RVA: 0x00004B80 File Offset: 0x00002D80
			public string customerPanelLink { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600006A RID: 106 RVA: 0x0000235D File Offset: 0x0000055D
			// (set) Token: 0x0600006B RID: 107 RVA: 0x00004B94 File Offset: 0x00002D94
			public string downloadLink { get; set; }
		}

		// Token: 0x02000009 RID: 9
		public class user_data_class
		{
			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600006D RID: 109 RVA: 0x00002365 File Offset: 0x00000565
			// (set) Token: 0x0600006E RID: 110 RVA: 0x00004BA8 File Offset: 0x00002DA8
			public string username { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600006F RID: 111 RVA: 0x0000236D File Offset: 0x0000056D
			// (set) Token: 0x06000070 RID: 112 RVA: 0x00004BBC File Offset: 0x00002DBC
			public string ip { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000071 RID: 113 RVA: 0x00002375 File Offset: 0x00000575
			// (set) Token: 0x06000072 RID: 114 RVA: 0x00004BD0 File Offset: 0x00002DD0
			public string hwid { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000073 RID: 115 RVA: 0x0000237D File Offset: 0x0000057D
			// (set) Token: 0x06000074 RID: 116 RVA: 0x00004BE4 File Offset: 0x00002DE4
			public string createdate { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00002385 File Offset: 0x00000585
			// (set) Token: 0x06000076 RID: 118 RVA: 0x00004BF8 File Offset: 0x00002DF8
			public string lastlogin { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000077 RID: 119 RVA: 0x0000238D File Offset: 0x0000058D
			// (set) Token: 0x06000078 RID: 120 RVA: 0x00002395 File Offset: 0x00000595
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000A RID: 10
		public class Data
		{
			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600007A RID: 122 RVA: 0x0000239E File Offset: 0x0000059E
			// (set) Token: 0x0600007B RID: 123 RVA: 0x00004C0C File Offset: 0x00002E0C
			public string subscription { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600007C RID: 124 RVA: 0x000023A6 File Offset: 0x000005A6
			// (set) Token: 0x0600007D RID: 125 RVA: 0x00004C20 File Offset: 0x00002E20
			public string expiry { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600007E RID: 126 RVA: 0x000023AE File Offset: 0x000005AE
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00004C34 File Offset: 0x00002E34
			public string timeleft { get; set; }
		}

		// Token: 0x0200000B RID: 11
		public class response_class
		{
			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000081 RID: 129 RVA: 0x000023B6 File Offset: 0x000005B6
			// (set) Token: 0x06000082 RID: 130 RVA: 0x00004C48 File Offset: 0x00002E48
			public bool success { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000083 RID: 131 RVA: 0x000023BE File Offset: 0x000005BE
			// (set) Token: 0x06000084 RID: 132 RVA: 0x00004C5C File Offset: 0x00002E5C
			public string message { get; set; }
		}
	}
}
