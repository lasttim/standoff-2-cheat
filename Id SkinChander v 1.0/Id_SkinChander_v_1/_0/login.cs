using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KeyAuth;

namespace Id_SkinChander_v_1._0
{
	public partial class login : Form
	{
		public login()
		{
            this.InitializeComponent();
        }

		private void login_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		private void login_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		private static string random_string()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			login.KeyAuthApp.login(this.uname.Text, this.pswrd.Text);
			if (!login.KeyAuthApp.response.success)
			{
				this.uname.Clear();
				this.pswrd.Clear();
			}
			else
			{
				Loader loader = new Loader();
				loader.Show();
				base.Hide();
			}
		}

		private void login_Load(object sender, EventArgs e)
		{
			login.KeyAuthApp.init();
			if (login.KeyAuthApp.response.message == "invalidver")
			{
				if (!string.IsNullOrEmpty(login.KeyAuthApp.app_data.downloadLink))
				{
					DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
					DialogResult dialogResult2 = dialogResult;
					DialogResult dialogResult3 = dialogResult2;
					if (dialogResult3 != DialogResult.Yes)
					{
						if (dialogResult3 != DialogResult.No)
						{
							MessageBox.Show("Invalid option");
							Environment.Exit(0);
						}
						else
						{
							WebClient webClient = new WebClient();
							string text = Application.ExecutablePath;
							string str = login.random_string();
							text = text.Replace(".exe", "-" + str + ".exe");
							webClient.DownloadFile(login.KeyAuthApp.app_data.downloadLink, text);
							Process.Start(text);
							Process.Start(new ProcessStartInfo
							{
								Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
								WindowStyle = ProcessWindowStyle.Hidden,
								CreateNoWindow = true,
								FileName = "cmd.exe"
							});
							Environment.Exit(0);
						}
					}
					else
					{
						Process.Start(login.KeyAuthApp.app_data.downloadLink);
						Environment.Exit(0);
					}
				}
				MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
				Environment.Exit(0);
			}
			if (!login.KeyAuthApp.response.success)
			{
				MessageBox.Show(login.KeyAuthApp.response.message);
				Environment.Exit(0);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			login.KeyAuthApp.init();
			login.KeyAuthApp.check();
			this.timer1.Enabled = false;
			if (File.Exists(this.path + "/Userdata.dat"))
			{
				string text = File.ReadAllText(this.path + "/Userdata.dat");
				string[] array = text.Split(new char[]
				{
					':'
				});
				login.KeyAuthApp.login(array[0], array[1]);
				if (login.KeyAuthApp.response.success)
				{
					Loader loader = new Loader();
					loader.Show();
					base.Hide();
				}
				else
				{
					this.msg.Text = login.KeyAuthApp.response.message;
					this.msg.Show();
				}
			}
		}

		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
        //public static api KeyAuthApp = new api("dimker", "R05eilFGyy", "b14b22b37cad76aa33f7bcadd143f0d911fe9d9176cf46aaa871f7c3b194e1f4", "1.0");
        public static api KeyAuthApp = new api("", "", "", "1.0");

		private string path;

		private Point lastPoint;
	}
}
