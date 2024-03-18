using System;
using System.Security.Cryptography;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200000D RID: 13
	public static class encryption
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00004C9C File Offset: 0x00002E9C
		public static string HashHMAC(string enckey, string resp)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(enckey);
			byte[] bytes2 = Encoding.ASCII.GetBytes(resp);
			HMACSHA256 hmacsha = new HMACSHA256(bytes);
			return encryption.byte_arr_to_str(hmacsha.ComputeHash(bytes2));
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public static string byte_arr_to_str(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004D38 File Offset: 0x00002F38
		public static byte[] str_to_byte_arr(string hex)
		{
			byte[] result;
			try
			{
				int length = hex.Length;
				byte[] array = new byte[length / 2];
				for (int i = 0; i < length; i += 2)
				{
					array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
				}
				result = array;
			}
			catch
			{
				api.error("The session has ended, open program again.");
				Environment.Exit(0);
				result = null;
			}
			return result;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public static bool CheckStringsFixedTime(string str1, string str2)
		{
			bool result;
			if (str1.Length == str2.Length)
			{
				int num = 0;
				for (int i = 0; i < str1.Length; i++)
				{
					num |= (int)(str1[i] ^ str2[i]);
				}
				result = (num == 0);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004E14 File Offset: 0x00003014
		public static string iv_key()
		{
			return Guid.NewGuid().ToString().Substring(0, 16);
		}
	}
}
