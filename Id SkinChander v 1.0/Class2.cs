using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000043 RID: 67
internal class Class2
{
	// Token: 0x060001A9 RID: 425 RVA: 0x00015654 File Offset: 0x00013854
	static Class2()
	{
		Class2.uint_0 = new uint[]
		{
			3614090360U,
			3905402710U,
			606105819U,
			3250441966U,
			4118548399U,
			1200080426U,
			2821735955U,
			4249261313U,
			1770035416U,
			2336552879U,
			4294925233U,
			2304563134U,
			1804603682U,
			4254626195U,
			2792965006U,
			1236535329U,
			4129170786U,
			3225465664U,
			643717713U,
			3921069994U,
			3593408605U,
			38016083U,
			3634488961U,
			3889429448U,
			568446438U,
			3275163606U,
			4107603335U,
			1163531501U,
			2850285829U,
			4243563512U,
			1735328473U,
			2368359562U,
			4294588738U,
			2272392833U,
			1839030562U,
			4259657740U,
			2763975236U,
			1272893353U,
			4139469664U,
			3200236656U,
			681279174U,
			3936430074U,
			3572445317U,
			76029189U,
			3654602809U,
			3873151461U,
			530742520U,
			3299628645U,
			4096336452U,
			1126891415U,
			2878612391U,
			4237533241U,
			1700485571U,
			2399980690U,
			4293915773U,
			2240044497U,
			1873313359U,
			4264355552U,
			2734768916U,
			1309151649U,
			4149444226U,
			3174756917U,
			718787259U,
			3951481745U
		};
		Class2.bool_0 = false;
		Class2.bool_2 = false;
		Class2.object_3 = null;
		Class2.dictionary_0 = null;
		Class2.object_4 = new object();
		Class2.int_0 = 0;
		Class2.object_2 = new object();
		Class2.list_1 = null;
		Class2.list_0 = null;
		Class2.byte_1 = new byte[0];
		Class2.byte_0 = new byte[0];
		Class2.intptr_1 = IntPtr.Zero;
		Class2.intptr_0 = IntPtr.Zero;
		Class2.string_0 = new string[0];
		Class2.int_1 = new int[0];
		Class2.int_3 = 1;
		Class2.bool_4 = false;
		Class2.sortedList_0 = new SortedList();
		Class2.int_2 = 0;
		Class2.long_0 = 0L;
		Class2.object_1 = null;
		Class2.object_0 = null;
		Class2.long_1 = 0L;
		Class2.int_5 = 0;
		Class2.bool_3 = false;
		Class2.BmwDsdqaTf = false;
		Class2.int_4 = 0;
		Class2.intptr_3 = IntPtr.Zero;
		Class2.firstrundone = false;
		Class2.hashtable_0 = new Hashtable();
		Class2.delegate4_0 = null;
		Class2.delegate5_0 = null;
		Class2.delegate6_0 = null;
		Class2.delegate7_0 = null;
		Class2.delegate8_0 = null;
		Class2.delegate9_0 = null;
		Class2.intptr_2 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00002240 File Offset: 0x00000440
	private void method_0()
	{
	}

	// Token: 0x060001AB RID: 427 RVA: 0x000157D0 File Offset: 0x000139D0
	internal static byte[] smethod_0(object object_5)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - object_5.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)object_5.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)object_5.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < object_5.Length; i++)
		{
			array2[i] = object_5[i];
		}
		byte[] array3 = array2;
		int num4 = object_5.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class2.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class2.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class2.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class2.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class2.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class2.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class2.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class2.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class2.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class2.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class2.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class2.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class2.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class2.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class2.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class2.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class2.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class2.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class2.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class2.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class2.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class2.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class2.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class2.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class2.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class2.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class2.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class2.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class2.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class2.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class2.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class2.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class2.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class2.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class2.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class2.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class2.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class2.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class2.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class2.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class2.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class2.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class2.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class2.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class2.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class2.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class2.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class2.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class2.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class2.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class2.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class2.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class2.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class2.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class2.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class2.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class2.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class2.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class2.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class2.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class2.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class2.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class2.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class2.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x000023F2 File Offset: 0x000005F2
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_5)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + object_5[(int)uint_5] + Class2.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x060001AD RID: 429 RVA: 0x0000241B File Offset: 0x0000061B
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_5)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + object_5[(int)uint_5] + Class2.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00002444 File Offset: 0x00000644
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_5)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + object_5[(int)uint_5] + Class2.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x060001AF RID: 431 RVA: 0x0000246A File Offset: 0x0000066A
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_5)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + object_5[(int)uint_5] + Class2.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00002491 File Offset: 0x00000691
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x000024A3 File Offset: 0x000006A3
	internal static bool smethod_6()
	{
		if (!Class2.bool_0)
		{
			Class2.smethod_8();
			Class2.bool_0 = true;
		}
		return Class2.bool_2;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x000024BC File Offset: 0x000006BC
	internal Class2()
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00015E30 File Offset: 0x00014030
	private void method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)((int)byte_2[(int)(num7 + 3U)] << 24 | (int)byte_2[(int)(num7 + 2U)] << 16 | (int)byte_2[(int)(num7 + 1U)] << 8 | (int)byte_2[(int)num7]);
			uint num9 = 255U;
			int num10 = 0;
			uint num11;
			if (i == num2 - 1 && num > 0)
			{
				num11 = 0U;
				num4 += num8;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num11 <<= 8;
					}
					num11 |= (uint)byte_4[byte_4.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num8;
				num7 = (uint)num6;
				num11 = (uint)((int)byte_4[(int)(num7 + 3U)] << 24 | (int)byte_4[(int)(num7 + 2U)] << 16 | (int)byte_4[(int)(num7 + 1U)] << 8 | (int)byte_4[(int)num7]);
			}
			uint num13;
			uint num12 = num13 = num4;
			num13 = 13345U * (num13 & 131071U) - (num13 >> 17);
			num13 ^= num13 << 14;
			num13 += num13;
			num13 ^= num13 >> 13;
			num13 += 166914206U;
			num13 ^= num13 << 15;
			num13 += 1338824342U;
			num13 = ((num13 << 11) - 2031225047U ^ 166914206U) - num13;
			num4 = num12 + (uint)num13;
			if (i == num2 - 1 && num > 0)
			{
				uint num14 = num4 ^ num11;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num9 <<= 8;
						num10 += 8;
					}
					array[num6 + k] = (byte)((num14 & num9) >> num10);
				}
			}
			else
			{
				uint num15 = num4 ^ num11;
				array[num6] = (byte)(num15 & 255U);
				array[num6 + 1] = (byte)((num15 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num15 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num15 & 4278190080U) >> 24);
			}
		}
		Class2.byte_1 = array;
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00016080 File Offset: 0x00014280
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm result = null;
		if (Class2.smethod_6())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				try
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}
		return result;
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00016100 File Offset: 0x00014300
	internal static void smethod_8()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			Class2.bool_2 = true;
			return;
		}
		try
		{
			Class2.bool_2 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x000024C4 File Offset: 0x000006C4
	internal static byte[] smethod_9(byte[] byte_2)
	{
		if (!Class2.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return Class2.smethod_0(byte_2);
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0001614C File Offset: 0x0001434C
	internal static void smethod_10(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 > 0U)
		{
			int num = (uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1);
			stream_0.Read(byte_2, 0, num);
			Class2.smethod_11(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x000024DF File Offset: 0x000006DF
	internal static void smethod_11(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00016188 File Offset: 0x00014388
	internal static uint smethod_12(uint uint_1, int int_6, long long_2, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_6; i++)
		{
			binaryReader_0.BaseStream.Position = long_2 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x060001BA RID: 442 RVA: 0x000024ED File Offset: 0x000006ED
	private static uint smethod_13(uint uint_1)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	// Token: 0x060001BB RID: 443 RVA: 0x000161E4 File Offset: 0x000143E4
	private static void smethod_14(object object_5, int int_6)
	{
		Class6.smethod_2(0, new object[]
		{
			object_5,
			int_6
		}, null);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00016224 File Offset: 0x00014424
	internal static string smethod_15(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x060001BD RID: 445 RVA: 0x000024F9 File Offset: 0x000006F9
	private static int smethod_16()
	{
		return 5;
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00016254 File Offset: 0x00014454
	private static void smethod_17()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0001627C File Offset: 0x0001447C
	private static Delegate smethod_18(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_4,
			type_0
		});
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x000162E0 File Offset: 0x000144E0
	internal static object smethod_19(Assembly assembly_0)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_0).Location))
			{
				return ((Assembly)assembly_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString()))
			{
				return assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x060001C1 RID: 449
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x060001C2 RID: 450
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

	// Token: 0x060001C3 RID: 451 RVA: 0x000163F0 File Offset: 0x000145F0
	private static IntPtr smethod_20(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (Class2.delegate4_0 == null)
		{
			Class2.delegate4_0 = (Class2.Delegate4)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_26(), "Find ".Trim() + "ResourceA"), typeof(Class2.Delegate4));
		}
		return Class2.delegate4_0(intptr_4, string_1, uint_1);
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0001644C File Offset: 0x0001464C
	private static IntPtr smethod_21(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class2.delegate5_0 == null)
		{
			Class2.delegate5_0 = (Class2.Delegate5)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_26(), "Virtual ".Trim() + "Alloc"), typeof(Class2.Delegate5));
		}
		return Class2.delegate5_0(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x000164A8 File Offset: 0x000146A8
	private static int smethod_22(IntPtr intptr_4, IntPtr intptr_5, [In] [Out] byte[] byte_2, uint uint_1, out IntPtr intptr_6)
	{
		if (Class2.delegate6_0 == null)
		{
			Class2.delegate6_0 = (Class2.Delegate6)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_26(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class2.Delegate6));
		}
		return Class2.delegate6_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00016510 File Offset: 0x00014710
	private static int smethod_23(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
	{
		if (Class2.delegate7_0 == null)
		{
			Class2.delegate7_0 = (Class2.Delegate7)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_26(), "Virtual ".Trim() + "Protect"), typeof(Class2.Delegate7));
		}
		return Class2.delegate7_0(intptr_4, int_6, int_7, ref int_8);
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0001656C File Offset: 0x0001476C
	private static IntPtr smethod_24(uint uint_1, int int_6, uint uint_2)
	{
		if (Class2.delegate8_0 == null)
		{
			Class2.delegate8_0 = (Class2.Delegate8)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_26(), "Open ".Trim() + "Process"), typeof(Class2.Delegate8));
		}
		return Class2.delegate8_0(uint_1, int_6, uint_2);
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x000165C8 File Offset: 0x000147C8
	private static int smethod_25(IntPtr intptr_4)
	{
		if (Class2.delegate9_0 == null)
		{
			Class2.delegate9_0 = (Class2.Delegate9)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_26(), "Close ".Trim() + "Handle"), typeof(Class2.Delegate9));
		}
		return Class2.delegate9_0(intptr_4);
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x000024FC File Offset: 0x000006FC
	private static IntPtr smethod_26()
	{
		if (Class2.intptr_2 == IntPtr.Zero)
		{
			Class2.intptr_2 = Class2.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class2.intptr_2;
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00016620 File Offset: 0x00014820
	private static byte[] smethod_27(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00002532 File Offset: 0x00000732
	internal static byte[] smethod_28(MemoryStream memoryStream_0)
	{
		return ((MemoryStream)memoryStream_0).ToArray();
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00016680 File Offset: 0x00014880
	private static byte[] smethod_29(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class2.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			177,
			208,
			22,
			6,
			127,
			247,
			50,
			198,
			201,
			149,
			92,
			35,
			130,
			71,
			243,
			202,
			113,
			221,
			175,
			203,
			199,
			93,
			14,
			200,
			51,
			250,
			241,
			178,
			176,
			33,
			196,
			218
		};
		symmetricAlgorithm.IV = new byte[]
		{
			47,
			50,
			95,
			233,
			100,
			135,
			235,
			42,
			233,
			109,
			253,
			212,
			82,
			242,
			212,
			232
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return Class2.smethod_28(stream);
	}

	// Token: 0x060001CD RID: 461 RVA: 0x000166F0 File Offset: 0x000148F0
	private byte[] method_2()
	{
		return null;
	}

	// Token: 0x060001CE RID: 462 RVA: 0x000166F0 File Offset: 0x000148F0
	private byte[] method_3()
	{
		return null;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x000166F0 File Offset: 0x000148F0
	private byte[] method_4()
	{
		return null;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00016700 File Offset: 0x00014900
	private byte[] method_5()
	{
		return null;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0000253F File Offset: 0x0000073F
	private byte[] method_6()
	{
		int length = "{11111-22222-30001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0000255A File Offset: 0x0000075A
	private byte[] method_7()
	{
		int length = "{11111-22222-30001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00002575 File Offset: 0x00000775
	internal byte[] method_8()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00002590 File Offset: 0x00000790
	internal byte[] method_9()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00016700 File Offset: 0x00014900
	internal byte[] method_10()
	{
		return null;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00016700 File Offset: 0x00014900
	internal byte[] method_11()
	{
		return null;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x000025AB File Offset: 0x000007AB
	internal static object smethod_30(Class2.Class5 class5_0)
	{
		return class5_0.method_0();
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x000025B6 File Offset: 0x000007B6
	internal static void smethod_31(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x000025C5 File Offset: 0x000007C5
	internal static long smethod_32(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x060001DA RID: 474 RVA: 0x000025D0 File Offset: 0x000007D0
	internal static object smethod_33(Class2.Class5 class5_0, int int_6)
	{
		return class5_0.method_1(int_6);
	}

	// Token: 0x060001DB RID: 475 RVA: 0x000025DF File Offset: 0x000007DF
	internal static void smethod_34(Class2.Class5 class5_0)
	{
		class5_0.method_4();
	}

	// Token: 0x060001DC RID: 476 RVA: 0x000025EA File Offset: 0x000007EA
	internal static void smethod_35(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x060001DD RID: 477 RVA: 0x000025F5 File Offset: 0x000007F5
	internal static object smethod_36(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00002600 File Offset: 0x00000800
	internal static object smethod_37(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000260B File Offset: 0x0000080B
	internal static object smethod_38()
	{
		return Class2.smethod_7();
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00002612 File Offset: 0x00000812
	internal static void smethod_39(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00002621 File Offset: 0x00000821
	internal static object smethod_40(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00002634 File Offset: 0x00000834
	internal static object smethod_41()
	{
		return new MemoryStream();
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000263B File Offset: 0x0000083B
	internal static void smethod_42(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00002652 File Offset: 0x00000852
	internal static void smethod_43(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x0000265D File Offset: 0x0000085D
	internal static object smethod_44(MemoryStream memoryStream_0)
	{
		return Class2.smethod_28(memoryStream_0);
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00002668 File Offset: 0x00000868
	internal static void smethod_45(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00002673 File Offset: 0x00000873
	internal static object smethod_46(Assembly assembly_0)
	{
		return assembly_0.EntryPoint;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0000267E File Offset: 0x0000087E
	internal static bool smethod_47(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 == methodInfo_1;
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0000268D File Offset: 0x0000088D
	internal static bool smethod_48()
	{
		return null == null;
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00002693 File Offset: 0x00000893
	internal static object smethod_49()
	{
		return null;
	}

	// Token: 0x060001EB RID: 491 RVA: 0x0000268D File Offset: 0x0000088D
	internal static bool smethod_50()
	{
		return null == null;
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00002693 File Offset: 0x00000893
	internal static object smethod_51()
	{
		return null;
	}

	// Token: 0x040002A5 RID: 677
	private static bool bool_0;

	// Token: 0x040002A6 RID: 678
	private static Dictionary<int, int> dictionary_0;

	// Token: 0x040002A7 RID: 679
	private static List<int> list_0;

	// Token: 0x040002A8 RID: 680
	internal static object object_0;

	// Token: 0x040002A9 RID: 681
	private static bool bool_1 = false;

	// Token: 0x040002AA RID: 682
	private static Class2.Delegate8 delegate8_0;

	// Token: 0x040002AB RID: 683
	private static int int_0;

	// Token: 0x040002AC RID: 684
	private static IntPtr intptr_0;

	// Token: 0x040002AD RID: 685
	private static byte[] byte_0;

	// Token: 0x040002AE RID: 686
	private static int[] int_1;

	// Token: 0x040002AF RID: 687
	internal static object object_1;

	// Token: 0x040002B0 RID: 688
	private static bool BmwDsdqaTf;

	// Token: 0x040002B1 RID: 689
	private static Class2.Delegate7 delegate7_0;

	// Token: 0x040002B2 RID: 690
	private static Class2.Delegate9 delegate9_0;

	// Token: 0x040002B3 RID: 691
	private static List<string> list_1;

	// Token: 0x040002B4 RID: 692
	private static IntPtr intptr_1;

	// Token: 0x040002B5 RID: 693
	private static uint[] uint_0;

	// Token: 0x040002B6 RID: 694
	internal static Hashtable hashtable_0;

	// Token: 0x040002B7 RID: 695
	private static SortedList sortedList_0;

	// Token: 0x040002B8 RID: 696
	private static int int_2;

	// Token: 0x040002B9 RID: 697
	private static byte[] byte_1;

	// Token: 0x040002BA RID: 698
	private static bool bool_2;

	// Token: 0x040002BB RID: 699
	private static int int_3;

	// Token: 0x040002BC RID: 700
	private static string[] string_0;

	// Token: 0x040002BD RID: 701
	private static long long_0;

	// Token: 0x040002BE RID: 702
	private static bool bool_3;

	// Token: 0x040002BF RID: 703
	private static IntPtr intptr_2;

	// Token: 0x040002C0 RID: 704
	private static Class2.Delegate5 delegate5_0;

	// Token: 0x040002C1 RID: 705
	private static object object_2;

	// Token: 0x040002C2 RID: 706
	internal static Assembly tMmvmVecn = typeof(Class2).Assembly;

	// Token: 0x040002C3 RID: 707
	private static IntPtr intptr_3;

	// Token: 0x040002C4 RID: 708
	private static int int_4;

	// Token: 0x040002C5 RID: 709
	private static bool bool_4;

	// Token: 0x040002C6 RID: 710
	internal static object object_3;

	// Token: 0x040002C7 RID: 711
	private static long long_1;

	// Token: 0x040002C8 RID: 712
	[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
	private static bool firstrundone;

	// Token: 0x040002C9 RID: 713
	private static int int_5;

	// Token: 0x040002CA RID: 714
	private static object object_4;

	// Token: 0x040002CB RID: 715
	private static Class2.Delegate6 delegate6_0;

	// Token: 0x040002CC RID: 716
	private static Class2.Delegate4 delegate4_0;

	// Token: 0x02000044 RID: 68
	// (Invoke) Token: 0x060001EE RID: 494
	private delegate void Delegate1(object o);

	// Token: 0x02000045 RID: 69
	internal class Attribute0 : Attribute
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00002696 File Offset: 0x00000896
		public Attribute0(object object_0)
		{
		}

		// Token: 0x02000046 RID: 70
		internal class Class3<T>
		{
			// Token: 0x060001F3 RID: 499 RVA: 0x0000269E File Offset: 0x0000089E
			internal static bool smethod_0()
			{
				return Class2.Attribute0.Class3<T>.object_0 == null;
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x000026A8 File Offset: 0x000008A8
			internal static object smethod_1()
			{
				return Class2.Attribute0.Class3<T>.object_0;
			}

			// Token: 0x040002CD RID: 717
			private static object object_0;
		}
	}

	// Token: 0x02000047 RID: 71
	internal class Class4
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x00016710 File Offset: 0x00014910
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class2.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class2.smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	// Token: 0x02000048 RID: 72
	// (Invoke) Token: 0x060001F8 RID: 504
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate2(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x02000049 RID: 73
	// (Invoke) Token: 0x060001FC RID: 508
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate3();

	// Token: 0x0200004A RID: 74
	internal struct Struct0
	{
		// Token: 0x040002CE RID: 718
		internal bool MuWlxphtb0;

		// Token: 0x040002CF RID: 719
		internal byte[] byte_0;
	}

	// Token: 0x0200004B RID: 75
	internal class Class5
	{
		// Token: 0x060001FF RID: 511 RVA: 0x000026AF File Offset: 0x000008AF
		public Class5(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000026C3 File Offset: 0x000008C3
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000026D0 File Offset: 0x000008D0
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000026DE File Offset: 0x000008DE
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000026EE File Offset: 0x000008EE
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000026FB File Offset: 0x000008FB
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x040002D0 RID: 720
		private BinaryReader binaryReader_0;
	}

	// Token: 0x0200004C RID: 76
	// (Invoke) Token: 0x06000206 RID: 518
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate4(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x0200004D RID: 77
	// (Invoke) Token: 0x0600020A RID: 522
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate5(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x0200004E RID: 78
	// (Invoke) Token: 0x0600020E RID: 526
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate6(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x0200004F RID: 79
	// (Invoke) Token: 0x06000212 RID: 530
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x02000050 RID: 80
	// (Invoke) Token: 0x06000216 RID: 534
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate8(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x02000051 RID: 81
	// (Invoke) Token: 0x0600021A RID: 538
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate9(IntPtr ptr);

	// Token: 0x02000052 RID: 82
	[Flags]
	private enum Enum0
	{

	}
}
