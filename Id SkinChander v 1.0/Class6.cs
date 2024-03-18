using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

// Token: 0x02000053 RID: 83
internal class Class6
{
	// Token: 0x0600021D RID: 541 RVA: 0x00002708 File Offset: 0x00000908
	internal static object[] smethod_0()
	{
		return new object[1];
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00016790 File Offset: 0x00014990
	internal static object[] smethod_1<T>(int int_1, object object_1, object object_2, ref T gparam_0)
	{
		Class6.Class12 @class = null;
		object obj = Class6.object_0;
		lock (obj)
		{
			if (!Class6.bool_0)
			{
				Class6.bool_0 = true;
				Class6.smethod_4();
			}
			if (Class6.class12_0[int_1] != null)
			{
				@class = Class6.class12_0[int_1];
			}
			else
			{
				Class6.binaryReader_0.BaseStream.Position = (long)Class6.int_0[int_1];
				@class = new Class6.Class12();
				Module module = typeof(Class6).Module;
				int metadataToken = Class6.smethod_6(Class6.binaryReader_0);
				int num = Class6.smethod_6(Class6.binaryReader_0);
				int num2 = Class6.smethod_6(Class6.binaryReader_0);
				int num3 = Class6.smethod_6(Class6.binaryReader_0);
				@class.object_0 = module.ResolveMethod(metadataToken);
				ParameterInfo[] parameters = @class.object_0.GetParameters();
				@class.class8_0 = new Class6.Class8[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					Class6.Class8 class2 = new Class6.Class8();
					class2.bool_0 = type.IsByRef;
					class2.int_0 = i;
					@class.class8_0[i] = class2;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					Class6.Enum1 enum1_;
					if (type == typeof(string))
					{
						enum1_ = (Class6.Enum1)14;
					}
					else if (type == typeof(byte))
					{
						enum1_ = (Class6.Enum1)2;
					}
					else if (type == typeof(sbyte))
					{
						enum1_ = (Class6.Enum1)1;
					}
					else if (type == typeof(short))
					{
						enum1_ = (Class6.Enum1)3;
					}
					else if (type == typeof(ushort))
					{
						enum1_ = (Class6.Enum1)4;
					}
					else if (type == typeof(int))
					{
						enum1_ = (Class6.Enum1)5;
					}
					else if (type == typeof(uint))
					{
						enum1_ = (Class6.Enum1)6;
					}
					else if (type == typeof(long))
					{
						enum1_ = (Class6.Enum1)7;
					}
					else if (type == typeof(ulong))
					{
						enum1_ = (Class6.Enum1)8;
					}
					else if (type == typeof(float))
					{
						enum1_ = (Class6.Enum1)9;
					}
					else if (type == typeof(double))
					{
						enum1_ = (Class6.Enum1)10;
					}
					else if (type == typeof(bool))
					{
						enum1_ = (Class6.Enum1)11;
					}
					else if (type == typeof(IntPtr))
					{
						enum1_ = (Class6.Enum1)12;
					}
					else if (type == typeof(UIntPtr))
					{
						enum1_ = (Class6.Enum1)13;
					}
					else if (type == typeof(char))
					{
						enum1_ = (Class6.Enum1)15;
					}
					else
					{
						enum1_ = (Class6.Enum1)0;
					}
					class2.enum1_0 = enum1_;
				}
				@class.UqaYjxudZI = new List<Class6.Class9>(num);
				for (int j = 0; j < num; j++)
				{
					int num4 = Class6.smethod_6(Class6.binaryReader_0);
					Class6.Class9 class3 = new Class6.Class9();
					class3.type_0 = null;
					if (num4 >= 0 && num4 < 50)
					{
						class3.enum1_0 = (Class6.Enum1)(num4 & 31);
						class3.bool_0 = ((num4 & 32) > 0);
					}
					class3.int_0 = j;
					@class.UqaYjxudZI.Add(class3);
				}
				@class.list_1 = new List<Class6.Class10>(num2);
				for (int k = 0; k < num2; k++)
				{
					int num5 = Class6.smethod_6(Class6.binaryReader_0);
					int int_2 = Class6.smethod_6(Class6.binaryReader_0);
					Class6.Class10 class4 = new Class6.Class10();
					class4.int_0 = num5;
					class4.int_1 = int_2;
					Class6.Class11 class5 = new Class6.Class11();
					class4.class11_0 = class5;
					num5 = Class6.smethod_6(Class6.binaryReader_0);
					int_2 = Class6.smethod_6(Class6.binaryReader_0);
					int num6 = Class6.smethod_6(Class6.binaryReader_0);
					class5.int_0 = num5;
					class5.int_1 = int_2;
					class5.int_3 = num6;
					if (num6 == 0)
					{
						class5.type_0 = module.ResolveType(Class6.smethod_6(Class6.binaryReader_0));
					}
					else if (num6 == 1)
					{
						class5.int_2 = Class6.smethod_6(Class6.binaryReader_0);
					}
					else
					{
						Class6.smethod_6(Class6.binaryReader_0);
					}
					@class.list_1.Add(class4);
				}
				@class.list_1.Sort(new Comparison<Class6.Class10>(Class6.Class32<T>.<>9.method_0));
				@class.list_0 = new List<Class6.Class7>(num3);
				for (int l = 0; l < num3; l++)
				{
					Class6.Class7 class6 = new Class6.Class7();
					byte b = Class6.binaryReader_0.ReadByte();
					class6.enum3_0 = (Class6.Enum3)b;
					if (b >= 176)
					{
						throw new Exception();
					}
					int num7 = (int)Class6.byte_0[(int)b];
					if (num7 == 0)
					{
						class6.object_0 = null;
					}
					else
					{
						object obj2;
						switch (num7)
						{
						case 1:
							obj2 = Class6.smethod_6(Class6.binaryReader_0);
							break;
						case 2:
							obj2 = Class6.binaryReader_0.ReadInt64();
							break;
						case 3:
							obj2 = Class6.binaryReader_0.ReadSingle();
							break;
						case 4:
							obj2 = Class6.binaryReader_0.ReadDouble();
							break;
						case 5:
						{
							int num8 = Class6.smethod_6(Class6.binaryReader_0);
							int[] array = new int[num8];
							for (int m = 0; m < num8; m++)
							{
								array[m] = Class6.smethod_6(Class6.binaryReader_0);
							}
							obj2 = array;
							break;
						}
						default:
							throw new Exception();
						}
						class6.object_0 = obj2;
					}
					@class.list_0.Add(class6);
				}
				Class6.class12_0[int_1] = @class;
			}
		}
		Class6.Class15 class7 = new Class6.Class15();
		class7.class12_0 = @class;
		ParameterInfo[] parameters2 = @class.object_0.GetParameters();
		bool flag2 = false;
		int num9 = 0;
		if (@class.object_0 is MethodInfo && ((MethodInfo)@class.object_0).ReturnType != typeof(void))
		{
			flag2 = true;
		}
		if (@class.object_0.IsStatic)
		{
			class7.class17_0 = new Class6.Class17[parameters2.Length];
			for (int n = 0; n < parameters2.Length; n++)
			{
				Type parameterType = parameters2[n].ParameterType;
				class7.class17_0[n] = Class6.Class17.smethod_1(parameterType, object_1[n]);
				if (parameterType.IsByRef)
				{
					num9++;
				}
			}
		}
		else
		{
			class7.class17_0 = new Class6.Class17[parameters2.Length + 1];
			if (@class.object_0.DeclaringType.IsValueType)
			{
				class7.class17_0[0] = new Class6.Class28(new Class6.Class29(object_2), @class.object_0.DeclaringType);
			}
			else
			{
				class7.class17_0[0] = new Class6.Class29(object_2);
			}
			for (int num10 = 0; num10 < parameters2.Length; num10++)
			{
				Type parameterType2 = parameters2[num10].ParameterType;
				if (parameterType2.IsByRef)
				{
					class7.class17_0[num10 + 1] = Class6.Class17.smethod_1(parameterType2, object_1[num10]);
					num9++;
				}
				else
				{
					class7.class17_0[num10 + 1] = Class6.Class17.smethod_1(parameterType2, object_1[num10]);
				}
			}
		}
		class7.class17_1 = new Class6.Class17[@class.UqaYjxudZI.Count];
		for (int num11 = 0; num11 < @class.UqaYjxudZI.Count; num11++)
		{
			Class6.Class9 class8 = @class.UqaYjxudZI[num11];
			switch (class8.enum1_0)
			{
			case (Class6.Enum1)0:
				class7.class17_1[num11] = null;
				break;
			case (Class6.Enum1)1:
			case (Class6.Enum1)2:
			case (Class6.Enum1)3:
			case (Class6.Enum1)4:
			case (Class6.Enum1)5:
			case (Class6.Enum1)6:
			case (Class6.Enum1)11:
			case (Class6.Enum1)15:
				class7.class17_1[num11] = new Class6.Class19(0, class8.enum1_0);
				break;
			case (Class6.Enum1)7:
			case (Class6.Enum1)8:
				class7.class17_1[num11] = new Class6.Class20(0L, class8.enum1_0);
				break;
			case (Class6.Enum1)9:
			case (Class6.Enum1)10:
				class7.class17_1[num11] = new Class6.Class22(0.0, class8.enum1_0);
				break;
			case (Class6.Enum1)12:
				class7.class17_1[num11] = new Class6.Class21(IntPtr.Zero);
				break;
			case (Class6.Enum1)13:
				class7.class17_1[num11] = new Class6.Class21(UIntPtr.Zero);
				break;
			case (Class6.Enum1)14:
				class7.class17_1[num11] = null;
				break;
			case (Class6.Enum1)16:
				class7.class17_1[num11] = new Class6.Class29(null);
				break;
			}
		}
		try
		{
			class7.method_0();
		}
		finally
		{
			class7.method_1();
		}
		int num12 = 0;
		if (flag2)
		{
			num12 = 1;
		}
		num12 += num9;
		object[] array2 = new object[num12];
		if (flag2)
		{
			array2[0] = null;
		}
		if (@class.object_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)@class.object_0;
			if (methodInfo.ReturnType != typeof(void) && class7.class17_2 != null)
			{
				array2[0] = class7.class17_2.vmethod_3(methodInfo.ReturnType);
			}
		}
		if (num9 > 0)
		{
			int num13 = 0;
			if (flag2)
			{
				num13++;
			}
			for (int num14 = 0; num14 < parameters2.Length; num14++)
			{
				Type type2 = parameters2[num14].ParameterType;
				if (type2.IsByRef)
				{
					type2 = type2.GetElementType();
					if (class7.class17_0[num14] != null)
					{
						if (@class.object_0.IsStatic)
						{
							array2[num13] = class7.class17_0[num14].vmethod_3(type2);
						}
						else
						{
							array2[num13] = class7.class17_0[num14 + 1].vmethod_3(type2);
						}
					}
					else
					{
						array2[num13] = null;
					}
					num13++;
				}
			}
		}
		if (!@class.object_0.IsStatic && @class.object_0.DeclaringType.IsValueType)
		{
			gparam_0 = (T)((object)class7.class17_0[0].vmethod_3(@class.object_0.DeclaringType));
		}
		return array2;
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00017174 File Offset: 0x00015374
	internal static object[] smethod_2(int int_1, object object_1, object object_2)
	{
		int num = 0;
		return Class6.smethod_1<int>(int_1, object_1, object_2, ref num);
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00002710 File Offset: 0x00000910
	internal static object[] smethod_3<T>(int int_1, object object_1, ref T gparam_0)
	{
		return Class6.smethod_1<T>(int_1, object_1, gparam_0, ref gparam_0);
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00017190 File Offset: 0x00015390
	internal static void smethod_4()
	{
		if (Class6.int_0 == null)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class6).Assembly.GetManifestResourceStream("vEq24P7VPWGTlVNXgE.jPhenGyx1C5wWl0CXk"));
			binaryReader.BaseStream.Position = 0L;
			byte[] byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			Class6.smethod_5(byte_);
		}
	}

	// Token: 0x06000222 RID: 546 RVA: 0x000171F8 File Offset: 0x000153F8
	internal static void smethod_5(byte[] byte_1)
	{
		Class6.binaryReader_0 = new BinaryReader(new MemoryStream(byte_1));
		Class6.byte_0 = new byte[255];
		int num = Class6.smethod_6(Class6.binaryReader_0);
		for (int i = 0; i < num; i++)
		{
			int num2 = (int)Class6.binaryReader_0.ReadByte();
			Class6.byte_0[num2] = Class6.binaryReader_0.ReadByte();
		}
		num = Class6.smethod_6(Class6.binaryReader_0);
		Class6.list_0 = new List<string>(num);
		for (int j = 0; j < num; j++)
		{
			Class6.list_0.Add(Encoding.Unicode.GetString(Class6.binaryReader_0.ReadBytes(Class6.smethod_6(Class6.binaryReader_0))));
		}
		num = Class6.smethod_6(Class6.binaryReader_0);
		Class6.class12_0 = new Class6.Class12[num];
		Class6.int_0 = new int[num];
		for (int k = 0; k < num; k++)
		{
			Class6.class12_0[k] = null;
			Class6.int_0[k] = Class6.smethod_6(Class6.binaryReader_0);
		}
		int num3 = (int)Class6.binaryReader_0.BaseStream.Position;
		for (int l = 0; l < num; l++)
		{
			int num4 = Class6.int_0[l];
			Class6.int_0[l] = num3;
			num3 += num4;
		}
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00017340 File Offset: 0x00015540
	internal static int smethod_6(BinaryReader binaryReader_1)
	{
		bool flag = false;
		uint num = (uint)binaryReader_1.ReadByte();
		uint num2 = 0U | (num & 63U);
		if ((num & 64U) != 0U)
		{
			flag = true;
		}
		if (num >= 128U)
		{
			int num3 = 0;
			for (;;)
			{
				uint num4 = (uint)binaryReader_1.ReadByte();
				num2 |= (num4 & 127U) << 7 * num3 + 6;
				if (num4 < 128U)
				{
					break;
				}
				num3++;
			}
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
		else
		{
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
	}

	// Token: 0x040002D2 RID: 722
	internal static Class6.Class12[] class12_0 = null;

	// Token: 0x040002D3 RID: 723
	internal static int[] int_0 = null;

	// Token: 0x040002D4 RID: 724
	internal static List<string> list_0;

	// Token: 0x040002D5 RID: 725
	private static BinaryReader binaryReader_0;

	// Token: 0x040002D6 RID: 726
	private static byte[] byte_0;

	// Token: 0x040002D7 RID: 727
	private static bool bool_0 = false;

	// Token: 0x040002D8 RID: 728
	private static object object_0 = new object();

	// Token: 0x02000054 RID: 84
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct1
	{
		// Token: 0x040002D9 RID: 729
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x040002DA RID: 730
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x040002DB RID: 731
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x040002DC RID: 732
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x040002DD RID: 733
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x040002DE RID: 734
		[FieldOffset(0)]
		public int int_0;
	}

	// Token: 0x02000055 RID: 85
	private class Class19 : Class6.Class18
	{
		// Token: 0x06000226 RID: 550 RVA: 0x000173E8 File Offset: 0x000155E8
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			this.struct1_0 = ((Class6.Class19)class17_0).struct1_0;
			this.enum1_0 = ((Class6.Class19)class17_0).enum1_0;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00017418 File Offset: 0x00015618
		internal override void vmethod_1(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001742C File Offset: 0x0001562C
		public Class19(bool bool_0)
		{
			this.enum4_0 = (Class6.Enum4)1;
			if (!bool_0)
			{
				this.struct1_0.int_0 = 0;
			}
			else
			{
				this.struct1_0.int_0 = 1;
			}
			this.enum1_0 = (Class6.Enum1)11;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00017470 File Offset: 0x00015670
		public Class19(Class6.Class19 class19_0)
		{
			this.enum4_0 = class19_0.enum4_0;
			this.struct1_0.int_0 = class19_0.struct1_0.int_0;
			this.enum1_0 = class19_0.enum1_0;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002725 File Offset: 0x00000925
		public override Class6.Class18 vmethod_69()
		{
			return new Class6.Class19(this);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000174B4 File Offset: 0x000156B4
		public Class19(int int_0)
		{
			this.enum4_0 = (Class6.Enum4)1;
			this.struct1_0.int_0 = int_0;
			this.enum1_0 = (Class6.Enum1)5;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000174E4 File Offset: 0x000156E4
		public Class19(uint uint_0)
		{
			this.enum4_0 = (Class6.Enum4)1;
			this.struct1_0.uint_0 = uint_0;
			this.enum1_0 = (Class6.Enum1)6;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00017514 File Offset: 0x00015714
		public Class19(int int_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)1;
			this.struct1_0.int_0 = int_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00017544 File Offset: 0x00015744
		public Class19(uint uint_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)1;
			this.struct1_0.uint_0 = uint_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00017574 File Offset: 0x00015774
		public override bool vmethod_10()
		{
			Class6.Enum1 @enum = this.enum1_0;
			switch (@enum)
			{
			case (Class6.Enum1)1:
			case (Class6.Enum1)3:
			case (Class6.Enum1)5:
			case (Class6.Enum1)7:
				goto IL_4B;
			case (Class6.Enum1)2:
			case (Class6.Enum1)4:
			case (Class6.Enum1)6:
				break;
			default:
				if (@enum == (Class6.Enum1)11)
				{
					goto IL_4B;
				}
				if (@enum == (Class6.Enum1)15)
				{
					goto IL_4B;
				}
				break;
			}
			return this.struct1_0.uint_0 == 0U;
			IL_4B:
			return this.struct1_0.int_0 == 0;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000272D File Offset: 0x0000092D
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000175DC File Offset: 0x000157DC
		public override Class6.Class17 vmethod_11(Class6.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class6.Enum1)1:
				return this.vmethod_13();
			case (Class6.Enum1)2:
				return this.vmethod_14();
			case (Class6.Enum1)3:
				return this.vmethod_15();
			case (Class6.Enum1)4:
				return this.vmethod_16();
			case (Class6.Enum1)5:
				return this.vmethod_17();
			case (Class6.Enum1)6:
				return this.vmethod_18();
			case (Class6.Enum1)11:
				return this.vmethod_12();
			case (Class6.Enum1)15:
				return this.method_7();
			case (Class6.Enum1)16:
				return this.vmethod_69();
			}
			throw new Exception(((Class6.Enum5)4).ToString());
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00017688 File Offset: 0x00015888
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 != null && Nullable.GetUnderlyingType(type_0) != null)
			{
				type_0 = Nullable.GetUnderlyingType(type_0);
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum1_0)
				{
				case (Class6.Enum1)1:
					return this.struct1_0.sbyte_0;
				case (Class6.Enum1)2:
					return this.struct1_0.byte_0;
				case (Class6.Enum1)3:
					return this.struct1_0.short_0;
				case (Class6.Enum1)4:
					return this.struct1_0.ushort_0;
				case (Class6.Enum1)5:
					return this.struct1_0.int_0;
				case (Class6.Enum1)6:
					return this.struct1_0.uint_0;
				case (Class6.Enum1)7:
					return (long)this.struct1_0.int_0;
				case (Class6.Enum1)8:
					return (ulong)this.struct1_0.uint_0;
				case (Class6.Enum1)11:
					return this.yQwppAuByG();
				case (Class6.Enum1)15:
					return (char)this.struct1_0.int_0;
				}
				return this.struct1_0.int_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct1_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct1_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct1_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct1_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct1_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct1_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return (long)this.struct1_0.int_0;
			}
			if (type_0 == typeof(ulong))
			{
				return (ulong)this.struct1_0.uint_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct1_0.int_0;
			}
			if (type_0 == typeof(IntPtr))
			{
				return new IntPtr(this.struct1_0.int_0);
			}
			if (type_0 == typeof(UIntPtr))
			{
				return new UIntPtr(this.struct1_0.uint_0);
			}
			if (!type_0.IsEnum)
			{
				throw new Class6.Exception1();
			}
			return this.method_6(type_0);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000179D0 File Offset: 0x00015BD0
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct1_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct1_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct1_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct1_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct1_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct1_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, (long)this.struct1_0.int_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, (ulong)this.struct1_0.uint_0);
			}
			if (!(underlyingType == typeof(char)))
			{
				return Enum.ToObject(type_0, this.struct1_0.int_0);
			}
			return Enum.ToObject(type_0, (ushort)this.struct1_0.int_0);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00017B50 File Offset: 0x00015D50
		public override Class6.Class19 vmethod_12()
		{
			return new Class6.Class19(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002738 File Offset: 0x00000938
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002740 File Offset: 0x00000940
		public override Class6.Class19 vmethod_13()
		{
			return new Class6.Class19((int)this.struct1_0.sbyte_0, (Class6.Enum1)1);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002753 File Offset: 0x00000953
		public Class6.Class19 method_7()
		{
			return new Class6.Class19(this.struct1_0.int_0, (Class6.Enum1)15);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002767 File Offset: 0x00000967
		public override Class6.Class19 vmethod_14()
		{
			return new Class6.Class19((uint)this.struct1_0.byte_0, (Class6.Enum1)2);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000277A File Offset: 0x0000097A
		public override Class6.Class19 vmethod_15()
		{
			return new Class6.Class19((int)this.struct1_0.short_0, (Class6.Enum1)3);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000278D File Offset: 0x0000098D
		public override Class6.Class19 vmethod_16()
		{
			return new Class6.Class19((uint)this.struct1_0.ushort_0, (Class6.Enum1)4);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000027A0 File Offset: 0x000009A0
		public override Class6.Class19 vmethod_17()
		{
			return new Class6.Class19(this.struct1_0.int_0, (Class6.Enum1)5);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000027B3 File Offset: 0x000009B3
		public override Class6.Class19 vmethod_18()
		{
			return new Class6.Class19(this.struct1_0.uint_0, (Class6.Enum1)6);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000027C6 File Offset: 0x000009C6
		public override Class6.Class20 vmethod_19()
		{
			return new Class6.Class20((long)this.struct1_0.int_0, (Class6.Enum1)7);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000027DA File Offset: 0x000009DA
		public override Class6.Class20 vmethod_20()
		{
			return new Class6.Class20((ulong)this.struct1_0.uint_0, (Class6.Enum1)8);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000027EE File Offset: 0x000009EE
		public override Class6.Class19 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000027F6 File Offset: 0x000009F6
		public override Class6.Class19 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000027FE File Offset: 0x000009FE
		public override Class6.Class19 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002806 File Offset: 0x00000A06
		public override Class6.Class20 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000280E File Offset: 0x00000A0E
		public override Class6.Class19 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002816 File Offset: 0x00000A16
		public override Class6.Class19 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000281E File Offset: 0x00000A1E
		public override Class6.Class19 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002826 File Offset: 0x00000A26
		public override Class6.Class20 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000282E File Offset: 0x00000A2E
		public override Class6.Class19 vmethod_29()
		{
			return new Class6.Class19((int)(checked((sbyte)this.struct1_0.int_0)), (Class6.Enum1)1);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002842 File Offset: 0x00000A42
		public override Class6.Class19 vmethod_30()
		{
			return new Class6.Class19((int)(checked((sbyte)this.struct1_0.uint_0)), (Class6.Enum1)1);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002856 File Offset: 0x00000A56
		public override Class6.Class19 vmethod_31()
		{
			return new Class6.Class19((int)(checked((short)this.struct1_0.int_0)), (Class6.Enum1)3);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000286A File Offset: 0x00000A6A
		public override Class6.Class19 vmethod_32()
		{
			return new Class6.Class19((int)(checked((short)this.struct1_0.uint_0)), (Class6.Enum1)3);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000027A0 File Offset: 0x000009A0
		public override Class6.Class19 vmethod_33()
		{
			return new Class6.Class19(this.struct1_0.int_0, (Class6.Enum1)5);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000287E File Offset: 0x00000A7E
		public override Class6.Class19 vmethod_34()
		{
			return new Class6.Class19(checked((int)this.struct1_0.uint_0), (Class6.Enum1)5);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000027C6 File Offset: 0x000009C6
		public override Class6.Class20 vmethod_35()
		{
			return new Class6.Class20((long)this.struct1_0.int_0, (Class6.Enum1)7);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002892 File Offset: 0x00000A92
		public override Class6.Class20 vmethod_36()
		{
			return new Class6.Class20((long)((ulong)this.struct1_0.uint_0), (Class6.Enum1)7);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000028A6 File Offset: 0x00000AA6
		public override Class6.Class19 vmethod_37()
		{
			return new Class6.Class19((int)(checked((byte)this.struct1_0.int_0)), (Class6.Enum1)2);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000028BA File Offset: 0x00000ABA
		public override Class6.Class19 vmethod_38()
		{
			return new Class6.Class19((int)(checked((byte)this.struct1_0.uint_0)), (Class6.Enum1)2);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000028CE File Offset: 0x00000ACE
		public override Class6.Class19 vmethod_39()
		{
			return new Class6.Class19((int)(checked((ushort)this.struct1_0.int_0)), (Class6.Enum1)4);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000028E2 File Offset: 0x00000AE2
		public override Class6.Class19 vmethod_40()
		{
			return new Class6.Class19((int)(checked((ushort)this.struct1_0.uint_0)), (Class6.Enum1)4);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000028F6 File Offset: 0x00000AF6
		public override Class6.Class19 vmethod_41()
		{
			return new Class6.Class19(checked((uint)this.struct1_0.int_0), (Class6.Enum1)6);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000027B3 File Offset: 0x000009B3
		public override Class6.Class19 vmethod_42()
		{
			return new Class6.Class19(this.struct1_0.uint_0, (Class6.Enum1)6);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000290A File Offset: 0x00000B0A
		public override Class6.Class20 vmethod_43()
		{
			return new Class6.Class20(checked((ulong)this.struct1_0.int_0), (Class6.Enum1)8);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000027DA File Offset: 0x000009DA
		public override Class6.Class20 vmethod_44()
		{
			return new Class6.Class20((ulong)this.struct1_0.uint_0, (Class6.Enum1)8);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000291E File Offset: 0x00000B1E
		public override Class6.Class22 vmethod_45()
		{
			return new Class6.Class22((float)this.struct1_0.int_0);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002931 File Offset: 0x00000B31
		public override Class6.Class22 vmethod_46()
		{
			return new Class6.Class22((double)this.struct1_0.int_0);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002944 File Offset: 0x00000B44
		public override Class6.Class22 zLqpmHyYrP()
		{
			return new Class6.Class22(this.struct1_0.uint_0);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00017B70 File Offset: 0x00015D70
		public override Class6.Class21 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_24().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_23().struct1_0.int_0);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00017BB4 File Offset: 0x00015DB4
		public override Class6.Class21 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_28().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_27().struct1_0.uint_0);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00017BF8 File Offset: 0x00015DF8
		public override Class6.Class21 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_35().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_33().struct1_0.int_0);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00017C3C File Offset: 0x00015E3C
		public override Class6.Class21 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_43().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_41().struct1_0.uint_0);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00017C80 File Offset: 0x00015E80
		public override Class6.Class21 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_36().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00017CC4 File Offset: 0x00015EC4
		public override Class6.Class21 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00017D08 File Offset: 0x00015F08
		public override Class6.Class17 vmethod_53()
		{
			Class6.Enum1 @enum = this.enum1_0;
			switch (@enum)
			{
			case (Class6.Enum1)1:
			case (Class6.Enum1)3:
			case (Class6.Enum1)5:
				goto IL_48;
			case (Class6.Enum1)2:
			case (Class6.Enum1)4:
				break;
			default:
				if (@enum == (Class6.Enum1)11)
				{
					goto IL_48;
				}
				if (@enum == (Class6.Enum1)15)
				{
					goto IL_48;
				}
				break;
			}
			return new Class6.Class19((int)(-(int)((ulong)this.struct1_0.uint_0)));
			IL_48:
			return new Class6.Class19(-this.struct1_0.int_0);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00017D70 File Offset: 0x00015F70
		public override Class6.Class17 Add(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 + ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (class17_0.method_2())
			{
				return ((Class6.Class21)class17_0).Add(this);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00017DD4 File Offset: 0x00015FD4
		public override Class6.Class17 vmethod_54(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct1_0.int_0 + ((Class6.Class19)class17_0).struct1_0.int_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_54(this);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00017E38 File Offset: 0x00016038
		public override Class6.Class17 vmethod_55(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct1_0.uint_0 + ((Class6.Class19)class17_0).struct1_0.uint_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_55(this);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00017E9C File Offset: 0x0001609C
		public override Class6.Class17 vmethod_56(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 - ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_8(this);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00017F00 File Offset: 0x00016100
		public override Class6.Class17 vmethod_57(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct1_0.int_0 - ((Class6.Class19)class17_0).struct1_0.int_0));
			}
			if (class17_0.method_2())
			{
				return ((Class6.Class21)class17_0).method_9(this);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00017F64 File Offset: 0x00016164
		public override Class6.Class17 vmethod_58(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct1_0.uint_0 - ((Class6.Class19)class17_0).struct1_0.uint_0));
			}
			if (class17_0.method_2())
			{
				return ((Class6.Class21)class17_0).method_10(this);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00017FC8 File Offset: 0x000161C8
		public override Class6.Class17 vmethod_59(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 * ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_59(this);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0001802C File Offset: 0x0001622C
		public override Class6.Class17 vmethod_60(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct1_0.int_0 * ((Class6.Class19)class17_0).struct1_0.int_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_60(this);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00018090 File Offset: 0x00016290
		public override Class6.Class17 vmethod_61(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct1_0.uint_0 * ((Class6.Class19)class17_0).struct1_0.uint_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_61(this);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000180F4 File Offset: 0x000162F4
		public override Class6.Class17 vmethod_62(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 / ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_11(this);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00018158 File Offset: 0x00016358
		public override Class6.Class17 vmethod_63(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.uint_0 / ((Class6.Class19)class17_0).struct1_0.uint_0);
			}
			if (class17_0.method_2())
			{
				return ((Class6.Class21)class17_0).method_12(this);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000181BC File Offset: 0x000163BC
		public override Class6.Class17 vmethod_64(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 % ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (class17_0.method_2())
			{
				return ((Class6.Class21)class17_0).method_13(this);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00018220 File Offset: 0x00016420
		public override Class6.Class17 vmethod_65(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.uint_0 % ((Class6.Class19)class17_0).struct1_0.uint_0);
			}
			if (class17_0.method_2())
			{
				return ((Class6.Class21)class17_0).method_14(this);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00018284 File Offset: 0x00016484
		public override Class6.Class17 vmethod_66(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 & ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (class17_0.method_2())
			{
				return ((Class6.Class21)class17_0).vmethod_66(this);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000182E8 File Offset: 0x000164E8
		public override Class6.Class17 vmethod_67(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 | ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_67(this);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002958 File Offset: 0x00000B58
		public override Class6.Class17 vmethod_68()
		{
			return new Class6.Class19(~this.struct1_0.int_0);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0001834C File Offset: 0x0001654C
		public override Class6.Class17 igEvpBpxrl(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 ^ ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).igEvpBpxrl(this);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000183B0 File Offset: 0x000165B0
		public override Class6.Class17 vmethod_70(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 << ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_17(this);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00018414 File Offset: 0x00016614
		public override Class6.Class17 vmethod_71(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.int_0 >> ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_16(this);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00018478 File Offset: 0x00016678
		public override Class6.Class17 vmethod_72(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct1_0.uint_0 >> ((Class6.Class19)class17_0).struct1_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_15(this);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000184DC File Offset: 0x000166DC
		public override string ToString()
		{
			Class6.Enum1 @enum = this.enum1_0;
			switch (@enum)
			{
			case (Class6.Enum1)1:
			case (Class6.Enum1)3:
			case (Class6.Enum1)5:
				goto IL_3F;
			case (Class6.Enum1)2:
			case (Class6.Enum1)4:
				break;
			default:
				if (@enum == (Class6.Enum1)11)
				{
					goto IL_3F;
				}
				break;
			}
			return this.struct1_0.uint_0.ToString();
			IL_3F:
			return this.struct1_0.int_0.ToString();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000296B File Offset: 0x00000B6B
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000296E File Offset: 0x00000B6E
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00018538 File Offset: 0x00016738
		internal override bool vmethod_4(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return ((Class6.Class29)class17_0).vmethod_4(this);
			}
			if (class17_0.iFavIhWly7())
			{
				return ((Class6.Class23)class17_0).vmethod_4(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (@class.method_1())
			{
				return this.struct1_0.int_0 == ((Class6.Class19)@class).struct1_0.int_0;
			}
			return ((Class6.Class21)@class).vmethod_4(this);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000185C4 File Offset: 0x000167C4
		private static Class6.Class18 smethod_4(Class6.Class17 class17_0)
		{
			Class6.Class18 @class = class17_0 as Class6.Class18;
			if (@class == null && class17_0.iFavIhWly7())
			{
				@class = (class17_0.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000185F4 File Offset: 0x000167F4
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.iFavIhWly7())
			{
				return ((Class6.Class23)class17_0).vmethod_5(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (!@class.method_1())
			{
				return ((Class6.Class21)@class).vmethod_5(this);
			}
			return this.struct1_0.uint_0 != ((Class6.Class19)@class).struct1_0.uint_0;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00018678 File Offset: 0x00016878
		public override bool vmethod_73(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct1_0.int_0 >= ((Class6.Class19)class17_0).struct1_0.int_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_77(this);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000186D8 File Offset: 0x000168D8
		public override bool vmethod_74(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct1_0.uint_0 >= ((Class6.Class19)class17_0).struct1_0.uint_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_78(this);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00018738 File Offset: 0x00016938
		public override bool vmethod_75(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct1_0.int_0 > ((Class6.Class19)class17_0).struct1_0.int_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_79(this);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00018798 File Offset: 0x00016998
		public override bool vmethod_76(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct1_0.uint_0 > ((Class6.Class19)class17_0).struct1_0.uint_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_80(this);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000187F8 File Offset: 0x000169F8
		public override bool vmethod_77(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct1_0.int_0 <= ((Class6.Class19)class17_0).struct1_0.int_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_73(this);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00018858 File Offset: 0x00016A58
		public override bool vmethod_78(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct1_0.uint_0 <= ((Class6.Class19)class17_0).struct1_0.uint_0;
			}
			if (class17_0.method_2())
			{
				return ((Class6.Class21)class17_0).vmethod_74(this);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000188B8 File Offset: 0x00016AB8
		public override bool vmethod_79(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct1_0.int_0 < ((Class6.Class19)class17_0).struct1_0.int_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_75(this);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00018918 File Offset: 0x00016B18
		public override bool vmethod_80(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct1_0.uint_0 < ((Class6.Class19)class17_0).struct1_0.uint_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_76(this);
		}

		// Token: 0x040002DF RID: 735
		public Class6.Struct1 struct1_0;

		// Token: 0x040002E0 RID: 736
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x02000056 RID: 86
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct2
	{
		// Token: 0x040002E1 RID: 737
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x040002E2 RID: 738
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x040002E3 RID: 739
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x040002E4 RID: 740
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x040002E5 RID: 741
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x040002E6 RID: 742
		[FieldOffset(0)]
		public int int_0;

		// Token: 0x040002E7 RID: 743
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x040002E8 RID: 744
		[FieldOffset(0)]
		public long long_0;
	}

	// Token: 0x02000057 RID: 87
	private class Class20 : Class6.Class18
	{
		// Token: 0x06000283 RID: 643 RVA: 0x00018978 File Offset: 0x00016B78
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			this.struct2_0 = ((Class6.Class20)class17_0).struct2_0;
			this.enum1_0 = ((Class6.Class20)class17_0).enum1_0;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00017418 File Offset: 0x00015618
		internal override void vmethod_1(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000189A8 File Offset: 0x00016BA8
		public Class20(long long_0)
		{
			this.enum4_0 = (Class6.Enum4)2;
			this.struct2_0.long_0 = long_0;
			this.enum1_0 = (Class6.Enum1)7;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000189D8 File Offset: 0x00016BD8
		public Class20(Class6.Class20 class20_0)
		{
			this.enum4_0 = class20_0.enum4_0;
			this.struct2_0.long_0 = class20_0.struct2_0.long_0;
			this.enum1_0 = class20_0.enum1_0;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002971 File Offset: 0x00000B71
		public override Class6.Class18 vmethod_69()
		{
			return new Class6.Class20(this);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00018A1C File Offset: 0x00016C1C
		public Class20(long long_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)2;
			this.struct2_0.long_0 = long_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00018A4C File Offset: 0x00016C4C
		public Class20(ulong ulong_0)
		{
			this.enum4_0 = (Class6.Enum4)2;
			this.struct2_0.ulong_0 = ulong_0;
			this.enum1_0 = (Class6.Enum1)8;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00018A7C File Offset: 0x00016C7C
		public Class20(ulong ulong_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)2;
			this.struct2_0.ulong_0 = ulong_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00018AAC File Offset: 0x00016CAC
		public override bool vmethod_10()
		{
			if (this.enum1_0 == (Class6.Enum1)7)
			{
				return this.struct2_0.long_0 == 0L;
			}
			return this.struct2_0.ulong_0 == 0UL;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000272D File Offset: 0x0000092D
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00018AF0 File Offset: 0x00016CF0
		public override Class6.Class17 vmethod_11(Class6.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class6.Enum1)1:
				return this.vmethod_13();
			case (Class6.Enum1)2:
				return this.vmethod_14();
			case (Class6.Enum1)3:
				return this.vmethod_15();
			case (Class6.Enum1)4:
				return this.vmethod_16();
			case (Class6.Enum1)5:
				return this.vmethod_17();
			case (Class6.Enum1)6:
				return this.vmethod_18();
			case (Class6.Enum1)7:
				return this.vmethod_19();
			case (Class6.Enum1)8:
				return this.vmethod_20();
			case (Class6.Enum1)11:
				return this.vmethod_12();
			case (Class6.Enum1)15:
				return this.method_7();
			case (Class6.Enum1)16:
				return this.vmethod_69();
			}
			throw new Exception(((Class6.Enum5)4).ToString());
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00018BAC File Offset: 0x00016DAC
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum1_0)
				{
				case (Class6.Enum1)1:
					return this.struct2_0.sbyte_0;
				case (Class6.Enum1)2:
					return this.struct2_0.byte_0;
				case (Class6.Enum1)3:
					return this.struct2_0.short_0;
				case (Class6.Enum1)4:
					return this.struct2_0.ushort_0;
				case (Class6.Enum1)5:
					return this.struct2_0.int_0;
				case (Class6.Enum1)6:
					return this.struct2_0.uint_0;
				case (Class6.Enum1)7:
					return this.struct2_0.long_0;
				case (Class6.Enum1)8:
					return this.struct2_0.ulong_0;
				case (Class6.Enum1)11:
					return this.yQwppAuByG();
				case (Class6.Enum1)15:
					return (char)this.struct2_0.int_0;
				}
				return this.struct2_0.long_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct2_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct2_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct2_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct2_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct2_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct2_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return this.struct2_0.long_0;
			}
			if (type_0 == typeof(ulong))
			{
				return this.struct2_0.ulong_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct2_0.long_0;
			}
			if (type_0.IsEnum)
			{
				return this.method_6(type_0);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00018E7C File Offset: 0x0001707C
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct2_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct2_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct2_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct2_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct2_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct2_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, this.struct2_0.long_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, this.struct2_0.ulong_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct2_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct2_0.long_0);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00017B50 File Offset: 0x00015D50
		public override Class6.Class19 vmethod_12()
		{
			return new Class6.Class19(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002738 File Offset: 0x00000938
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002979 File Offset: 0x00000B79
		public Class6.Class19 method_7()
		{
			return new Class6.Class19((int)this.struct2_0.sbyte_0, (Class6.Enum1)15);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000298D File Offset: 0x00000B8D
		public override Class6.Class19 vmethod_13()
		{
			return new Class6.Class19((int)this.struct2_0.sbyte_0, (Class6.Enum1)1);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000029A0 File Offset: 0x00000BA0
		public override Class6.Class19 vmethod_14()
		{
			return new Class6.Class19((uint)this.struct2_0.byte_0, (Class6.Enum1)2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000029B3 File Offset: 0x00000BB3
		public override Class6.Class19 vmethod_15()
		{
			return new Class6.Class19((int)this.struct2_0.short_0, (Class6.Enum1)3);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000029C6 File Offset: 0x00000BC6
		public override Class6.Class19 vmethod_16()
		{
			return new Class6.Class19((uint)this.struct2_0.ushort_0, (Class6.Enum1)4);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000029D9 File Offset: 0x00000BD9
		public override Class6.Class19 vmethod_17()
		{
			return new Class6.Class19(this.struct2_0.int_0, (Class6.Enum1)5);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000029EC File Offset: 0x00000BEC
		public override Class6.Class19 vmethod_18()
		{
			return new Class6.Class19(this.struct2_0.uint_0, (Class6.Enum1)6);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000029FF File Offset: 0x00000BFF
		public override Class6.Class20 vmethod_19()
		{
			return new Class6.Class20(this.struct2_0.long_0, (Class6.Enum1)7);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002A12 File Offset: 0x00000C12
		public override Class6.Class20 vmethod_20()
		{
			return new Class6.Class20(this.struct2_0.ulong_0, (Class6.Enum1)8);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000027EE File Offset: 0x000009EE
		public override Class6.Class19 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000027F6 File Offset: 0x000009F6
		public override Class6.Class19 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000027FE File Offset: 0x000009FE
		public override Class6.Class19 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002806 File Offset: 0x00000A06
		public override Class6.Class20 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000280E File Offset: 0x00000A0E
		public override Class6.Class19 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002816 File Offset: 0x00000A16
		public override Class6.Class19 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000281E File Offset: 0x00000A1E
		public override Class6.Class19 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002826 File Offset: 0x00000A26
		public override Class6.Class20 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002A25 File Offset: 0x00000C25
		public override Class6.Class19 vmethod_29()
		{
			return new Class6.Class19((int)(checked((sbyte)this.struct2_0.long_0)), (Class6.Enum1)1);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002A39 File Offset: 0x00000C39
		public override Class6.Class19 vmethod_30()
		{
			return new Class6.Class19((int)(checked((sbyte)this.struct2_0.ulong_0)), (Class6.Enum1)1);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002A4D File Offset: 0x00000C4D
		public override Class6.Class19 vmethod_31()
		{
			return new Class6.Class19((int)(checked((short)this.struct2_0.long_0)), (Class6.Enum1)3);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002A61 File Offset: 0x00000C61
		public override Class6.Class19 vmethod_32()
		{
			return new Class6.Class19((int)(checked((short)this.struct2_0.ulong_0)), (Class6.Enum1)3);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002A75 File Offset: 0x00000C75
		public override Class6.Class19 vmethod_33()
		{
			return new Class6.Class19(checked((int)this.struct2_0.long_0), (Class6.Enum1)5);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002A89 File Offset: 0x00000C89
		public override Class6.Class19 vmethod_34()
		{
			return new Class6.Class19(checked((int)this.struct2_0.ulong_0), (Class6.Enum1)5);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000029FF File Offset: 0x00000BFF
		public override Class6.Class20 vmethod_35()
		{
			return new Class6.Class20(this.struct2_0.long_0, (Class6.Enum1)7);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002A9D File Offset: 0x00000C9D
		public override Class6.Class20 vmethod_36()
		{
			return new Class6.Class20(checked((long)this.struct2_0.ulong_0), (Class6.Enum1)7);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002AB1 File Offset: 0x00000CB1
		public override Class6.Class19 vmethod_37()
		{
			return new Class6.Class19((int)(checked((byte)this.struct2_0.long_0)), (Class6.Enum1)2);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public override Class6.Class19 vmethod_38()
		{
			return new Class6.Class19((int)(checked((byte)this.struct2_0.ulong_0)), (Class6.Enum1)2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002AD9 File Offset: 0x00000CD9
		public override Class6.Class19 vmethod_39()
		{
			return new Class6.Class19((int)(checked((ushort)this.struct2_0.long_0)), (Class6.Enum1)4);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002AED File Offset: 0x00000CED
		public override Class6.Class19 vmethod_40()
		{
			return new Class6.Class19((int)(checked((ushort)this.struct2_0.ulong_0)), (Class6.Enum1)4);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002B01 File Offset: 0x00000D01
		public override Class6.Class19 vmethod_41()
		{
			return new Class6.Class19(checked((uint)this.struct2_0.long_0), (Class6.Enum1)6);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002B15 File Offset: 0x00000D15
		public override Class6.Class19 vmethod_42()
		{
			return new Class6.Class19(checked((uint)this.struct2_0.ulong_0), (Class6.Enum1)6);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002B29 File Offset: 0x00000D29
		public override Class6.Class20 vmethod_43()
		{
			return new Class6.Class20(checked((ulong)this.struct2_0.long_0), (Class6.Enum1)8);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002A12 File Offset: 0x00000C12
		public override Class6.Class20 vmethod_44()
		{
			return new Class6.Class20(this.struct2_0.ulong_0, (Class6.Enum1)8);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002B3D File Offset: 0x00000D3D
		public override Class6.Class22 vmethod_45()
		{
			return new Class6.Class22((float)this.struct2_0.long_0);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002B50 File Offset: 0x00000D50
		public override Class6.Class22 vmethod_46()
		{
			return new Class6.Class22((double)this.struct2_0.long_0);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002B63 File Offset: 0x00000D63
		public override Class6.Class22 zLqpmHyYrP()
		{
			return new Class6.Class22(this.struct2_0.ulong_0);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00017B70 File Offset: 0x00015D70
		public override Class6.Class21 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_24().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_23().struct1_0.int_0);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00017BB4 File Offset: 0x00015DB4
		public override Class6.Class21 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_28().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_27().struct1_0.uint_0);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00017BF8 File Offset: 0x00015DF8
		public override Class6.Class21 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_35().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_33().struct1_0.int_0);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00017C3C File Offset: 0x00015E3C
		public override Class6.Class21 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_43().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_41().struct1_0.uint_0);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00017C80 File Offset: 0x00015E80
		public override Class6.Class21 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_36().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00018FF8 File Offset: 0x000171F8
		public override Class6.Class21 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)(checked((uint)this.struct2_0.ulong_0)));
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002B77 File Offset: 0x00000D77
		public override Class6.Class17 vmethod_53()
		{
			return new Class6.Class20(-this.struct2_0.long_0);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00019030 File Offset: 0x00017230
		public override Class6.Class17 Add(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.long_0 + ((Class6.Class20)class17_0).struct2_0.long_0);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0001907C File Offset: 0x0001727C
		public override Class6.Class17 vmethod_54(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct2_0.long_0 + ((Class6.Class20)class17_0).struct2_0.long_0));
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000190C8 File Offset: 0x000172C8
		public override Class6.Class17 vmethod_55(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct2_0.ulong_0 + ((Class6.Class20)class17_0).struct2_0.ulong_0));
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00019114 File Offset: 0x00017314
		public override Class6.Class17 vmethod_56(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.long_0 - ((Class6.Class20)class17_0).struct2_0.long_0);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00019160 File Offset: 0x00017360
		public override Class6.Class17 vmethod_57(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct2_0.long_0 - ((Class6.Class20)class17_0).struct2_0.long_0));
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000191AC File Offset: 0x000173AC
		public override Class6.Class17 vmethod_58(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct2_0.ulong_0 - ((Class6.Class20)class17_0).struct2_0.ulong_0));
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000191F8 File Offset: 0x000173F8
		public override Class6.Class17 vmethod_59(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.long_0 * ((Class6.Class20)class17_0).struct2_0.long_0);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00019244 File Offset: 0x00017444
		public override Class6.Class17 vmethod_60(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct2_0.long_0 * ((Class6.Class20)class17_0).struct2_0.long_0));
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00019290 File Offset: 0x00017490
		public override Class6.Class17 vmethod_61(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct2_0.ulong_0 * ((Class6.Class20)class17_0).struct2_0.ulong_0));
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000192DC File Offset: 0x000174DC
		public override Class6.Class17 vmethod_62(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.long_0 / ((Class6.Class20)class17_0).struct2_0.long_0);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00019328 File Offset: 0x00017528
		public override Class6.Class17 vmethod_63(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.ulong_0 / ((Class6.Class20)class17_0).struct2_0.ulong_0);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00019374 File Offset: 0x00017574
		public override Class6.Class17 vmethod_64(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.long_0 % ((Class6.Class20)class17_0).struct2_0.long_0);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000193C0 File Offset: 0x000175C0
		public override Class6.Class17 vmethod_65(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.ulong_0 % ((Class6.Class20)class17_0).struct2_0.ulong_0);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0001940C File Offset: 0x0001760C
		public override Class6.Class17 vmethod_66(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.long_0 & ((Class6.Class20)class17_0).struct2_0.long_0);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00019458 File Offset: 0x00017658
		public override Class6.Class17 vmethod_67(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.long_0 | ((Class6.Class20)class17_0).struct2_0.long_0);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002B8A File Offset: 0x00000D8A
		public override Class6.Class17 vmethod_68()
		{
			return new Class6.Class20(~this.struct2_0.long_0);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000194A4 File Offset: 0x000176A4
		public override Class6.Class17 igEvpBpxrl(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.long_0 ^ ((Class6.Class20)class17_0).struct2_0.long_0);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000194F0 File Offset: 0x000176F0
		public override Class6.Class17 vmethod_70(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_3())
			{
				return new Class6.Class20(this.struct2_0.long_0 << ((Class6.Class20)class17_0).struct2_0.int_0);
			}
			if (class17_0.vmethod_2())
			{
				return new Class6.Class20(this.struct2_0.long_0 << ((Class6.Class18)class17_0).vmethod_17().struct1_0.int_0);
			}
			throw new Class6.Exception1();
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00019574 File Offset: 0x00017774
		public override Class6.Class17 vmethod_71(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_3())
			{
				return new Class6.Class20(this.struct2_0.long_0 >> ((Class6.Class20)class17_0).struct2_0.int_0);
			}
			if (!class17_0.vmethod_2())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.long_0 >> ((Class6.Class18)class17_0).vmethod_17().struct1_0.int_0);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000195F8 File Offset: 0x000177F8
		public override Class6.Class17 vmethod_72(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_3())
			{
				return new Class6.Class20(this.struct2_0.ulong_0 >> ((Class6.Class20)class17_0).struct2_0.int_0);
			}
			if (!class17_0.vmethod_2())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct2_0.ulong_0 >> ((Class6.Class18)class17_0).vmethod_17().struct1_0.int_0);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0001967C File Offset: 0x0001787C
		public override string ToString()
		{
			if (this.enum1_0 == (Class6.Enum1)7)
			{
				return this.struct2_0.long_0.ToString();
			}
			return this.struct2_0.ulong_0.ToString();
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000296B File Offset: 0x00000B6B
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000296E File Offset: 0x00000B6E
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000196B4 File Offset: 0x000178B4
		internal override bool vmethod_4(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return ((Class6.Class29)class17_0).vmethod_4(this);
			}
			if (class17_0.iFavIhWly7())
			{
				return ((Class6.Class23)class17_0).vmethod_4(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			return @class.method_3() && this.struct2_0.long_0 == ((Class6.Class20)@class).struct2_0.long_0;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0001971C File Offset: 0x0001791C
		private static Class6.Class18 smethod_4(Class6.Class17 class17_0)
		{
			Class6.Class18 @class = class17_0 as Class6.Class18;
			if (@class == null && class17_0.iFavIhWly7())
			{
				@class = (class17_0.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0001974C File Offset: 0x0001794C
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (!class17_0.iFavIhWly7())
			{
				Class6.Class17 @class = class17_0.vmethod_7();
				return @class.method_3() && this.struct2_0.ulong_0 != ((Class6.Class20)@class).struct2_0.ulong_0;
			}
			return ((Class6.Class23)class17_0).vmethod_5(this);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000197AC File Offset: 0x000179AC
		public override bool vmethod_73(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct2_0.long_0 >= ((Class6.Class20)class17_0).struct2_0.long_0;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000197F8 File Offset: 0x000179F8
		public override bool vmethod_74(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct2_0.ulong_0 >= ((Class6.Class20)class17_0).struct2_0.ulong_0;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00019844 File Offset: 0x00017A44
		public override bool vmethod_75(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct2_0.long_0 > ((Class6.Class20)class17_0).struct2_0.long_0;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001988C File Offset: 0x00017A8C
		public override bool vmethod_76(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct2_0.ulong_0 > ((Class6.Class20)class17_0).struct2_0.ulong_0;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000198D4 File Offset: 0x00017AD4
		public override bool vmethod_77(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct2_0.long_0 <= ((Class6.Class20)class17_0).struct2_0.long_0;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00019920 File Offset: 0x00017B20
		public override bool vmethod_78(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct2_0.ulong_0 <= ((Class6.Class20)class17_0).struct2_0.ulong_0;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0001996C File Offset: 0x00017B6C
		public override bool vmethod_79(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct2_0.long_0 < ((Class6.Class20)class17_0).struct2_0.long_0;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000199B4 File Offset: 0x00017BB4
		public override bool vmethod_80(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct2_0.ulong_0 < ((Class6.Class20)class17_0).struct2_0.ulong_0;
		}

		// Token: 0x040002E9 RID: 745
		public Class6.Struct2 struct2_0;

		// Token: 0x040002EA RID: 746
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x02000058 RID: 88
	private class Class21 : Class6.Class18
	{
		// Token: 0x060002DF RID: 735 RVA: 0x000199FC File Offset: 0x00017BFC
		internal void method_6(Class6.Class17 class17_0)
		{
			if (!class17_0.method_2())
			{
				this.vmethod_9(class17_0);
				return;
			}
			this.object_0 = ((Class6.Class21)class17_0).object_0;
			this.enum1_0 = ((Class6.Class21)class17_0).enum1_0;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00019A3C File Offset: 0x00017C3C
		internal unsafe override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					IntPtr value = new IntPtr(((Class6.Class20)this.object_0).struct2_0.long_0);
					IntPtr intPtr = new IntPtr(((Class6.Class20)((Class6.Class21)class17_0).object_0).struct2_0.long_0);
					*(long*)((void*)value) = intPtr.ToInt64();
					return;
				}
				IntPtr value2 = new IntPtr(((Class6.Class19)this.object_0).struct1_0.int_0);
				IntPtr intPtr2 = new IntPtr(((Class6.Class19)((Class6.Class21)class17_0).object_0).struct1_0.int_0);
				*(int*)((void*)value2) = intPtr2.ToInt32();
				return;
			}
			else
			{
				object obj = class17_0.vmethod_3(null);
				if (obj == null)
				{
					return;
				}
				IntPtr value3;
				if (IntPtr.Size == 8)
				{
					value3 = new IntPtr(((Class6.Class20)this.object_0).struct2_0.long_0);
				}
				else
				{
					value3 = new IntPtr(((Class6.Class19)this.object_0).struct1_0.int_0);
				}
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					return;
				}
				if (type == typeof(byte))
				{
					*(byte*)((void*)value3) = (byte)obj;
					return;
				}
				if (type == typeof(sbyte))
				{
					*(byte*)((void*)value3) = (byte)((sbyte)obj);
					return;
				}
				if (type == typeof(short))
				{
					*(short*)((void*)value3) = (short)obj;
					return;
				}
				if (type == typeof(ushort))
				{
					*(short*)((void*)value3) = (short)((ushort)obj);
					return;
				}
				if (type == typeof(int))
				{
					*(int*)((void*)value3) = (int)obj;
					return;
				}
				if (type == typeof(uint))
				{
					*(int*)((void*)value3) = (int)((uint)obj);
					return;
				}
				if (type == typeof(long))
				{
					*(long*)((void*)value3) = (long)obj;
					return;
				}
				if (type == typeof(ulong))
				{
					*(long*)((void*)value3) = (long)((ulong)obj);
					return;
				}
				if (type == typeof(float))
				{
					*(float*)((void*)value3) = (float)obj;
					return;
				}
				if (type == typeof(double))
				{
					*(double*)((void*)value3) = (double)obj;
					return;
				}
				if (type == typeof(bool))
				{
					*(byte*)((void*)value3) = (((bool)obj) ? 1 : 0);
					return;
				}
				if (type == typeof(IntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)obj;
					return;
				}
				if (type == typeof(UIntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)((UIntPtr)obj);
					return;
				}
				if (!(type == typeof(char)))
				{
					throw new Class6.Exception1();
				}
				*(short*)((void*)value3) = (short)((char)obj);
				return;
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00017418 File Offset: 0x00015618
		internal override void vmethod_1(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00019D5C File Offset: 0x00017F5C
		public Class21(IntPtr intptr_0)
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class6.Class20(intptr_0.ToInt64());
				this.enum1_0 = (Class6.Enum1)12;
				return;
			}
			this.object_0 = new Class6.Class19(intptr_0.ToInt32());
			this.enum1_0 = (Class6.Enum1)12;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00019DB8 File Offset: 0x00017FB8
		public Class21(UIntPtr uintptr_0)
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class6.Class20(uintptr_0.ToUInt64());
				this.enum1_0 = (Class6.Enum1)12;
				return;
			}
			this.object_0 = new Class6.Class19(uintptr_0.ToUInt32());
			this.enum1_0 = (Class6.Enum1)12;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00019E14 File Offset: 0x00018014
		public Class21()
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class6.Class20(0L);
				this.enum1_0 = (Class6.Enum1)12;
				return;
			}
			this.object_0 = new Class6.Class19(0);
			this.enum1_0 = (Class6.Enum1)12;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002B9D File Offset: 0x00000D9D
		public override Class6.Class18 vmethod_69()
		{
			return new Class6.Class21
			{
				object_0 = this.object_0.vmethod_69(),
				enum1_0 = this.enum1_0
			};
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00019E6C File Offset: 0x0001806C
		public Class21(long long_0)
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class6.Class20(long_0);
				this.enum1_0 = (Class6.Enum1)12;
				return;
			}
			this.object_0 = new Class6.Class19((int)long_0);
			this.enum1_0 = (Class6.Enum1)12;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00019EBC File Offset: 0x000180BC
		public Class21(long long_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class6.Class20(long_0);
				this.enum1_0 = enum1_1;
				return;
			}
			this.object_0 = new Class6.Class19((int)long_0);
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00019F08 File Offset: 0x00018108
		public Class21(ulong ulong_0)
		{
			this.enum4_0 = (Class6.Enum4)4;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class6.Class20(ulong_0);
				this.enum1_0 = (Class6.Enum1)13;
				return;
			}
			this.object_0 = new Class6.Class19((uint)ulong_0);
			this.enum1_0 = (Class6.Enum1)13;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00019F58 File Offset: 0x00018158
		public Class21(ulong ulong_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)4;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class6.Class20(ulong_0);
				this.enum1_0 = enum1_1;
				return;
			}
			this.object_0 = new Class6.Class19((uint)ulong_0);
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002BC1 File Offset: 0x00000DC1
		public override bool vmethod_10()
		{
			return this.object_0.vmethod_10();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000272D File Offset: 0x0000092D
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002738 File Offset: 0x00000938
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000296E File Offset: 0x00000B6E
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00019FA4 File Offset: 0x000181A4
		public override Class6.Class17 vmethod_11(Class6.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class6.Enum1)1:
				return this.vmethod_13();
			case (Class6.Enum1)2:
				return this.vmethod_14();
			case (Class6.Enum1)3:
				return this.vmethod_15();
			case (Class6.Enum1)4:
				return this.vmethod_16();
			case (Class6.Enum1)5:
				return this.vmethod_17();
			case (Class6.Enum1)6:
				return this.vmethod_18();
			case (Class6.Enum1)7:
				return this.vmethod_19();
			case (Class6.Enum1)8:
				return this.vmethod_20();
			case (Class6.Enum1)11:
				return this.vmethod_12();
			case (Class6.Enum1)12:
				return this;
			case (Class6.Enum1)13:
				return this;
			case (Class6.Enum1)16:
				return this.vmethod_69();
			}
			throw new Exception(((Class6.Enum5)4).ToString());
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001A05C File Offset: 0x0001825C
		internal IntPtr method_7()
		{
			if (IntPtr.Size == 8)
			{
				return new IntPtr(((Class6.Class20)this.object_0).struct2_0.long_0);
			}
			return new IntPtr(((Class6.Class19)this.object_0).struct1_0.int_0);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001A0A8 File Offset: 0x000182A8
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(IntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((Class6.Class20)this.object_0).struct2_0.long_0);
				}
				return new IntPtr(((Class6.Class19)this.object_0).struct1_0.int_0);
			}
			else if (type_0 == typeof(UIntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new UIntPtr(((Class6.Class20)this.object_0).struct2_0.ulong_0);
				}
				return new UIntPtr(((Class6.Class19)this.object_0).struct1_0.uint_0);
			}
			else
			{
				if (!(type_0 == null) && !(type_0 == typeof(object)))
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					if (this.enum1_0 == (Class6.Enum1)12)
					{
						return new IntPtr(((Class6.Class20)this.object_0).struct2_0.long_0);
					}
					return new UIntPtr(((Class6.Class20)this.object_0).struct2_0.ulong_0);
				}
				else
				{
					if (this.enum1_0 == (Class6.Enum1)12)
					{
						return new IntPtr(((Class6.Class20)this.object_0).struct2_0.int_0);
					}
					return new UIntPtr(((Class6.Class19)this.object_0).struct1_0.uint_0);
				}
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002BCE File Offset: 0x00000DCE
		public override Class6.Class19 vmethod_12()
		{
			return this.object_0.vmethod_12();
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002BDB File Offset: 0x00000DDB
		public override Class6.Class19 vmethod_13()
		{
			return this.object_0.vmethod_13();
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002BE8 File Offset: 0x00000DE8
		public override Class6.Class19 vmethod_14()
		{
			return this.object_0.vmethod_14();
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public override Class6.Class19 vmethod_15()
		{
			return this.object_0.vmethod_15();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002C02 File Offset: 0x00000E02
		public override Class6.Class19 vmethod_16()
		{
			return this.object_0.vmethod_16();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002C0F File Offset: 0x00000E0F
		public override Class6.Class19 vmethod_17()
		{
			return this.object_0.vmethod_17();
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002C1C File Offset: 0x00000E1C
		public override Class6.Class19 vmethod_18()
		{
			return this.object_0.vmethod_18();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002C29 File Offset: 0x00000E29
		public override Class6.Class20 vmethod_19()
		{
			return this.object_0.vmethod_19();
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002C36 File Offset: 0x00000E36
		public override Class6.Class20 vmethod_20()
		{
			return this.object_0.vmethod_20();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000027EE File Offset: 0x000009EE
		public override Class6.Class19 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000027F6 File Offset: 0x000009F6
		public override Class6.Class19 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000027FE File Offset: 0x000009FE
		public override Class6.Class19 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002806 File Offset: 0x00000A06
		public override Class6.Class20 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000280E File Offset: 0x00000A0E
		public override Class6.Class19 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002816 File Offset: 0x00000A16
		public override Class6.Class19 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000281E File Offset: 0x00000A1E
		public override Class6.Class19 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002826 File Offset: 0x00000A26
		public override Class6.Class20 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002C43 File Offset: 0x00000E43
		public override Class6.Class19 vmethod_29()
		{
			return this.object_0.vmethod_29();
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002C50 File Offset: 0x00000E50
		public override Class6.Class19 vmethod_30()
		{
			return this.object_0.vmethod_30();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002C5D File Offset: 0x00000E5D
		public override Class6.Class19 vmethod_31()
		{
			return this.object_0.vmethod_31();
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002C6A File Offset: 0x00000E6A
		public override Class6.Class19 vmethod_32()
		{
			return this.object_0.vmethod_32();
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002C77 File Offset: 0x00000E77
		public override Class6.Class19 vmethod_33()
		{
			return this.object_0.vmethod_33();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002C84 File Offset: 0x00000E84
		public override Class6.Class19 vmethod_34()
		{
			return this.object_0.vmethod_34();
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002C91 File Offset: 0x00000E91
		public override Class6.Class20 vmethod_35()
		{
			return this.object_0.vmethod_35();
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002C9E File Offset: 0x00000E9E
		public override Class6.Class20 vmethod_36()
		{
			return this.object_0.vmethod_36();
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002CAB File Offset: 0x00000EAB
		public override Class6.Class19 vmethod_37()
		{
			return this.object_0.vmethod_37();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002CB8 File Offset: 0x00000EB8
		public override Class6.Class19 vmethod_38()
		{
			return this.object_0.vmethod_38();
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002CC5 File Offset: 0x00000EC5
		public override Class6.Class19 vmethod_39()
		{
			return this.object_0.vmethod_39();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002CD2 File Offset: 0x00000ED2
		public override Class6.Class19 vmethod_40()
		{
			return this.object_0.vmethod_40();
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002CDF File Offset: 0x00000EDF
		public override Class6.Class19 vmethod_41()
		{
			return this.object_0.vmethod_41();
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002CEC File Offset: 0x00000EEC
		public override Class6.Class19 vmethod_42()
		{
			return this.object_0.vmethod_42();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public override Class6.Class20 vmethod_43()
		{
			return this.object_0.vmethod_43();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002D06 File Offset: 0x00000F06
		public override Class6.Class20 vmethod_44()
		{
			return this.object_0.vmethod_44();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002D13 File Offset: 0x00000F13
		public override Class6.Class22 vmethod_45()
		{
			return this.object_0.vmethod_45();
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002D20 File Offset: 0x00000F20
		public override Class6.Class22 vmethod_46()
		{
			return this.object_0.vmethod_46();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002D2D File Offset: 0x00000F2D
		public override Class6.Class22 zLqpmHyYrP()
		{
			return this.object_0.zLqpmHyYrP();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00017B70 File Offset: 0x00015D70
		public override Class6.Class21 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_24().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_23().struct1_0.int_0);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00017BB4 File Offset: 0x00015DB4
		public override Class6.Class21 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_28().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_27().struct1_0.uint_0);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00017BF8 File Offset: 0x00015DF8
		public override Class6.Class21 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_35().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_33().struct1_0.int_0);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00017C3C File Offset: 0x00015E3C
		public override Class6.Class21 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_43().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_41().struct1_0.uint_0);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00017C80 File Offset: 0x00015E80
		public override Class6.Class21 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_36().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00017CC4 File Offset: 0x00015EC4
		public override Class6.Class21 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0001A240 File Offset: 0x00018440
		public override Class6.Class17 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(-((Class6.Class20)this.object_0).struct2_0.long_0);
			}
			return new Class6.Class21((long)(-(long)((Class6.Class19)this.object_0).struct1_0.int_0));
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001A290 File Offset: 0x00018490
		public override Class6.Class17 Add(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 + ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 + ((Class6.Class19)class17_0).struct1_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 + ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 + ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0001A380 File Offset: 0x00018580
		public override Class6.Class17 vmethod_54(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.long_0 + ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_17().struct1_0.int_0 + ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.long_0 + ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_17().struct1_0.int_0 + ((Class6.Class19)class17_0).struct1_0.int_0)));
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0001A470 File Offset: 0x00018670
		public override Class6.Class17 vmethod_55(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.ulong_0 + unchecked((ulong)((Class6.Class19)class17_0).struct1_0.uint_0)));
				}
				return new Class6.Class21((long)((ulong)(checked(this.vmethod_17().struct1_0.uint_0 + ((Class6.Class19)class17_0).struct1_0.uint_0))));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.ulong_0 + ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0));
				}
				return new Class6.Class21((ulong)(checked(this.vmethod_17().struct1_0.uint_0 + ((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0)));
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0001A55C File Offset: 0x0001875C
		public override Class6.Class17 vmethod_56(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 - ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 - ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 - ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 - ((Class6.Class19)class17_0).struct1_0.int_0));
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0001A64C File Offset: 0x0001884C
		public Class6.Class17 method_8(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0 - this.vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0 - this.vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0 - this.vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class19)class17_0).struct1_0.int_0 - this.vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0001A73C File Offset: 0x0001893C
		public override Class6.Class17 vmethod_57(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.long_0 - ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_17().struct1_0.int_0 - ((Class6.Class19)class17_0).struct1_0.int_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.long_0 - ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_17().struct1_0.int_0 - ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0)));
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0001A82C File Offset: 0x00018A2C
		public Class6.Class17 method_9(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0 - this.vmethod_19().struct2_0.long_0));
				}
				return new Class6.Class21((long)(checked(((Class6.Class19)class17_0).struct1_0.int_0 - this.vmethod_17().struct1_0.int_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0 - this.vmethod_19().struct2_0.long_0));
				}
				return new Class6.Class21((long)(checked(((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0 - this.vmethod_17().struct1_0.int_0)));
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0001A91C File Offset: 0x00018B1C
		public override Class6.Class17 vmethod_58(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.ulong_0 - ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0));
				}
				return new Class6.Class21((ulong)(checked(this.vmethod_17().struct1_0.uint_0 - ((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.ulong_0 - unchecked((ulong)((Class6.Class19)class17_0).struct1_0.uint_0)));
				}
				return new Class6.Class21((long)((ulong)(checked(this.vmethod_17().struct1_0.uint_0 - ((Class6.Class19)class17_0).struct1_0.uint_0))));
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001AA08 File Offset: 0x00018C08
		public Class6.Class17 method_10(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(unchecked((ulong)((Class6.Class19)class17_0).struct1_0.uint_0) - this.vmethod_19().struct2_0.ulong_0));
				}
				return new Class6.Class21((long)((ulong)(checked(((Class6.Class19)class17_0).struct1_0.uint_0 - this.vmethod_17().struct1_0.uint_0))));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0 - this.vmethod_19().struct2_0.ulong_0));
				}
				return new Class6.Class21((ulong)(checked(((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0 - this.vmethod_17().struct1_0.uint_0)));
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0001AAF4 File Offset: 0x00018CF4
		public override Class6.Class17 vmethod_59(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 * ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 * ((Class6.Class19)class17_0).struct1_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 * ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 * ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0001ABE4 File Offset: 0x00018DE4
		public override Class6.Class17 vmethod_60(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.long_0 * ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_17().struct1_0.int_0 * ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.long_0 * ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_17().struct1_0.int_0 * ((Class6.Class19)class17_0).struct1_0.int_0)));
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0001ACD4 File Offset: 0x00018ED4
		public override Class6.Class17 vmethod_61(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.ulong_0 * unchecked((ulong)((Class6.Class19)class17_0).struct1_0.uint_0)));
				}
				return new Class6.Class21((long)((ulong)(checked(this.vmethod_17().struct1_0.uint_0 * ((Class6.Class19)class17_0).struct1_0.uint_0))));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_19().struct2_0.ulong_0 * ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0));
				}
				return new Class6.Class21((ulong)(checked(this.vmethod_17().struct1_0.uint_0 * ((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0)));
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0001ADC0 File Offset: 0x00018FC0
		public override Class6.Class17 vmethod_62(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 / ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 / ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 / ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 / ((Class6.Class19)class17_0).struct1_0.int_0));
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0001AEB0 File Offset: 0x000190B0
		public Class6.Class17 method_11(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0 / this.vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0 / this.vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0 / this.vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class19)class17_0).struct1_0.int_0 / this.vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0001AFA0 File Offset: 0x000191A0
		public override Class6.Class17 vmethod_63(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.ulong_0 / ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0);
				}
				return new Class6.Class21((ulong)(this.vmethod_17().struct1_0.uint_0 / ((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.ulong_0 / ((Class6.Class19)class17_0).vmethod_19().struct2_0.ulong_0);
				}
				return new Class6.Class21((long)((ulong)(this.vmethod_17().struct1_0.uint_0 / ((Class6.Class19)class17_0).struct1_0.uint_0)));
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0001B090 File Offset: 0x00019290
		public Class6.Class17 method_12(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0 / this.vmethod_19().struct2_0.ulong_0);
				}
				return new Class6.Class21((ulong)(((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0 / this.vmethod_17().struct1_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_19().struct2_0.ulong_0 / this.vmethod_19().struct2_0.ulong_0);
				}
				return new Class6.Class21((long)((ulong)(((Class6.Class19)class17_0).struct1_0.uint_0 / this.vmethod_17().struct1_0.uint_0)));
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0001B180 File Offset: 0x00019380
		public override Class6.Class17 vmethod_64(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 % ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 % ((Class6.Class19)class17_0).struct1_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 % ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 % ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0001B270 File Offset: 0x00019470
		public Class6.Class17 method_13(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0 % this.vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class19)class17_0).struct1_0.int_0 % this.vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0 % this.vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0 % this.vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0001B360 File Offset: 0x00019560
		public override Class6.Class17 vmethod_65(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.ulong_0 % ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0);
				}
				return new Class6.Class21((ulong)(this.vmethod_17().struct1_0.uint_0 % ((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.ulong_0 % ((Class6.Class19)class17_0).vmethod_19().struct2_0.ulong_0);
				}
				return new Class6.Class21((long)((ulong)(this.vmethod_17().struct1_0.uint_0 % ((Class6.Class19)class17_0).struct1_0.uint_0)));
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0001B450 File Offset: 0x00019650
		public Class6.Class17 method_14(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_19().struct2_0.ulong_0 % this.vmethod_19().struct2_0.ulong_0);
				}
				return new Class6.Class21((long)((ulong)(((Class6.Class19)class17_0).struct1_0.uint_0 % this.vmethod_17().struct1_0.uint_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0 % this.vmethod_19().struct2_0.ulong_0);
				}
				return new Class6.Class21((ulong)(((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0 % this.vmethod_17().struct1_0.uint_0));
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001B540 File Offset: 0x00019740
		public override Class6.Class17 vmethod_66(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 & ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 & ((Class6.Class19)class17_0).struct1_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 & ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 & ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001B630 File Offset: 0x00019830
		public override Class6.Class17 vmethod_67(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 | ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 | ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 | ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 | ((Class6.Class19)class17_0).struct1_0.int_0));
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001B720 File Offset: 0x00019920
		public override Class6.Class17 vmethod_68()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(~this.vmethod_19().struct2_0.long_0);
			}
			return new Class6.Class21((long)(~(long)this.vmethod_17().struct1_0.int_0));
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001B764 File Offset: 0x00019964
		public override Class6.Class17 igEvpBpxrl(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 ^ ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 ^ ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 ^ ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 ^ ((Class6.Class19)class17_0).struct1_0.int_0));
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001B854 File Offset: 0x00019A54
		public override Class6.Class17 vmethod_70(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 << ((Class6.Class19)class17_0).struct1_0.int_0);
				}
				return new Class6.Class21((long)((long)this.vmethod_17().struct1_0.int_0 << ((Class6.Class19)class17_0).struct1_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 << ((Class6.Class21)class17_0).vmethod_19().struct2_0.int_0);
				}
				return new Class6.Class21((long)((long)this.vmethod_17().struct1_0.int_0 << ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0001B94C File Offset: 0x00019B4C
		public override Class6.Class17 vmethod_71(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 >> ((Class6.Class19)class17_0).struct1_0.int_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 >> ((Class6.Class19)class17_0).struct1_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.long_0 >> ((Class6.Class21)class17_0).vmethod_19().struct2_0.int_0);
				}
				return new Class6.Class21((long)(this.vmethod_17().struct1_0.int_0 >> ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001BA44 File Offset: 0x00019C44
		public override Class6.Class17 vmethod_72(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.ulong_0 >> ((Class6.Class21)class17_0).vmethod_19().struct2_0.int_0);
				}
				return new Class6.Class21((long)((ulong)(this.vmethod_17().struct1_0.uint_0 >> ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_19().struct2_0.ulong_0 >> ((Class6.Class19)class17_0).struct1_0.int_0);
				}
				return new Class6.Class21((long)((ulong)(this.vmethod_17().struct1_0.uint_0 >> ((Class6.Class19)class17_0).struct1_0.int_0)));
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002D3A File Offset: 0x00000F3A
		public Class6.Class17 method_15(Class6.Class19 class19_0)
		{
			return new Class6.Class21((long)((ulong)(class19_0.struct1_0.uint_0 >> this.vmethod_17().struct1_0.int_0)));
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002D61 File Offset: 0x00000F61
		public Class6.Class17 method_16(Class6.Class19 class19_0)
		{
			return new Class6.Class21((long)(class19_0.struct1_0.int_0 >> this.vmethod_19().struct2_0.int_0));
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002D88 File Offset: 0x00000F88
		public Class6.Class17 method_17(Class6.Class19 class19_0)
		{
			return new Class6.Class21((long)((long)class19_0.struct1_0.int_0 << this.vmethod_19().struct2_0.int_0));
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002DAF File Offset: 0x00000FAF
		public override string ToString()
		{
			return this.object_0.ToString();
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000296B File Offset: 0x00000B6B
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000296E File Offset: 0x00000B6E
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001BB3C File Offset: 0x00019D3C
		internal override bool vmethod_4(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.iFavIhWly7())
			{
				return ((Class6.Class23)class17_0).vmethod_4(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 == ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 == ((Class6.Class19)class17_0).struct1_0.int_0;
			}
			else
			{
				if (!@class.method_2())
				{
					return false;
				}
				int size = IntPtr.Size;
				return this.vmethod_19().struct2_0.long_0 == ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001BC18 File Offset: 0x00019E18
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.iFavIhWly7())
			{
				return ((Class6.Class23)class17_0).vmethod_5(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 != ((Class6.Class19)class17_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 != ((Class6.Class19)class17_0).struct1_0.uint_0;
			}
			else
			{
				if (!@class.method_2())
				{
					return false;
				}
				int size = IntPtr.Size;
				return this.vmethod_19().struct2_0.ulong_0 != ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0;
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		public override bool vmethod_73(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 >= ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 >= ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 >= ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 >= ((Class6.Class19)class17_0).struct1_0.int_0;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001BDE4 File Offset: 0x00019FE4
		public override bool vmethod_74(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 >= ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 >= ((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 >= ((Class6.Class19)class17_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 >= ((Class6.Class19)class17_0).struct1_0.uint_0;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		public override bool vmethod_75(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 > ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 > ((Class6.Class19)class17_0).struct1_0.int_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 > ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 > ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		public override bool vmethod_76(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 > ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 > ((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 > ((Class6.Class19)class17_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 > ((Class6.Class19)class17_0).struct1_0.uint_0;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001C090 File Offset: 0x0001A290
		public override bool vmethod_77(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 <= ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 <= ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 <= ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 <= ((Class6.Class19)class17_0).struct1_0.int_0;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001C17C File Offset: 0x0001A37C
		public override bool vmethod_78(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 <= ((Class6.Class19)class17_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 <= ((Class6.Class19)class17_0).struct1_0.uint_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 <= ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 <= ((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0;
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001C268 File Offset: 0x0001A468
		public override bool vmethod_79(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_1())
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 < ((Class6.Class21)class17_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 < ((Class6.Class21)class17_0).vmethod_17().struct1_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 < ((Class6.Class19)class17_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 < ((Class6.Class19)class17_0).struct1_0.int_0;
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001C348 File Offset: 0x0001A548
		public override bool vmethod_80(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 < ((Class6.Class19)class17_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 < ((Class6.Class19)class17_0).struct1_0.uint_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 < ((Class6.Class21)class17_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 < ((Class6.Class21)class17_0).vmethod_17().struct1_0.uint_0;
			}
		}

		// Token: 0x040002EB RID: 747
		public object object_0;

		// Token: 0x040002EC RID: 748
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x02000059 RID: 89
	private abstract class Class18 : Class6.Class17
	{
		// Token: 0x06000347 RID: 839
		public abstract bool vmethod_10();

		// Token: 0x06000348 RID: 840
		public abstract bool yQwppAuByG();

		// Token: 0x06000349 RID: 841
		public abstract Class6.Class17 vmethod_11(Class6.Enum1 enum1_0);

		// Token: 0x0600034A RID: 842
		public abstract Class6.Class19 vmethod_12();

		// Token: 0x0600034B RID: 843
		public abstract Class6.Class19 vmethod_13();

		// Token: 0x0600034C RID: 844
		public abstract Class6.Class19 vmethod_14();

		// Token: 0x0600034D RID: 845
		public abstract Class6.Class19 vmethod_15();

		// Token: 0x0600034E RID: 846
		public abstract Class6.Class19 vmethod_16();

		// Token: 0x0600034F RID: 847
		public abstract Class6.Class19 vmethod_17();

		// Token: 0x06000350 RID: 848
		public abstract Class6.Class19 vmethod_18();

		// Token: 0x06000351 RID: 849
		public abstract Class6.Class20 vmethod_19();

		// Token: 0x06000352 RID: 850
		public abstract Class6.Class20 vmethod_20();

		// Token: 0x06000353 RID: 851
		public abstract Class6.Class19 vmethod_21();

		// Token: 0x06000354 RID: 852
		public abstract Class6.Class19 vmethod_22();

		// Token: 0x06000355 RID: 853
		public abstract Class6.Class19 vmethod_23();

		// Token: 0x06000356 RID: 854
		public abstract Class6.Class20 vmethod_24();

		// Token: 0x06000357 RID: 855
		public abstract Class6.Class19 vmethod_25();

		// Token: 0x06000358 RID: 856
		public abstract Class6.Class19 vmethod_26();

		// Token: 0x06000359 RID: 857
		public abstract Class6.Class19 vmethod_27();

		// Token: 0x0600035A RID: 858
		public abstract Class6.Class20 vmethod_28();

		// Token: 0x0600035B RID: 859
		public abstract Class6.Class19 vmethod_29();

		// Token: 0x0600035C RID: 860
		public abstract Class6.Class19 vmethod_30();

		// Token: 0x0600035D RID: 861
		public abstract Class6.Class19 vmethod_31();

		// Token: 0x0600035E RID: 862
		public abstract Class6.Class19 vmethod_32();

		// Token: 0x0600035F RID: 863
		public abstract Class6.Class19 vmethod_33();

		// Token: 0x06000360 RID: 864
		public abstract Class6.Class19 vmethod_34();

		// Token: 0x06000361 RID: 865
		public abstract Class6.Class20 vmethod_35();

		// Token: 0x06000362 RID: 866
		public abstract Class6.Class20 vmethod_36();

		// Token: 0x06000363 RID: 867
		public abstract Class6.Class19 vmethod_37();

		// Token: 0x06000364 RID: 868
		public abstract Class6.Class19 vmethod_38();

		// Token: 0x06000365 RID: 869
		public abstract Class6.Class19 vmethod_39();

		// Token: 0x06000366 RID: 870
		public abstract Class6.Class19 vmethod_40();

		// Token: 0x06000367 RID: 871
		public abstract Class6.Class19 vmethod_41();

		// Token: 0x06000368 RID: 872
		public abstract Class6.Class19 vmethod_42();

		// Token: 0x06000369 RID: 873
		public abstract Class6.Class20 vmethod_43();

		// Token: 0x0600036A RID: 874
		public abstract Class6.Class20 vmethod_44();

		// Token: 0x0600036B RID: 875
		public abstract Class6.Class22 vmethod_45();

		// Token: 0x0600036C RID: 876
		public abstract Class6.Class22 vmethod_46();

		// Token: 0x0600036D RID: 877
		public abstract Class6.Class22 zLqpmHyYrP();

		// Token: 0x0600036E RID: 878
		public abstract Class6.Class21 vmethod_47();

		// Token: 0x0600036F RID: 879
		public abstract Class6.Class21 vmethod_48();

		// Token: 0x06000370 RID: 880
		public abstract Class6.Class21 vmethod_49();

		// Token: 0x06000371 RID: 881
		public abstract Class6.Class21 vmethod_50();

		// Token: 0x06000372 RID: 882
		public abstract Class6.Class21 vmethod_51();

		// Token: 0x06000373 RID: 883
		public abstract Class6.Class21 vmethod_52();

		// Token: 0x06000374 RID: 884
		public abstract Class6.Class17 vmethod_53();

		// Token: 0x06000375 RID: 885
		public abstract Class6.Class17 Add(Class6.Class17 class17_0);

		// Token: 0x06000376 RID: 886
		public abstract Class6.Class17 vmethod_54(Class6.Class17 class17_0);

		// Token: 0x06000377 RID: 887
		public abstract Class6.Class17 vmethod_55(Class6.Class17 class17_0);

		// Token: 0x06000378 RID: 888
		public abstract Class6.Class17 vmethod_56(Class6.Class17 class17_0);

		// Token: 0x06000379 RID: 889
		public abstract Class6.Class17 vmethod_57(Class6.Class17 class17_0);

		// Token: 0x0600037A RID: 890
		public abstract Class6.Class17 vmethod_58(Class6.Class17 class17_0);

		// Token: 0x0600037B RID: 891
		public abstract Class6.Class17 vmethod_59(Class6.Class17 class17_0);

		// Token: 0x0600037C RID: 892
		public abstract Class6.Class17 vmethod_60(Class6.Class17 class17_0);

		// Token: 0x0600037D RID: 893
		public abstract Class6.Class17 vmethod_61(Class6.Class17 class17_0);

		// Token: 0x0600037E RID: 894
		public abstract Class6.Class17 vmethod_62(Class6.Class17 class17_0);

		// Token: 0x0600037F RID: 895
		public abstract Class6.Class17 vmethod_63(Class6.Class17 class17_0);

		// Token: 0x06000380 RID: 896
		public abstract Class6.Class17 vmethod_64(Class6.Class17 class17_0);

		// Token: 0x06000381 RID: 897
		public abstract Class6.Class17 vmethod_65(Class6.Class17 class17_0);

		// Token: 0x06000382 RID: 898
		public abstract Class6.Class17 vmethod_66(Class6.Class17 class17_0);

		// Token: 0x06000383 RID: 899
		public abstract Class6.Class17 vmethod_67(Class6.Class17 class17_0);

		// Token: 0x06000384 RID: 900
		public abstract Class6.Class17 vmethod_68();

		// Token: 0x06000385 RID: 901
		public abstract Class6.Class17 igEvpBpxrl(Class6.Class17 class17_0);

		// Token: 0x06000386 RID: 902
		public abstract Class6.Class18 vmethod_69();

		// Token: 0x06000387 RID: 903
		public abstract Class6.Class17 vmethod_70(Class6.Class17 class17_0);

		// Token: 0x06000388 RID: 904
		public abstract Class6.Class17 vmethod_71(Class6.Class17 class17_0);

		// Token: 0x06000389 RID: 905
		public abstract Class6.Class17 vmethod_72(Class6.Class17 class17_0);

		// Token: 0x0600038A RID: 906
		public abstract bool vmethod_73(Class6.Class17 class17_0);

		// Token: 0x0600038B RID: 907
		public abstract bool vmethod_74(Class6.Class17 class17_0);

		// Token: 0x0600038C RID: 908
		public abstract bool vmethod_75(Class6.Class17 class17_0);

		// Token: 0x0600038D RID: 909
		public abstract bool vmethod_76(Class6.Class17 class17_0);

		// Token: 0x0600038E RID: 910
		public abstract bool vmethod_77(Class6.Class17 class17_0);

		// Token: 0x0600038F RID: 911
		public abstract bool vmethod_78(Class6.Class17 class17_0);

		// Token: 0x06000390 RID: 912
		public abstract bool vmethod_79(Class6.Class17 class17_0);

		// Token: 0x06000391 RID: 913
		public abstract bool vmethod_80(Class6.Class17 class17_0);

		// Token: 0x06000392 RID: 914 RVA: 0x0000296E File Offset: 0x00000B6E
		internal override bool vmethod_2()
		{
			return true;
		}
	}

	// Token: 0x0200005A RID: 90
	private class Class22 : Class6.Class18
	{
		// Token: 0x06000394 RID: 916 RVA: 0x0001C440 File Offset: 0x0001A640
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			this.double_0 = ((Class6.Class22)class17_0).double_0;
			this.enum1_0 = ((Class6.Class22)class17_0).enum1_0;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00017418 File Offset: 0x00015618
		internal override void vmethod_1(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0001C470 File Offset: 0x0001A670
		public Class22(double double_1)
		{
			this.enum4_0 = (Class6.Enum4)5;
			this.enum1_0 = (Class6.Enum1)10;
			this.double_0 = double_1;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0001C49C File Offset: 0x0001A69C
		public Class22(Class6.Class22 class22_0)
		{
			this.enum4_0 = class22_0.enum4_0;
			this.enum1_0 = class22_0.enum1_0;
			this.double_0 = class22_0.double_0;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002DBC File Offset: 0x00000FBC
		public override Class6.Class18 vmethod_69()
		{
			return new Class6.Class22(this);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001C4D8 File Offset: 0x0001A6D8
		public Class22(double double_1, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)5;
			this.double_0 = double_1;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001C504 File Offset: 0x0001A704
		public Class22(float float_0)
		{
			this.enum4_0 = (Class6.Enum4)5;
			this.double_0 = (double)float_0;
			this.enum1_0 = (Class6.Enum1)9;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0001C530 File Offset: 0x0001A730
		public Class22(float float_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)5;
			this.double_0 = (double)float_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public override bool vmethod_10()
		{
			return this.double_0 == 0.0;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000272D File Offset: 0x0000092D
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public override string ToString()
		{
			return this.double_0.ToString();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0001C55C File Offset: 0x0001A75C
		public override Class6.Class17 vmethod_11(Class6.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class6.Enum1)1:
				return this.vmethod_13();
			case (Class6.Enum1)2:
				return this.vmethod_14();
			case (Class6.Enum1)3:
				return this.vmethod_15();
			case (Class6.Enum1)4:
				return this.vmethod_16();
			case (Class6.Enum1)5:
				return this.vmethod_17();
			case (Class6.Enum1)6:
				return this.vmethod_18();
			case (Class6.Enum1)7:
				return this.vmethod_19();
			case (Class6.Enum1)8:
				return this.vmethod_20();
			case (Class6.Enum1)9:
				return this.vmethod_45();
			case (Class6.Enum1)10:
				return this.vmethod_46();
			case (Class6.Enum1)11:
				return this.vmethod_12();
			default:
				throw new Exception(((Class6.Enum5)4).ToString());
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0001C600 File Offset: 0x0001A800
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(float))
			{
				return (float)this.double_0;
			}
			if (type_0 == typeof(double))
			{
				return this.double_0;
			}
			if ((type_0 == null || type_0 == typeof(object)) && this.enum1_0 == (Class6.Enum1)9)
			{
				return (float)this.double_0;
			}
			return this.double_0;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
		public override Class6.Class19 vmethod_12()
		{
			return new Class6.Class19(this.vmethod_10() ? 1 : 0);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002738 File Offset: 0x00000938
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public override Class6.Class19 vmethod_13()
		{
			return new Class6.Class19((int)((sbyte)this.double_0), (Class6.Enum1)1);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002DF3 File Offset: 0x00000FF3
		public override Class6.Class19 vmethod_14()
		{
			return new Class6.Class19((uint)((byte)this.double_0), (Class6.Enum1)2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002E02 File Offset: 0x00001002
		public override Class6.Class19 vmethod_15()
		{
			return new Class6.Class19((int)((short)this.double_0), (Class6.Enum1)3);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002E11 File Offset: 0x00001011
		public override Class6.Class19 vmethod_16()
		{
			return new Class6.Class19((uint)((ushort)this.double_0), (Class6.Enum1)4);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002E20 File Offset: 0x00001020
		public override Class6.Class19 vmethod_17()
		{
			return new Class6.Class19((int)this.double_0, (Class6.Enum1)5);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002E2F File Offset: 0x0000102F
		public override Class6.Class19 vmethod_18()
		{
			return new Class6.Class19((uint)this.double_0, (Class6.Enum1)6);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002E3E File Offset: 0x0000103E
		public override Class6.Class20 vmethod_19()
		{
			return new Class6.Class20((long)this.double_0, (Class6.Enum1)7);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002E4D File Offset: 0x0000104D
		public override Class6.Class20 vmethod_20()
		{
			return new Class6.Class20((ulong)this.double_0, (Class6.Enum1)8);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000027EE File Offset: 0x000009EE
		public override Class6.Class19 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000027F6 File Offset: 0x000009F6
		public override Class6.Class19 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000027FE File Offset: 0x000009FE
		public override Class6.Class19 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002806 File Offset: 0x00000A06
		public override Class6.Class20 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000280E File Offset: 0x00000A0E
		public override Class6.Class19 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002816 File Offset: 0x00000A16
		public override Class6.Class19 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000281E File Offset: 0x00000A1E
		public override Class6.Class19 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002826 File Offset: 0x00000A26
		public override Class6.Class20 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002E5C File Offset: 0x0000105C
		public override Class6.Class19 vmethod_29()
		{
			return new Class6.Class19((int)(checked((sbyte)this.double_0)), (Class6.Enum1)1);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002E5C File Offset: 0x0000105C
		public override Class6.Class19 vmethod_30()
		{
			return new Class6.Class19((int)(checked((sbyte)this.double_0)), (Class6.Enum1)1);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002E6B File Offset: 0x0000106B
		public override Class6.Class19 vmethod_31()
		{
			return new Class6.Class19((int)(checked((short)this.double_0)), (Class6.Enum1)3);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002E6B File Offset: 0x0000106B
		public override Class6.Class19 vmethod_32()
		{
			return new Class6.Class19((int)(checked((short)this.double_0)), (Class6.Enum1)3);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002E7A File Offset: 0x0000107A
		public override Class6.Class19 vmethod_33()
		{
			return new Class6.Class19(checked((int)this.double_0), (Class6.Enum1)5);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002E7A File Offset: 0x0000107A
		public override Class6.Class19 vmethod_34()
		{
			return new Class6.Class19(checked((int)this.double_0), (Class6.Enum1)5);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002E89 File Offset: 0x00001089
		public override Class6.Class20 vmethod_35()
		{
			return new Class6.Class20(checked((long)this.double_0), (Class6.Enum1)7);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002E89 File Offset: 0x00001089
		public override Class6.Class20 vmethod_36()
		{
			return new Class6.Class20(checked((long)this.double_0), (Class6.Enum1)7);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002E98 File Offset: 0x00001098
		public override Class6.Class19 vmethod_37()
		{
			return new Class6.Class19((int)(checked((byte)this.double_0)), (Class6.Enum1)2);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002E98 File Offset: 0x00001098
		public override Class6.Class19 vmethod_38()
		{
			return new Class6.Class19((int)(checked((byte)this.double_0)), (Class6.Enum1)2);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002EA7 File Offset: 0x000010A7
		public override Class6.Class19 vmethod_39()
		{
			return new Class6.Class19((int)(checked((ushort)this.double_0)), (Class6.Enum1)4);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002EA7 File Offset: 0x000010A7
		public override Class6.Class19 vmethod_40()
		{
			return new Class6.Class19((int)(checked((ushort)this.double_0)), (Class6.Enum1)4);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002EB6 File Offset: 0x000010B6
		public override Class6.Class19 vmethod_41()
		{
			return new Class6.Class19(checked((uint)this.double_0), (Class6.Enum1)6);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002EB6 File Offset: 0x000010B6
		public override Class6.Class19 vmethod_42()
		{
			return new Class6.Class19(checked((uint)this.double_0), (Class6.Enum1)6);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002EC5 File Offset: 0x000010C5
		public override Class6.Class20 vmethod_43()
		{
			return new Class6.Class20(checked((ulong)this.double_0), (Class6.Enum1)8);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002EC5 File Offset: 0x000010C5
		public override Class6.Class20 vmethod_44()
		{
			return new Class6.Class20(checked((ulong)this.double_0), (Class6.Enum1)8);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002ED4 File Offset: 0x000010D4
		public override Class6.Class22 vmethod_45()
		{
			return new Class6.Class22((float)this.double_0, (Class6.Enum1)9);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002EE4 File Offset: 0x000010E4
		public override Class6.Class22 vmethod_46()
		{
			return new Class6.Class22(this.double_0, (Class6.Enum1)10);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002EF4 File Offset: 0x000010F4
		public override Class6.Class22 zLqpmHyYrP()
		{
			return new Class6.Class22(this.double_0);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00017B70 File Offset: 0x00015D70
		public override Class6.Class21 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_24().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_23().struct1_0.int_0);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00017BB4 File Offset: 0x00015DB4
		public override Class6.Class21 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_28().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_27().struct1_0.uint_0);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00017BF8 File Offset: 0x00015DF8
		public override Class6.Class21 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_35().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_33().struct1_0.int_0);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00017C3C File Offset: 0x00015E3C
		public override Class6.Class21 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_43().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_41().struct1_0.uint_0);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00017C80 File Offset: 0x00015E80
		public override Class6.Class21 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_36().struct2_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00017CC4 File Offset: 0x00015EC4
		public override Class6.Class21 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
		public override Class6.Class17 vmethod_53()
		{
			if (this.enum1_0 == (Class6.Enum1)9)
			{
				return new Class6.Class22((float)(-(float)this.double_0));
			}
			return new Class6.Class22(-this.double_0);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
		public override Class6.Class17 Add(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 + ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
		public override Class6.Class17 vmethod_54(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 + ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
		public override Class6.Class17 vmethod_55(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 + ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0001C738 File Offset: 0x0001A938
		public override Class6.Class17 vmethod_56(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 - ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0001C738 File Offset: 0x0001A938
		public override Class6.Class17 vmethod_57(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 - ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0001C738 File Offset: 0x0001A938
		public override Class6.Class17 vmethod_58(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 - ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0001C77C File Offset: 0x0001A97C
		public override Class6.Class17 vmethod_59(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4() || !class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 * ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0001C7C8 File Offset: 0x0001A9C8
		public override Class6.Class17 vmethod_60(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 * ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0001C7C8 File Offset: 0x0001A9C8
		public override Class6.Class17 vmethod_61(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 * ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0001C80C File Offset: 0x0001AA0C
		public override Class6.Class17 vmethod_62(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 / ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0001C80C File Offset: 0x0001AA0C
		public override Class6.Class17 vmethod_63(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 / ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0001C850 File Offset: 0x0001AA50
		public override Class6.Class17 vmethod_64(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 % ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001C850 File Offset: 0x0001AA50
		public override Class6.Class17 vmethod_65(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 % ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002F02 File Offset: 0x00001102
		public override Class6.Class17 vmethod_66(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002F02 File Offset: 0x00001102
		public override Class6.Class17 vmethod_67(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002F02 File Offset: 0x00001102
		public override Class6.Class17 vmethod_68()
		{
			throw new Class6.Exception1();
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002F02 File Offset: 0x00001102
		public override Class6.Class17 igEvpBpxrl(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002F02 File Offset: 0x00001102
		public override Class6.Class17 vmethod_70(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002F02 File Offset: 0x00001102
		public override Class6.Class17 vmethod_71(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002F02 File Offset: 0x00001102
		public override Class6.Class17 vmethod_72(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000296B File Offset: 0x00000B6B
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0001C894 File Offset: 0x0001AA94
		internal override bool vmethod_4(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.iFavIhWly7())
			{
				return ((Class6.Class23)class17_0).vmethod_4(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			return @class.method_4() && this.double_0 == ((Class6.Class22)@class).double_0;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.iFavIhWly7())
			{
				return ((Class6.Class23)class17_0).vmethod_5(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			return @class.method_4() && this.double_0 != ((Class6.Class22)@class).double_0;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0001C940 File Offset: 0x0001AB40
		public override bool vmethod_73(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 >= ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0001C940 File Offset: 0x0001AB40
		public override bool vmethod_74(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 >= ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001C984 File Offset: 0x0001AB84
		public override bool vmethod_75(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 > ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001C984 File Offset: 0x0001AB84
		public override bool vmethod_76(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 > ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0001C9C4 File Offset: 0x0001ABC4
		public override bool vmethod_77(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 <= ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001C9C4 File Offset: 0x0001ABC4
		public override bool vmethod_78(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 <= ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001CA08 File Offset: 0x0001AC08
		public override bool vmethod_79(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 < ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001CA08 File Offset: 0x0001AC08
		public override bool vmethod_80(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 < ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x040002ED RID: 749
		public double double_0;

		// Token: 0x040002EE RID: 750
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x0200005B RID: 91
	internal enum Enum1 : byte
	{

	}

	// Token: 0x0200005C RID: 92
	internal enum Enum2 : byte
	{

	}

	// Token: 0x0200005D RID: 93
	private class Exception0 : Exception
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x0001CA48 File Offset: 0x0001AC48
		public Exception0(string string_0) : base(string_0)
		{
		}
	}

	// Token: 0x0200005E RID: 94
	private class Exception1 : Exception
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x0001CA60 File Offset: 0x0001AC60
		public Exception1()
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001CA48 File Offset: 0x0001AC48
		public Exception1(string string_0) : base(string_0)
		{
		}
	}

	// Token: 0x0200005F RID: 95
	internal class Class7
	{
		// Token: 0x060003EF RID: 1007 RVA: 0x0001CA78 File Offset: 0x0001AC78
		public override string ToString()
		{
			object obj = this.enum3_0;
			if (this.object_0 != null)
			{
				return obj.ToString() + 'H'.ToString() + this.object_0.ToString();
			}
			return obj.ToString();
		}

		// Token: 0x040002F1 RID: 753
		internal Class6.Enum3 enum3_0 = (Class6.Enum3)126;

		// Token: 0x040002F2 RID: 754
		internal object object_0;
	}

	// Token: 0x02000060 RID: 96
	internal abstract class Class23 : Class6.Class17
	{
		// Token: 0x060003F1 RID: 1009 RVA: 0x0001C428 File Offset: 0x0001A628
		public Class23()
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000296E File Offset: 0x00000B6E
		internal override bool iFavIhWly7()
		{
			return true;
		}

		// Token: 0x060003F3 RID: 1011
		internal abstract IntPtr vmethod_10();

		// Token: 0x060003F4 RID: 1012
		internal abstract void vmethod_11(Class6.Class17 class17_0);

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000296E File Offset: 0x00000B6E
		internal override bool vmethod_0()
		{
			return true;
		}
	}

	// Token: 0x02000061 RID: 97
	internal class Class24 : Class6.Class23
	{
		// Token: 0x060003F6 RID: 1014 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		public Class24(int int_1, Class6.Class15 class15_1)
		{
			this.class15_0 = class15_1;
			this.int_0 = int_1;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0001CB10 File Offset: 0x0001AD10
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0 is Class6.Class24)
			{
				this.class15_0 = ((Class6.Class24)class17_0).class15_0;
				this.int_0 = ((Class6.Class24)class17_0).int_0;
				return;
			}
			Class6.Class9 @class = this.class15_0.class12_0.UqaYjxudZI[this.int_0];
			if (class17_0 is Class6.Class23 && (@class.enum1_0 & (Class6.Enum1)226) > (Class6.Enum1)0)
			{
				Class6.Class17 class17_ = (class17_0 as Class6.Class23).vmethod_7();
				this.vmethod_11(class17_);
				return;
			}
			this.vmethod_11(class17_0);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		internal override void vmethod_1(Class6.Class17 class17_0)
		{
			this.vmethod_11(class17_0);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002F09 File Offset: 0x00001109
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
		internal override void vmethod_11(Class6.Class17 class17_0)
		{
			this.class15_0.class17_1[this.int_0] = class17_0;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0001CBD0 File Offset: 0x0001ADD0
		internal override object vmethod_3(Type type_0)
		{
			if (this.class15_0.class17_1[this.int_0] != null)
			{
				return this.vmethod_7().vmethod_3(type_0);
			}
			return null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001CC00 File Offset: 0x0001AE00
		internal override Class6.Class17 vmethod_7()
		{
			if (this.class15_0.class17_1[this.int_0] == null)
			{
				return new Class6.Class29(null);
			}
			return this.class15_0.class17_1[this.int_0].vmethod_7();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002F10 File Offset: 0x00001110
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0001CC40 File Offset: 0x0001AE40
		internal override bool vmethod_4(Class6.Class17 class17_0)
		{
			return class17_0.iFavIhWly7() && class17_0 is Class6.Class24 && ((Class6.Class24)class17_0).int_0 == this.int_0;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001CC78 File Offset: 0x0001AE78
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			return !class17_0.iFavIhWly7() || !(class17_0 is Class6.Class24) || ((Class6.Class24)class17_0).int_0 != this.int_0;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002F1D File Offset: 0x0000111D
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x040002F3 RID: 755
		private Class6.Class15 class15_0;

		// Token: 0x040002F4 RID: 756
		internal int int_0;
	}

	// Token: 0x02000062 RID: 98
	internal class Class25 : Class6.Class23
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
		public Class25(int int_1, Array array_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002F09 File Offset: 0x00001109
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001CCDC File Offset: 0x0001AEDC
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0 is Class6.Class25)
			{
				this.array_0 = ((Class6.Class25)class17_0).array_0;
				this.int_0 = ((Class6.Class25)class17_0).int_0;
				return;
			}
			this.vmethod_11(class17_0);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		internal override void vmethod_1(Class6.Class17 class17_0)
		{
			this.vmethod_11(class17_0);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0001CD1C File Offset: 0x0001AF1C
		internal override void vmethod_11(Class6.Class17 class17_0)
		{
			this.array_0.SetValue(class17_0.vmethod_3(null), this.int_0);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002F2A File Offset: 0x0000112A
		internal override object vmethod_3(Type type_0)
		{
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002F38 File Offset: 0x00001138
		internal override Class6.Class17 vmethod_7()
		{
			return Class6.Class17.smethod_1(this.array_0.GetType().GetElementType(), this.array_0.GetValue(this.int_0));
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002F10 File Offset: 0x00001110
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001CD44 File Offset: 0x0001AF44
		internal override bool vmethod_4(Class6.Class17 class17_0)
		{
			if (!class17_0.iFavIhWly7())
			{
				return false;
			}
			if (!(class17_0 is Class6.Class25))
			{
				return false;
			}
			Class6.Class25 @class = (Class6.Class25)class17_0;
			return @class.int_0 == this.int_0 && @class.array_0 == this.array_0;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001CD90 File Offset: 0x0001AF90
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (!class17_0.iFavIhWly7())
			{
				return true;
			}
			if (!(class17_0 is Class6.Class25))
			{
				return true;
			}
			Class6.Class25 @class = (Class6.Class25)class17_0;
			return @class.int_0 != this.int_0 || @class.array_0 != this.array_0;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002F1D File Offset: 0x0000111D
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x040002F5 RID: 757
		private Array array_0;

		// Token: 0x040002F6 RID: 758
		internal int int_0;
	}

	// Token: 0x02000063 RID: 99
	internal class Class26 : Class6.Class23
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x0001CDDC File Offset: 0x0001AFDC
		public Class26(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002F09 File Offset: 0x00001109
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0001CE08 File Offset: 0x0001B008
		internal override void vmethod_11(Class6.Class17 class17_0)
		{
			if (this.object_0 != null && this.object_0 is Class6.Class17)
			{
				this.fieldInfo_0.SetValue(((Class6.Class17)this.object_0).vmethod_3(null), class17_0.vmethod_3(null));
				return;
			}
			this.fieldInfo_0.SetValue(this.object_0, class17_0.vmethod_3(null));
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0001CE68 File Offset: 0x0001B068
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0 is Class6.Class26)
			{
				this.fieldInfo_0 = ((Class6.Class26)class17_0).fieldInfo_0;
				this.object_0 = ((Class6.Class26)class17_0).object_0;
				return;
			}
			this.vmethod_11(class17_0);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		internal override void vmethod_1(Class6.Class17 class17_0)
		{
			this.vmethod_11(class17_0);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002F2A File Offset: 0x0000112A
		internal override object vmethod_3(Type type_0)
		{
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
		internal override Class6.Class17 vmethod_7()
		{
			if (this.object_0 != null && this.object_0 is Class6.Class17)
			{
				return Class6.Class17.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(((Class6.Class17)this.object_0).vmethod_3(null)));
			}
			return Class6.Class17.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(this.object_0));
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002F10 File Offset: 0x00001110
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001CF18 File Offset: 0x0001B118
		internal override bool vmethod_4(Class6.Class17 class17_0)
		{
			if (!class17_0.iFavIhWly7())
			{
				return false;
			}
			if (!(class17_0 is Class6.Class26))
			{
				return false;
			}
			Class6.Class26 @class = (Class6.Class26)class17_0;
			return !(@class.fieldInfo_0 != this.fieldInfo_0) && @class.object_0 == this.object_0;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001CF6C File Offset: 0x0001B16C
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (!class17_0.iFavIhWly7())
			{
				return true;
			}
			if (!(class17_0 is Class6.Class26))
			{
				return true;
			}
			Class6.Class26 @class = (Class6.Class26)class17_0;
			return @class.fieldInfo_0 != this.fieldInfo_0 || @class.object_0 != this.object_0;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002F1D File Offset: 0x0000111D
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x040002F7 RID: 759
		internal FieldInfo fieldInfo_0;

		// Token: 0x040002F8 RID: 760
		internal object object_0;
	}

	// Token: 0x02000064 RID: 100
	internal class Class27 : Class6.Class23
	{
		// Token: 0x06000417 RID: 1047 RVA: 0x0001CFC0 File Offset: 0x0001B1C0
		public Class27(int int_1, Class6.Class15 class15_1)
		{
			this.class15_0 = class15_1;
			this.int_0 = int_1;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002F09 File Offset: 0x00001109
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001CFEC File Offset: 0x0001B1EC
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0 is Class6.Class27)
			{
				this.class15_0 = ((Class6.Class27)class17_0).class15_0;
				this.int_0 = ((Class6.Class27)class17_0).int_0;
				return;
			}
			this.vmethod_11(class17_0);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		internal override void vmethod_1(Class6.Class17 class17_0)
		{
			this.vmethod_11(class17_0);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001D02C File Offset: 0x0001B22C
		internal override void vmethod_11(Class6.Class17 class17_0)
		{
			this.class15_0.class17_0[this.int_0] = class17_0;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001D04C File Offset: 0x0001B24C
		internal override object vmethod_3(Type type_0)
		{
			if (this.class15_0.class17_0[this.int_0] == null)
			{
				return null;
			}
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001D07C File Offset: 0x0001B27C
		internal override Class6.Class17 vmethod_7()
		{
			if (this.class15_0.class17_0[this.int_0] != null)
			{
				return this.class15_0.class17_0[this.int_0].vmethod_7();
			}
			return new Class6.Class29(null);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002F10 File Offset: 0x00001110
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001D0BC File Offset: 0x0001B2BC
		internal override bool vmethod_4(Class6.Class17 class17_0)
		{
			return class17_0.iFavIhWly7() && class17_0 is Class6.Class27 && ((Class6.Class27)class17_0).int_0 == this.int_0;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001D0F0 File Offset: 0x0001B2F0
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			return !class17_0.iFavIhWly7() || !(class17_0 is Class6.Class27) || ((Class6.Class27)class17_0).int_0 != this.int_0;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002F1D File Offset: 0x0000111D
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x040002F9 RID: 761
		private Class6.Class15 class15_0;

		// Token: 0x040002FA RID: 762
		internal int int_0;
	}

	// Token: 0x02000065 RID: 101
	internal class Class28 : Class6.Class23
	{
		// Token: 0x06000422 RID: 1058 RVA: 0x0001D128 File Offset: 0x0001B328
		public Class28(Class6.Class17 class17_1, Type type_0)
		{
			this.class17_0 = class17_1;
			this.LksYdldxWw = type_0;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002F09 File Offset: 0x00001109
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001D154 File Offset: 0x0001B354
		internal override void vmethod_9(Class6.Class17 class17_1)
		{
			if (class17_1 is Class6.Class28)
			{
				this.LksYdldxWw = ((Class6.Class28)class17_1).LksYdldxWw;
				this.class17_0 = ((Class6.Class28)class17_1).class17_0;
				return;
			}
			this.class17_0.vmethod_9(class17_1);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		internal override void vmethod_1(Class6.Class17 class17_1)
		{
			this.vmethod_11(class17_1);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001D198 File Offset: 0x0001B398
		internal override void vmethod_11(Class6.Class17 class17_1)
		{
			this.class17_0 = class17_1;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0001D1AC File Offset: 0x0001B3AC
		internal override object vmethod_3(Type type_0)
		{
			if (this.class17_0 == null)
			{
				return new Class6.Class29(null);
			}
			if (!(type_0 == null) && !(type_0 == typeof(object)))
			{
				return this.class17_0.vmethod_3(type_0);
			}
			return this.class17_0.vmethod_3(this.LksYdldxWw);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001D204 File Offset: 0x0001B404
		internal override Class6.Class17 vmethod_7()
		{
			if (this.class17_0 == null)
			{
				return new Class6.Class29(null);
			}
			return this.class17_0.vmethod_7();
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002F10 File Offset: 0x00001110
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001D22C File Offset: 0x0001B42C
		internal override bool vmethod_4(Class6.Class17 class17_1)
		{
			if (!class17_1.iFavIhWly7())
			{
				return false;
			}
			if (!(class17_1 is Class6.Class28))
			{
				return false;
			}
			Class6.Class28 @class = (Class6.Class28)class17_1;
			if (@class.LksYdldxWw != this.LksYdldxWw)
			{
				return false;
			}
			if (this.class17_0 != null)
			{
				return this.class17_0.vmethod_4(@class.class17_0);
			}
			return @class.class17_0 == null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0001D294 File Offset: 0x0001B494
		internal override bool vmethod_5(Class6.Class17 class17_1)
		{
			if (!class17_1.iFavIhWly7())
			{
				return true;
			}
			if (!(class17_1 is Class6.Class28))
			{
				return true;
			}
			Class6.Class28 @class = (Class6.Class28)class17_1;
			if (@class.LksYdldxWw != this.LksYdldxWw)
			{
				return true;
			}
			if (this.class17_0 != null)
			{
				return this.class17_0.vmethod_5(@class.class17_0);
			}
			return @class.class17_0 != null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002F1D File Offset: 0x0000111D
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x040002FB RID: 763
		private Class6.Class17 class17_0;

		// Token: 0x040002FC RID: 764
		private Type LksYdldxWw;
	}

	// Token: 0x02000066 RID: 102
	internal class Class8
	{
		// Token: 0x040002FD RID: 765
		public int int_0;

		// Token: 0x040002FE RID: 766
		public bool bool_0;

		// Token: 0x040002FF RID: 767
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x02000067 RID: 103
	internal class Class9
	{
		// Token: 0x04000300 RID: 768
		public int int_0;

		// Token: 0x04000301 RID: 769
		public Class6.Enum1 enum1_0;

		// Token: 0x04000302 RID: 770
		public bool bool_0;

		// Token: 0x04000303 RID: 771
		public Type type_0 = typeof(object);
	}

	// Token: 0x02000068 RID: 104
	internal class Class10
	{
		// Token: 0x04000304 RID: 772
		public int int_0;

		// Token: 0x04000305 RID: 773
		public int int_1;

		// Token: 0x04000306 RID: 774
		public Class6.Class11 class11_0;
	}

	// Token: 0x02000069 RID: 105
	internal class Class11
	{
		// Token: 0x04000307 RID: 775
		public int int_0;

		// Token: 0x04000308 RID: 776
		public int int_1;

		// Token: 0x04000309 RID: 777
		public byte byte_0;

		// Token: 0x0400030A RID: 778
		public Type type_0;

		// Token: 0x0400030B RID: 779
		public int int_2;

		// Token: 0x0400030C RID: 780
		public int int_3;
	}

	// Token: 0x0200006A RID: 106
	internal class Class12
	{
		// Token: 0x0400030D RID: 781
		internal object object_0;

		// Token: 0x0400030E RID: 782
		internal List<Class6.Class7> list_0;

		// Token: 0x0400030F RID: 783
		internal Class6.Class8[] class8_0;

		// Token: 0x04000310 RID: 784
		internal List<Class6.Class9> UqaYjxudZI;

		// Token: 0x04000311 RID: 785
		internal List<Class6.Class10> list_1;
	}

	// Token: 0x0200006B RID: 107
	private class Class13
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x0001D324 File Offset: 0x0001B524
		public Class13(FieldInfo fieldInfo_0, int int_1)
		{
			this.object_0 = fieldInfo_0;
			this.int_0 = int_1;
		}

		// Token: 0x04000312 RID: 786
		internal object object_0;

		// Token: 0x04000313 RID: 787
		internal int int_0;
	}

	// Token: 0x0200006C RID: 108
	private class Class14
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x00002F60 File Offset: 0x00001160
		public Class14(MethodBase methodBase_1, List<Class6.Class13> list_1)
		{
			this.list_0 = list_1;
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0001D348 File Offset: 0x0001B548
		public Class14(MethodBase methodBase_1, Class6.Class13[] class13_0)
		{
			this.list_0.AddRange(class13_0);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001D374 File Offset: 0x0001B574
		public override bool Equals(object obj)
		{
			Class6.Class14 @class = obj as Class6.Class14;
			if (obj == null)
			{
				return false;
			}
			if (this.methodBase_0 != @class.methodBase_0)
			{
				return false;
			}
			if (this.list_0.Count != @class.list_0.Count)
			{
				return false;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].object_0 != @class.list_0[i].object_0)
				{
					return false;
				}
				if (this.list_0[i].int_0 != @class.list_0[i].int_0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0001D43C File Offset: 0x0001B63C
		public override int GetHashCode()
		{
			int num = this.methodBase_0.GetHashCode();
			foreach (Class6.Class13 @class in this.list_0)
			{
				int num2 = @class.object_0.GetHashCode() + @class.int_0;
				num = (num ^ num2) + num2;
			}
			return num;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0001D4BC File Offset: 0x0001B6BC
		public Class6.Class13 method_0(int int_0)
		{
			foreach (Class6.Class13 @class in this.list_0)
			{
				if (@class.int_0 == int_0)
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0001D524 File Offset: 0x0001B724
		public bool method_1(int int_0)
		{
			using (List<Class6.Class13>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.int_0 == int_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04000314 RID: 788
		private List<Class6.Class13> list_0 = new List<Class6.Class13>();

		// Token: 0x04000315 RID: 789
		private MethodBase methodBase_0;
	}

	// Token: 0x0200006D RID: 109
	// (Invoke) Token: 0x0600043A RID: 1082
	private delegate object Delegate10(object target, object[] paramters);

	// Token: 0x0200006E RID: 110
	// (Invoke) Token: 0x0600043E RID: 1086
	private delegate object Delegate11(object target);

	// Token: 0x0200006F RID: 111
	// (Invoke) Token: 0x06000442 RID: 1090
	private delegate void Delegate12(IntPtr a, byte b, int c);

	// Token: 0x02000070 RID: 112
	// (Invoke) Token: 0x06000446 RID: 1094
	private delegate void Delegate13(IntPtr s, IntPtr t, uint c);

	// Token: 0x02000071 RID: 113
	internal class Class15
	{
		// Token: 0x06000449 RID: 1097 RVA: 0x0001D588 File Offset: 0x0001B788
		internal void method_0()
		{
			bool flag = false;
			this.method_2(ref flag);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		internal void method_1()
		{
			this.class31_0.method_1();
			this.class17_1 = null;
			if (this.list_0 != null)
			{
				foreach (IntPtr hglobal in this.list_0)
				{
					try
					{
						Marshal.FreeHGlobal(hglobal);
					}
					catch
					{
					}
				}
				this.list_0.Clear();
				this.list_0 = null;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0001D634 File Offset: 0x0001B834
		internal void method_2(ref bool bool_4)
		{
			while (this.int_0 > -2)
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
					int num = this.int_1;
					int num2 = this.int_0;
					this.method_4(this.int_1, this.int_0);
					this.int_0 = num2;
					this.int_1 = num;
				}
				if (this.bool_2)
				{
					this.bool_2 = false;
					return;
				}
				if (!this.bool_1)
				{
					this.int_1 = this.int_0;
					Class6.Class7 @class = this.class12_0.list_0[this.int_0];
					this.object_0 = @class.object_0;
					try
					{
						this.method_7(@class);
					}
					catch (Exception innerException)
					{
						if (innerException is TargetInvocationException)
						{
							TargetInvocationException ex = (TargetInvocationException)innerException;
							if (ex.InnerException != null)
							{
								innerException = ex.InnerException;
							}
						}
						this.exception_0 = innerException;
						bool_4 = true;
						this.class31_0.method_1();
						int int_ = this.int_1;
						Class6.Class10 class2 = this.method_5(int_, innerException);
						List<Class6.Class10> list = this.method_6(int_, false);
						List<Class6.Class10> list2 = new List<Class6.Class10>();
						if (class2 != null)
						{
							list2.Add(class2);
						}
						if (list != null && list.Count > 0)
						{
							list2.AddRange(list);
						}
						list2.Sort(new Comparison<Class6.Class10>(Class6.Class15.Class16.<>9.EaecoUppfe));
						Class6.Class10 class3 = null;
						foreach (Class6.Class10 class4 in list2)
						{
							if (class4.class11_0.int_3 != 0)
							{
								this.class31_0.method_2(new Class6.Class29(innerException));
								this.int_1 = class4.class11_0.int_2;
								this.int_0 = this.int_1;
								this.method_0();
								if (!this.bool_3)
								{
									continue;
								}
								this.bool_3 = false;
								class3 = class4;
							}
							else
							{
								class3 = class4;
							}
							break;
						}
						if (class3 == null)
						{
							throw innerException;
						}
						this.int_2 = class3.class11_0.int_0;
						this.method_3(int_, class3.class11_0.int_0);
						if (this.int_2 >= 0)
						{
							this.class31_0.method_2(new Class6.Class29(innerException));
							this.int_1 = this.int_2;
							this.int_0 = this.int_1;
							this.int_2 = -1;
							this.method_0();
						}
						return;
					}
					this.int_0++;
					continue;
				}
				this.bool_1 = false;
				return;
			}
			this.class31_0.method_1();
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0001D8F4 File Offset: 0x0001BAF4
		internal void method_3(int int_3, int int_4)
		{
			if (this.class12_0.list_1 != null)
			{
				foreach (Class6.Class10 @class in this.class12_0.list_1)
				{
					if ((@class.class11_0.int_3 == 4 || @class.class11_0.int_3 == 2) && @class.class11_0.int_0 >= int_3 && @class.class11_0.int_1 <= int_4)
					{
						this.int_1 = @class.class11_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0001D9C4 File Offset: 0x0001BBC4
		internal void method_4(int int_3, int int_4)
		{
			if (this.class12_0.list_1 != null)
			{
				foreach (Class6.Class10 @class in this.class12_0.list_1)
				{
					if (@class.class11_0.int_3 == 2 && @class.class11_0.int_0 >= int_3 && @class.class11_0.int_1 <= int_4)
					{
						this.int_1 = @class.class11_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001DA84 File Offset: 0x0001BC84
		internal Class6.Class10 method_5(int int_3, Exception exception_1)
		{
			Class6.Class10 @class = null;
			if (this.class12_0.list_1 != null)
			{
				foreach (Class6.Class10 class2 in this.class12_0.list_1)
				{
					if (class2.class11_0 != null && class2.class11_0.int_3 == 0 && (class2.class11_0.type_0 == exception_1.GetType() || (class2.class11_0.type_0 != null && (class2.class11_0.type_0.FullName == exception_1.GetType().FullName || class2.class11_0.type_0.FullName == typeof(object).FullName || class2.class11_0.type_0.FullName == typeof(Exception).FullName))) && int_3 >= class2.int_0 && int_3 <= class2.int_1)
					{
						if (@class != null)
						{
							if (class2.class11_0.int_0 < @class.class11_0.int_0)
							{
								@class = class2;
							}
						}
						else
						{
							@class = class2;
						}
					}
				}
			}
			return @class;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001DBFC File Offset: 0x0001BDFC
		internal List<Class6.Class10> method_6(int int_3, bool bool_4)
		{
			if (this.class12_0.list_1 == null)
			{
				return null;
			}
			List<Class6.Class10> list = new List<Class6.Class10>();
			foreach (Class6.Class10 @class in this.class12_0.list_1)
			{
				if ((@class.class11_0.int_3 & 1) == 1 && int_3 >= @class.int_0 && int_3 <= @class.int_1)
				{
					list.Add(@class);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001DC98 File Offset: 0x0001BE98
		private unsafe void method_7(Class6.Class7 class7_0)
		{
			switch (class7_0.enum3_0)
			{
			case (Class6.Enum3)0:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				object obj = this.class31_0.method_4().vmethod_7().vmethod_3(type);
				Class6.Class17 @class = Class6.Class17.smethod_1(type, obj);
				this.class31_0.method_2(@class);
				return;
			}
			case (Class6.Enum3)1:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_62(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)2:
				return;
			case (Class6.Enum3)3:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_74(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)4:
			case (Class6.Enum3)19:
			case (Class6.Enum3)107:
			case (Class6.Enum3)116:
			case (Class6.Enum3)118:
			case (Class6.Enum3)155:
				throw new Class6.Exception1();
			case (Class6.Enum3)5:
				throw (Exception)this.class31_0.method_4().vmethod_3(null);
			case (Class6.Enum3)6:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_56(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)7:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(ushort), obj));
				return;
			}
			case (Class6.Enum3)8:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_48());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)9:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_36());
				return;
			}
			case (Class6.Enum3)10:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				Class6.Class17 class17_ = this.class31_0.method_4();
				Class6.Class18 class3 = Class6.Class15.smethod_1(class17_);
				if (class3 != null && class2 != null)
				{
					if (class3.vmethod_76(@class))
					{
						this.class31_0.method_2(new Class6.Class19(1));
						return;
					}
					this.class31_0.method_2(new Class6.Class19(0));
					return;
				}
				else
				{
					if (!@class.vmethod_5(class17_))
					{
						this.class31_0.method_2(new Class6.Class19(0));
						return;
					}
					this.class31_0.method_2(new Class6.Class19(1));
					return;
				}
				break;
			}
			case (Class6.Enum3)11:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(uint), obj));
				return;
			}
			case (Class6.Enum3)12:
				this.class31_0.method_2(this.class31_0.method_3());
				return;
			case (Class6.Enum3)13:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_50());
				return;
			}
			case (Class6.Enum3)14:
			{
				object obj = Class6.Class15.object_2;
				lock (obj)
				{
					object obj2 = this.class31_0.method_4().vmethod_3(null);
					Class6.Class17 @class = null;
					if (Class6.Class15.dictionary_1.TryGetValue(obj2, out @class))
					{
						this.class31_0.method_2(@class);
					}
					else
					{
						this.class31_0.method_2(new Class6.Class29(null));
					}
				}
				return;
			}
			case (Class6.Enum3)15:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(double), obj));
				return;
			}
			case (Class6.Enum3)16:
			case (Class6.Enum3)25:
			case (Class6.Enum3)42:
			case (Class6.Enum3)52:
			case (Class6.Enum3)82:
			case (Class6.Enum3)104:
			case (Class6.Enum3)140:
			case (Class6.Enum3)142:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Array array = (Array)this.class31_0.method_4().vmethod_3(null);
				Type type = array.GetType().GetElementType();
				array.SetValue(@class.vmethod_3(type), class2.vmethod_17().struct1_0.int_0);
				return;
			}
			case (Class6.Enum3)17:
				this.bool_2 = true;
				return;
			case (Class6.Enum3)18:
			{
				object obj = Class6.Class15.object_2;
				lock (obj)
				{
					Class6.Class17 @class = this.class31_0.method_4();
					object obj2 = this.class31_0.method_4().vmethod_3(null);
					Class6.Class15.dictionary_1[obj2] = @class;
				}
				return;
			}
			case (Class6.Enum3)20:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class6.Class18)@class).vmethod_21();
				}
				this.class31_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class6.Enum3)21:
			{
				Type type = typeof(Class6).Module.ResolveType((int)this.object_0);
				object obj = this.class31_0.method_4().vmethod_3(type);
				if (obj == null)
				{
					obj = Activator.CreateInstance(type);
				}
				Class6.Class29 class4 = new Class6.Class29(Class6.Class17.smethod_1(type, Class6.Class15.smethod_9(obj)));
				this.class31_0.method_2(class4);
				return;
			}
			case (Class6.Enum3)22:
			{
				IntPtr intPtr = Marshal.AllocHGlobal((this.class31_0.method_4() as Class6.Class18).vmethod_17().struct1_0.int_0);
				if (this.list_0 == null)
				{
					this.list_0 = new List<IntPtr>();
				}
				this.list_0.Add(intPtr);
				this.class31_0.method_2(new Class6.Class21(intPtr));
				return;
			}
			case (Class6.Enum3)23:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_43());
				return;
			}
			case (Class6.Enum3)24:
			{
				Array array2 = (Array)this.class31_0.method_4().vmethod_3(null);
				this.class31_0.method_2(new Class6.Class19(array2.Length, (Class6.Enum1)5));
				return;
			}
			case (Class6.Enum3)26:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_32());
				return;
			}
			case (Class6.Enum3)27:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_47());
				return;
			}
			case (Class6.Enum3)28:
				if (this.class31_0.method_4().vmethod_5(this.class31_0.method_4()))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			case (Class6.Enum3)29:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class6.Class18)@class).vmethod_45();
				}
				this.class31_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class6.Enum3)30:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_60(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)31:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class6.Class18)@class).vmethod_23();
				}
				this.class31_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class6.Enum3)32:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(byte), obj));
				return;
			}
			case (Class6.Enum3)33:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_77(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)34:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class6).Module;
				this.class31_0.method_2(new Class6.Class21(module.ResolveMethod(num).MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class6.Enum3)35:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_24());
				return;
			}
			case (Class6.Enum3)36:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class6.Class18)@class).vmethod_47();
				}
				this.class31_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class6.Enum3)37:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class31_0.method_2(class2.vmethod_67(class3));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)38:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_33());
				return;
			}
			case (Class6.Enum3)39:
				this.class31_0.method_2(new Class6.Class22((double)this.object_0));
				return;
			case (Class6.Enum3)40:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_79(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)41:
			case (Class6.Enum3)47:
			case (Class6.Enum3)53:
			case (Class6.Enum3)91:
			case (Class6.Enum3)97:
			case (Class6.Enum3)174:
				return;
			case (Class6.Enum3)43:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				bool flag2 = Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_80(@class);
				if (flag2)
				{
					this.class31_0.method_2(new Class6.Class19(1));
				}
				else
				{
					this.class31_0.method_2(new Class6.Class19(0));
				}
				if (flag2)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)44:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class6.Class18)@class).vmethod_22();
				}
				this.class31_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class6.Enum3)45:
				this.class31_0.method_2(new Class6.Class22((float)this.object_0));
				return;
			case (Class6.Enum3)46:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_46());
				return;
			}
			case (Class6.Enum3)48:
			{
				Class6.Class18 class2 = this.class31_0.method_4() as Class6.Class18;
				IntPtr intPtr = Class6.Class15.smethod_8(this.class31_0.method_4());
				IntPtr intPtr2 = Class6.Class15.smethod_8(this.class31_0.method_4());
				if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
				{
					uint num2 = class2.vmethod_18().struct1_0.uint_0;
					Class6.Class15.smethod_11(intPtr2, intPtr, num2);
				}
				return;
			}
			case (Class6.Enum3)49:
				this.class31_0.method_2(new Class6.Class20((long)this.object_0));
				return;
			case (Class6.Enum3)50:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_30());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)51:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(sbyte), obj));
				return;
			}
			case (Class6.Enum3)54:
			{
				Class6.Class18 class5 = Class6.Class15.smethod_1(this.class31_0.method_3());
				if (class5 == null)
				{
					throw new ArithmeticException(((Class6.Enum5)0).ToString());
				}
				Class6.Class22 class6 = class5 as Class6.Class22;
				if (class6 != null)
				{
					if (double.IsNaN(class6.double_0))
					{
						throw new OverflowException(((Class6.Enum5)2).ToString());
					}
					if (double.IsInfinity(class6.double_0))
					{
						throw new OverflowException(((Class6.Enum5)1).ToString());
					}
				}
				return;
			}
			case (Class6.Enum3)55:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_65(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)56:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_25());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)57:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Array array3 = (Array)this.class31_0.method_4().vmethod_3(null);
				object obj = array3.GetValue(class2.vmethod_17().struct1_0.int_0);
				Type type = array3.GetType().GetElementType();
				this.class31_0.method_2(Class6.Class17.smethod_1(type, obj));
				return;
			}
			case (Class6.Enum3)58:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_27());
				return;
			}
			case (Class6.Enum3)59:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_21());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)60:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				((Array)this.class31_0.method_4().vmethod_3(null)).SetValue(@class.vmethod_3(type), class2.vmethod_17().struct1_0.int_0);
				return;
			}
			case (Class6.Enum3)61:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				object obj = this.class31_0.method_4().vmethod_3(null);
				this.class31_0.method_2(Class6.Class17.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
				return;
			}
			case (Class6.Enum3)62:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				Class6.Class17 class7 = this.class31_0.method_4();
				class7.vmethod_7();
				object obj = class7.vmethod_3(null);
				this.class31_0.method_2(new Class6.Class26(fieldInfo, obj));
				return;
			}
			case (Class6.Enum3)63:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class31_0.method_2(class2.vmethod_66(class3));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)64:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(int), obj));
				return;
			}
			case (Class6.Enum3)65:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.zLqpmHyYrP());
				return;
			}
			case (Class6.Enum3)66:
			{
				Class6.Class17 @class = this.class17_1[(int)this.object_0];
				this.class31_0.method_2(@class);
				return;
			}
			case (Class6.Enum3)67:
			{
				if (Class6.list_0.Count != 0)
				{
					this.class31_0.method_2(new Class6.Class30(Class6.list_0[(int)this.object_0]));
					return;
				}
				Module module = typeof(Class6).Module;
				this.class31_0.method_2(new Class6.Class30(module.ResolveString((int)this.object_0 | 1879048192)));
				return;
			}
			case (Class6.Enum3)68:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_64(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)69:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(IntPtr), obj));
				return;
			}
			case (Class6.Enum3)70:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (!Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_75(@class))
				{
					this.class31_0.method_2(new Class6.Class19(0));
					return;
				}
				this.class31_0.method_2(new Class6.Class19(1));
				return;
			}
			case (Class6.Enum3)71:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_37());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)72:
			{
				int num = (int)this.object_0;
				typeof(Class6).Module.ResolveType(num);
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Array array2 = (Array)this.class31_0.method_4().vmethod_3(null);
				this.class31_0.method_2(new Class6.Class25(class2.vmethod_17().struct1_0.int_0, array2));
				return;
			}
			case (Class6.Enum3)73:
			case (Class6.Enum3)121:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class17 @class = this.class31_0.method_4();
				object obj = @class.vmethod_3(type);
				if (obj == null)
				{
					if (!type.IsValueType)
					{
						@class = new Class6.Class29(null);
					}
					else
					{
						obj = Activator.CreateInstance(type);
						@class = Class6.Class17.smethod_1(type, obj);
					}
				}
				else
				{
					if (type.IsValueType)
					{
						obj = Class6.Class15.smethod_9(obj);
					}
					@class = Class6.Class17.smethod_1(type, obj);
				}
				Class6.Class23 class8 = this.class31_0.method_4() as Class6.Class23;
				if (class8 == null)
				{
					throw new Class6.Exception1();
				}
				class8.vmethod_9(@class);
				return;
			}
			case (Class6.Enum3)74:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class31_0.method_2(class2.igEvpBpxrl(class3));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)75:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class17 @class = this.class31_0.method_4();
				object obj = @class.vmethod_3(null);
				if (obj == null)
				{
					this.class31_0.method_2(new Class6.Class29(null));
					return;
				}
				if (!type.IsAssignableFrom(obj.GetType()))
				{
					this.class31_0.method_2(new Class6.Class29(null));
					return;
				}
				this.class31_0.method_2(@class);
				return;
			}
			case (Class6.Enum3)76:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_45());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_7();
					this.class31_0.method_2(new Class6.Class22(*(float*)((void*)intPtr), (Class6.Enum1)9));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)77:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_23());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_7();
					this.class31_0.method_2(new Class6.Class19(*(int*)((void*)intPtr), (Class6.Enum1)5));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)78:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_41());
				return;
			}
			case (Class6.Enum3)79:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_24());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_7();
					this.class31_0.method_2(new Class6.Class20(*(long*)((void*)intPtr), (Class6.Enum1)7));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)80:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_45());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)81:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(float), obj));
				return;
			}
			case (Class6.Enum3)83:
				this.bool_3 = (bool)this.class31_0.method_4().vmethod_3(typeof(bool));
				this.bool_1 = true;
				return;
			case (Class6.Enum3)84:
				this.int_0 = (int)this.object_0 - 1;
				return;
			case (Class6.Enum3)85:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_29());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)86:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = (Class6.Class18)this.class31_0.method_4();
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_57(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)87:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_42());
				return;
			}
			case (Class6.Enum3)88:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_71(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)89:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_55(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)90:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_40());
				return;
			}
			case (Class6.Enum3)92:
				throw this.exception_0;
			case (Class6.Enum3)93:
			{
				Class6.Class18 class2 = this.class31_0.method_4() as Class6.Class18;
				Class6.Class18 class3 = this.class31_0.method_4() as Class6.Class18;
				IntPtr intPtr = Class6.Class15.smethod_8(this.class31_0.method_4());
				if (intPtr != IntPtr.Zero)
				{
					byte byte_ = class3.vmethod_14().struct1_0.byte_0;
					uint num2 = class2.vmethod_18().struct1_0.uint_0;
					Class6.Class15.smethod_10(intPtr, byte_, (int)num2);
				}
				return;
			}
			case (Class6.Enum3)94:
				this.method_12(false);
				return;
			case (Class6.Enum3)95:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_26());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_7();
					this.class31_0.method_2(new Class6.Class19((int)(*(ushort*)((void*)intPtr)), (Class6.Enum1)4));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)96:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_59(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)98:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (!Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_79(@class))
				{
					this.class31_0.method_2(new Class6.Class19(0));
					return;
				}
				this.class31_0.method_2(new Class6.Class19(1));
				return;
			}
			case (Class6.Enum3)99:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.iFavIhWly7())
				{
					object obj = @class.vmethod_3(null);
					if (obj == null)
					{
						@class = new Class6.Class29(null);
					}
					else
					{
						@class = Class6.Class17.smethod_1(obj.GetType(), obj);
					}
					this.class31_0.method_2(@class);
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)100:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_22());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)101:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class23 class9 = this.class31_0.method_4() as Class6.Class23;
				if (class9 == null)
				{
					throw new Class6.Exception1();
				}
				if (!type.IsValueType)
				{
					class9.vmethod_11(new Class6.Class29(null));
					return;
				}
				object obj = Activator.CreateInstance(type);
				class9.vmethod_11(Class6.Class17.smethod_1(type, obj));
				return;
			}
			case (Class6.Enum3)102:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_39());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)103:
			{
				int num = (int)this.object_0;
				if (!this.class12_0.object_0.IsStatic)
				{
					this.class17_0[num] = this.method_8(this.class31_0.method_4(), this.class12_0.class8_0[num - 1].enum1_0, false);
					return;
				}
				this.class17_0[num] = this.method_8(this.class31_0.method_4(), this.class12_0.class8_0[num].enum1_0, false);
				return;
			}
			case (Class6.Enum3)105:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				this.class31_0.method_2(new Class6.Class26(fieldInfo, null));
				return;
			}
			case (Class6.Enum3)106:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_22());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_7();
					this.class31_0.method_2(new Class6.Class19((int)(*(short*)((void*)intPtr)), (Class6.Enum1)3));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)108:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_49());
				return;
			}
			case (Class6.Enum3)109:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class6.Class18)@class).vmethod_24();
				}
				this.class31_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class6.Enum3)110:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_51());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)111:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				Class6.Class17 class17_ = this.class31_0.method_4();
				Class6.Class18 class3 = Class6.Class15.smethod_1(class17_);
				if (class3 != null && class2 != null)
				{
					if (class3.vmethod_76(@class))
					{
						this.int_0 = (int)this.object_0 - 1;
					}
					return;
				}
				if (@class.vmethod_5(class17_))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)112:
				this.class31_0.method_2(new Class6.Class24((int)this.object_0, this));
				return;
			case (Class6.Enum3)113:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				this.class31_0.method_2(Class6.Class17.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(null)));
				return;
			}
			case (Class6.Enum3)114:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_61(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)115:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_54(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)117:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_26());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)119:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				object obj = this.class31_0.method_4().vmethod_3(fieldInfo.FieldType);
				Class6.Class17 @class = this.class31_0.method_4();
				object obj2 = @class.vmethod_3(null);
				if (obj2 == null)
				{
					Type type = fieldInfo.DeclaringType;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					if (!type.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type);
					if (@class is Class6.Class24)
					{
						((Class6.Class23)@class).vmethod_11(Class6.Class17.smethod_1(type, obj2));
					}
				}
				fieldInfo.SetValue(obj2, obj);
				return;
			}
			case (Class6.Enum3)120:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class6).Module;
				object obj = null;
				try
				{
					obj = module.ResolveType(num);
				}
				catch
				{
					try
					{
						obj = module.ResolveMethod(num);
					}
					catch
					{
						try
						{
							obj = module.ResolveField(num);
						}
						catch
						{
							obj = module.ResolveMember(num);
						}
					}
				}
				this.class31_0.method_2(new Class6.Class29(obj));
				return;
			}
			case (Class6.Enum3)122:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class23 class10 = this.class31_0.method_4() as Class6.Class23;
				if (class10 == null)
				{
					throw new Class6.Exception1();
				}
				object obj = class10.vmethod_3(type);
				Class6.Class17 @class;
				if (obj == null)
				{
					if (type.IsValueType)
					{
						obj = Activator.CreateInstance(type);
						@class = Class6.Class17.smethod_1(type, obj);
					}
					else
					{
						@class = new Class6.Class29(null);
					}
				}
				else
				{
					if (type.IsValueType)
					{
						obj = Class6.Class15.smethod_9(obj);
					}
					@class = Class6.Class17.smethod_1(type, obj);
				}
				this.class31_0.method_2(@class);
				return;
			}
			case (Class6.Enum3)123:
				this.class31_0.method_2(((Class6.Class18)this.class31_0.method_4()).vmethod_53());
				return;
			case (Class6.Enum3)124:
			{
				bool flag = false;
				Class6.Class17 @class = this.class31_0.method_4();
				flag = (@class == null || !@class.vmethod_6());
				if (flag)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)125:
				this.method_12(true);
				return;
			case (Class6.Enum3)126:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_58(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)127:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (!Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_80(@class))
				{
					this.class31_0.method_2(new Class6.Class19(0));
					return;
				}
				this.class31_0.method_2(new Class6.Class19(1));
				return;
			}
			case (Class6.Enum3)128:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_70(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)129:
				this.int_0 = -3;
				if (this.class31_0.method_0() > 0)
				{
					this.class17_2 = this.class31_0.method_4();
				}
				return;
			case (Class6.Enum3)130:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				this.class31_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class6.Enum3)131:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_72(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)132:
				this.class31_0.method_2(new Class6.Class19((int)this.object_0));
				return;
			case (Class6.Enum3)133:
				this.class31_0.method_2(this.class31_0.method_4().vmethod_7());
				return;
			case (Class6.Enum3)134:
			{
				int num = (int)this.object_0;
				this.class17_1[num] = this.method_8(this.class31_0.method_4(), this.class12_0.UqaYjxudZI[num].enum1_0, this.class12_0.UqaYjxudZI[num].bool_0);
				return;
			}
			case (Class6.Enum3)135:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.Add(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)136:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(short), obj));
				return;
			}
			case (Class6.Enum3)137:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_68());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)138:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_27());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_7();
					this.class31_0.method_2(new Class6.Class19(*(uint*)((void*)intPtr), (Class6.Enum1)6));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)139:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_28());
				return;
			}
			case (Class6.Enum3)141:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class6.Class18)@class).vmethod_46();
				}
				this.class31_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class6.Enum3)143:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(long), obj));
				return;
			}
			case (Class6.Enum3)144:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_46());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_7();
					this.class31_0.method_2(new Class6.Class22(*(double*)((void*)intPtr), (Class6.Enum1)10));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)145:
				this.class31_0.method_4();
				return;
			case (Class6.Enum3)146:
			{
				int num = (int)this.object_0;
				Type elementType = typeof(Class6).Module.ResolveType(num);
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Array array2 = Array.CreateInstance(elementType, class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(new Class6.Class29(array2));
				return;
			}
			case (Class6.Enum3)147:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_38());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)148:
				this.class31_0.method_2(this.class17_0[(int)this.object_0]);
				return;
			case (Class6.Enum3)149:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_35());
				return;
			}
			case (Class6.Enum3)150:
			{
				int[] array4 = (int[])this.object_0;
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				long num3 = class2.vmethod_19().struct2_0.long_0;
				if ((num3 < 0L || class2.method_4()) && IntPtr.Size == 4)
				{
					num3 = (long)((int)num3);
				}
				if (class2.method_1())
				{
					Class6.Class19 class11 = (Class6.Class19)class2;
					if (class11.enum1_0 == (Class6.Enum1)6)
					{
						num3 = (long)((ulong)class11.struct1_0.uint_0);
					}
				}
				if (num3 < (long)array4.Length && num3 >= 0L)
				{
					this.int_0 = array4[(int)(checked((IntPtr)num3))] - 1;
				}
				return;
			}
			case (Class6.Enum3)151:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_47());
					return;
				}
				if (class2 == null || !class2.method_2())
				{
					throw new Class6.Exception1();
				}
				IntPtr intPtr = ((Class6.Class21)class2).method_7();
				if (IntPtr.Size == 8)
				{
					long num3 = *(long*)((void*)intPtr);
					this.class31_0.method_2(new Class6.Class21(num3, (Class6.Enum1)12));
					return;
				}
				int num = *(int*)((void*)intPtr);
				this.class31_0.method_2(new Class6.Class21((long)num, (Class6.Enum1)12));
				return;
			}
			case (Class6.Enum3)152:
			{
				int num = (int)this.object_0;
				MethodBase methodBase = typeof(Class6).Module.ResolveMethod(num);
				Type type = this.class31_0.method_4().vmethod_3(null).GetType();
				List<Type> list = new List<Type>();
				do
				{
					list.Add(type);
					type = type.BaseType;
				}
				while (type != null && type != methodBase.DeclaringType);
				list.Reverse();
				MethodBase methodBase2 = methodBase;
				foreach (Type type2 in list)
				{
					foreach (MethodInfo methodInfo in type2.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
					{
						if (methodInfo.GetBaseDefinition() == methodBase2)
						{
							methodBase2 = methodInfo;
							break;
						}
					}
				}
				this.class31_0.method_2(new Class6.Class21(methodBase2.MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class6.Enum3)153:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_73(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)154:
				this.class31_0.method_2(new Class6.Class29(null));
				return;
			case (Class6.Enum3)156:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				object obj = this.class31_0.method_4().vmethod_3(fieldInfo.FieldType);
				fieldInfo.SetValue(null, obj);
				return;
			}
			case (Class6.Enum3)157:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(type, obj));
				return;
			}
			case (Class6.Enum3)158:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_23());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)159:
			{
				int num = (int)this.object_0;
				uint num2 = (uint)Class6.Class15.smethod_0(typeof(Class6).Module.ResolveType(num));
				this.class31_0.method_2(new Class6.Class19(num2, (Class6.Enum1)6));
				return;
			}
			case (Class6.Enum3)160:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_78(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)161:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class3 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class31_0.method_2(class3.vmethod_63(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)162:
				this.class31_0.method_2(new Class6.Class27((int)this.object_0, this));
				return;
			case (Class6.Enum3)163:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_75(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)164:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_44());
				return;
			}
			case (Class6.Enum3)165:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_21());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_7();
					this.class31_0.method_2(new Class6.Class19((int)(*(sbyte*)((void*)intPtr)), (Class6.Enum1)1));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)166:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_52());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)167:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_25());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_7();
					this.class31_0.method_2(new Class6.Class19((int)(*(byte*)((void*)intPtr)), (Class6.Enum1)2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)168:
			{
				int num = (int)this.object_0;
				ConstructorInfo constructorInfo = (ConstructorInfo)typeof(Class6).Module.ResolveMethod(num);
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				object[] array5 = new object[parameters.Length];
				Class6.Class17[] array6 = new Class6.Class17[parameters.Length];
				List<Class6.Class13> list2 = null;
				Class6.Class14 class12 = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					Class6.Class17 @class = this.class31_0.method_4();
					Type type = parameters[parameters.Length - 1 - i].ParameterType;
					object obj2 = null;
					bool flag = false;
					if (type.IsByRef)
					{
						Class6.Class26 class13 = @class as Class6.Class26;
						if (class13 != null)
						{
							if (list2 == null)
							{
								list2 = new List<Class6.Class13>();
							}
							list2.Add(new Class6.Class13(class13.fieldInfo_0, parameters.Length - 1 - i));
							obj2 = class13.object_0;
							if (!(obj2 is Class6.Class17))
							{
								flag = true;
							}
							else
							{
								@class = (obj2 as Class6.Class17);
							}
						}
					}
					if (!flag)
					{
						if (@class != null)
						{
							obj2 = @class.vmethod_3(type);
						}
						if (obj2 == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj2 = Activator.CreateInstance(type);
								if (@class is Class6.Class24)
								{
									((Class6.Class23)@class).vmethod_11(Class6.Class17.smethod_1(type, obj2));
								}
							}
						}
					}
					array6[array5.Length - 1 - i] = @class;
					array5[array5.Length - 1 - i] = obj2;
				}
				Class6.Delegate10 @delegate = null;
				if (list2 != null)
				{
					class12 = new Class6.Class14(constructorInfo, list2);
					@delegate = Class6.Class15.smethod_4(constructorInfo, true, class12);
				}
				object obj = null;
				if (@delegate != null)
				{
					obj = @delegate(null, array5);
				}
				else
				{
					obj = constructorInfo.Invoke(array5);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (class12 == null || !class12.method_1(j)))
					{
						if (!array6[j].method_2())
						{
							if (array6[j] is Class6.Class24)
							{
								array6[j].vmethod_9(Class6.Class17.smethod_1(parameters[j].ParameterType.GetElementType(), array5[j]));
							}
							else
							{
								array6[j].vmethod_9(Class6.Class17.smethod_1(parameters[j].ParameterType, array5[j]));
							}
						}
						else
						{
							((Class6.Class21)array6[j]).method_6(Class6.Class17.smethod_1(parameters[j].ParameterType, array5[j]));
						}
					}
				}
				this.class31_0.method_2(Class6.Class17.smethod_1(constructorInfo.DeclaringType, obj));
				return;
			}
			case (Class6.Enum3)169:
				this.int_0 = (int)this.object_0 - 1;
				this.bool_0 = true;
				return;
			case (Class6.Enum3)170:
			{
				Class6.Class17 class14 = Class6.Class15.smethod_6(this.class31_0.method_4());
				Class6.Class17 @class = Class6.Class15.smethod_6(this.class31_0.method_4());
				if (class14.vmethod_4(@class))
				{
					this.class31_0.method_2(new Class6.Class19(1));
					return;
				}
				this.class31_0.method_2(new Class6.Class19(0));
				return;
			}
			case (Class6.Enum3)171:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_34());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)172:
			{
				Class6.Class17 class15 = this.class31_0.method_4();
				Class6.Class17 @class = this.class31_0.method_4();
				if (class15.vmethod_4(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)173:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_31());
				return;
			}
			case (Class6.Enum3)175:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class != null && @class.vmethod_6())
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00020D20 File Offset: 0x0001EF20
		private Class6.Class17 method_8(Class6.Class17 class17_3, Class6.Enum1 enum1_0, bool bool_4 = false)
		{
			if (!bool_4 && class17_3.iFavIhWly7())
			{
				class17_3 = class17_3.vmethod_7();
			}
			if (class17_3.method_1())
			{
				return ((Class6.Class19)class17_3).vmethod_11(enum1_0);
			}
			if (class17_3.method_3())
			{
				return ((Class6.Class20)class17_3).vmethod_11(enum1_0);
			}
			if (class17_3.method_4())
			{
				return ((Class6.Class22)class17_3).vmethod_11(enum1_0);
			}
			if (class17_3.method_2())
			{
				return ((Class6.Class21)class17_3).vmethod_11(enum1_0);
			}
			return class17_3;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00002F83 File Offset: 0x00001183
		private Class6.Class17 method_9(int int_3)
		{
			return this.class17_1[int_3];
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00020D98 File Offset: 0x0001EF98
		private void method_10(int int_3)
		{
			this.method_11(int_3, this.class31_0.method_4());
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00020DB8 File Offset: 0x0001EFB8
		private static int smethod_0(Type type_0)
		{
			object obj = Class6.Class15.object_1;
			int result;
			lock (obj)
			{
				if (Class6.Class15.dictionary_0 == null)
				{
					Class6.Class15.dictionary_0 = new Dictionary<Type, int>();
				}
				try
				{
					int num = 0;
					if (Class6.Class15.dictionary_0.TryGetValue(type_0, out num))
					{
						result = num;
					}
					else
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Sizeof, type_0);
						ilgenerator.Emit(OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						Class6.Class15.dictionary_0[type_0] = num;
						result = num;
					}
				}
				catch
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00020E8C File Offset: 0x0001F08C
		private void method_11(int int_3, Class6.Class17 class17_3)
		{
			this.class17_1[int_3] = this.method_8(class17_3, this.class12_0.UqaYjxudZI[int_3].enum1_0, this.class12_0.UqaYjxudZI[int_3].bool_0);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0001971C File Offset: 0x0001791C
		private static Class6.Class18 smethod_1(Class6.Class17 class17_3)
		{
			Class6.Class18 @class = class17_3 as Class6.Class18;
			if (@class == null && class17_3.iFavIhWly7())
			{
				@class = (class17_3.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00020ED4 File Offset: 0x0001F0D4
		private void method_12(bool bool_4)
		{
			int metadataToken = (int)this.object_0;
			MethodBase methodBase = typeof(Class6).Module.ResolveMethod(metadataToken);
			MethodInfo methodInfo = methodBase as MethodInfo;
			ParameterInfo[] parameters = methodBase.GetParameters();
			object[] array = new object[parameters.Length];
			Class6.Class17[] array2 = new Class6.Class17[parameters.Length];
			List<Class6.Class13> list = null;
			Class6.Class14 @class = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				Class6.Class17 class2 = this.class31_0.method_4();
				Type type = parameters[parameters.Length - 1 - i].ParameterType;
				object obj = null;
				bool flag = false;
				if (type.IsByRef)
				{
					Class6.Class26 class3 = class2 as Class6.Class26;
					if (class3 != null)
					{
						if (list == null)
						{
							list = new List<Class6.Class13>();
						}
						list.Add(new Class6.Class13(class3.fieldInfo_0, parameters.Length - 1 - i));
						obj = class3.object_0;
						if (obj is Class6.Class17)
						{
							class2 = (obj as Class6.Class17);
						}
						else
						{
							flag = true;
							if (obj == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									if (!class3.fieldInfo_0.IsStatic)
									{
										obj = Activator.CreateInstance(type);
									}
									else
									{
										obj = class3.fieldInfo_0.GetValue(null);
									}
									if (class2 is Class6.Class24)
									{
										((Class6.Class23)class2).vmethod_11(Class6.Class17.smethod_1(type, obj));
									}
								}
							}
						}
					}
				}
				if (!flag)
				{
					if (class2 != null)
					{
						obj = class2.vmethod_3(type);
					}
					if (obj == null)
					{
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (type.IsValueType)
						{
							obj = Activator.CreateInstance(type);
							if (class2 is Class6.Class24)
							{
								((Class6.Class23)class2).vmethod_11(Class6.Class17.smethod_1(type, obj));
							}
						}
					}
				}
				array2[array.Length - 1 - i] = class2;
				array[array.Length - 1 - i] = obj;
			}
			Class6.Delegate10 @delegate = null;
			if (list != null)
			{
				@class = new Class6.Class14(methodBase, list);
				@delegate = Class6.Class15.smethod_3(methodBase, bool_4, @class);
			}
			else if (methodInfo != null && methodInfo.ReturnType.IsByRef)
			{
				@delegate = Class6.Class15.smethod_2(methodBase, bool_4);
			}
			object obj2 = null;
			Class6.Class17 class4 = null;
			if (!methodBase.IsStatic)
			{
				class4 = this.class31_0.method_4();
				if (class4 != null)
				{
					obj2 = class4.vmethod_3(methodBase.DeclaringType);
				}
				if (obj2 == null)
				{
					Type type2 = methodBase.DeclaringType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
					}
					if (!type2.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type2);
					if (obj2 == null && Nullable.GetUnderlyingType(type2) != null)
					{
						obj2 = FormatterServices.GetUninitializedObject(type2);
					}
					if (class4 is Class6.Class24)
					{
						((Class6.Class23)class4).vmethod_11(Class6.Class17.smethod_1(type2, obj2));
					}
				}
			}
			object obj3;
			if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
			{
				obj3 = array[0];
				if (class4 != null && class4 is Class6.Class24)
				{
					((Class6.Class23)class4).vmethod_11(Class6.Class17.smethod_1(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
				}
			}
			else if (@delegate == null)
			{
				obj3 = methodBase.Invoke(obj2, array);
			}
			else
			{
				obj3 = @delegate(obj2, array);
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef && (@class == null || !@class.method_1(j)))
				{
					if (array2[j].method_2())
					{
						((Class6.Class21)array2[j]).method_6(Class6.Class17.smethod_1(parameters[j].ParameterType, array[j]));
					}
					else if (array2[j] is Class6.Class24)
					{
						array2[j].vmethod_9(Class6.Class17.smethod_1(parameters[j].ParameterType.GetElementType(), array[j]));
					}
					else
					{
						array2[j].vmethod_9(Class6.Class17.smethod_1(parameters[j].ParameterType, array[j]));
					}
				}
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				this.class31_0.method_2(Class6.Class17.smethod_1(methodInfo.ReturnType, obj3));
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00021308 File Offset: 0x0001F508
		private static Class6.Delegate10 smethod_2(object object_6, bool bool_4)
		{
			object obj = Class6.Class15.object_3;
			Class6.Delegate10 result2;
			lock (obj)
			{
				Class6.Delegate10 result = null;
				if (!bool_4)
				{
					if (Class6.Class15.dictionary_3.TryGetValue(object_6, out result))
					{
						return result;
					}
				}
				else if (Class6.Class15.dictionary_2.TryGetValue(object_6, out result))
				{
					return result;
				}
				MethodInfo methodInfo = object_6 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = object_6.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (object_6.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (object_6.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_6.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class6.Class15.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!array[k].IsValueType)
					{
						if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!object_6.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (object_6.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, object_6.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, object_6.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, object_6 as ConstructorInfo);
					}
				}
				else if (!(methodInfo != null))
				{
					ilgenerator.Emit(OpCodes.Callvirt, object_6 as ConstructorInfo);
				}
				else
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (!methodInfo.ReturnType.IsByRef)
					{
						if (methodInfo.ReturnType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
						}
					}
					else
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class6.Class15.smethod_5(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class6.Delegate10 @delegate = (Class6.Delegate10)dynamicMethod.CreateDelegate(typeof(Class6.Delegate10));
				if (!bool_4)
				{
					Class6.Class15.dictionary_3.Add(object_6, @delegate);
				}
				else
				{
					Class6.Class15.dictionary_2.Add(object_6, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000217B8 File Offset: 0x0001F9B8
		private static Class6.Delegate10 smethod_3(object object_6, bool bool_4, Class6.Class14 class14_0)
		{
			object obj = Class6.Class15.ivacpLcqOn;
			Class6.Delegate10 result2;
			lock (obj)
			{
				Class6.Delegate10 result = null;
				if (!bool_4)
				{
					if (Class6.Class15.dictionary_5.TryGetValue(class14_0, out result))
					{
						return result;
					}
				}
				else if (Class6.Class15.dictionary_4.TryGetValue(class14_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = object_6 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(Class6), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = object_6.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (object_6.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (!class14_0.method_1(j))
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
				}
				if (object_6.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_6.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class6.Class15.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!class14_0.method_1(k))
					{
						if (array[k].IsValueType)
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
						else if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!object_6.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (object_6.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, object_6.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, object_6.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (class14_0.method_1(l))
					{
						Class6.Class13 @class = class14_0.method_0(l);
						if (!@class.object_0.IsStatic)
						{
							if (!@class.object_0.DeclaringType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Castclass, @class.object_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Unbox, @class.object_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldsflda, @class.object_0);
						}
					}
					else if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (bool_4)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(OpCodes.Call, object_6 as ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
				}
				else if (!(methodInfo != null))
				{
					ilgenerator.Emit(OpCodes.Callvirt, object_6 as ConstructorInfo);
				}
				else
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (class14_0.method_1(m))
						{
							Class6.Class13 class2 = class14_0.method_0(m);
							if (class2.object_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class6.Class15.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, class2.object_0);
								if (class2.object_0.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.object_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class6.Class15.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.object_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							Class6.Class15.smethod_5(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class6.Delegate10 @delegate = (Class6.Delegate10)dynamicMethod.CreateDelegate(typeof(Class6.Delegate10));
				if (bool_4)
				{
					Class6.Class15.dictionary_4.Add(class14_0, @delegate);
				}
				else
				{
					Class6.Class15.dictionary_5.Add(class14_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00021E64 File Offset: 0x00020064
		private static Class6.Delegate10 smethod_4(object object_6, bool bool_4, Class6.Class14 class14_0)
		{
			object obj = Class6.Class15.object_4;
			Class6.Delegate10 result;
			lock (obj)
			{
				Class6.Delegate10 @delegate = null;
				if (!Class6.Class15.dictionary_6.TryGetValue(class14_0, out @delegate))
				{
					ConstructorInfo constructorInfo = object_6 as ConstructorInfo;
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
					{
						typeof(object),
						typeof(object[])
					}, typeof(Class6), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ParameterInfo[] parameters = object_6.GetParameters();
					Type[] array = new Type[parameters.Length];
					for (int i = 0; i < array.Length; i++)
					{
						if (parameters[i].ParameterType.IsByRef)
						{
							array[i] = parameters[i].ParameterType.GetElementType();
						}
						else
						{
							array[i] = parameters[i].ParameterType;
						}
					}
					int num = array.Length;
					if (object_6.DeclaringType.IsValueType)
					{
						num++;
					}
					LocalBuilder[] array2 = new LocalBuilder[num];
					for (int j = 0; j < array.Length; j++)
					{
						if (class14_0.method_1(j))
						{
							array2[j] = ilgenerator.DeclareLocal(typeof(object));
						}
						else
						{
							array2[j] = ilgenerator.DeclareLocal(array[j]);
						}
					}
					if (object_6.DeclaringType.IsValueType)
					{
						array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_6.DeclaringType.MakeByRefType());
					}
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class6.Class15.smethod_5(ilgenerator, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						if (!class14_0.method_1(k))
						{
							if (array[k].IsValueType)
							{
								ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
							}
							else if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						ilgenerator.Emit(OpCodes.Stloc, array2[k]);
					}
					for (int l = 0; l < array.Length; l++)
					{
						if (class14_0.method_1(l))
						{
							Class6.Class13 @class = class14_0.method_0(l);
							if (!@class.object_0.IsStatic)
							{
								if (!@class.object_0.DeclaringType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Castclass, @class.object_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Unbox, @class.object_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
								}
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldsflda, @class.object_0);
							}
						}
						else if (!parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
						}
					}
					ilgenerator.Emit(OpCodes.Newobj, object_6 as ConstructorInfo);
					if (constructorInfo.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
					}
					for (int m = 0; m < array.Length; m++)
					{
						if (parameters[m].ParameterType.IsByRef)
						{
							if (!class14_0.method_1(m))
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class6.Class15.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								Class6.Class13 class2 = class14_0.method_0(m);
								if (class2.object_0.IsStatic)
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class6.Class15.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldsfld, class2.object_0);
									if (class2.object_0.FieldType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class6.Class15.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
									if (array2[m].LocalType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
							}
						}
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class6.Delegate10 delegate2 = (Class6.Delegate10)dynamicMethod.CreateDelegate(typeof(Class6.Delegate10));
					Class6.Class15.dictionary_6.Add(class14_0, delegate2);
					result = delegate2;
				}
				else
				{
					result = @delegate;
				}
			}
			return result;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00022390 File Offset: 0x00020590
		private static void smethod_5(ILGenerator ilgenerator_0, int int_3)
		{
			switch (int_3)
			{
			case -1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				if (int_3 > -129 && int_3 < 128)
				{
					ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_3);
					return;
				}
				ilgenerator_0.Emit(OpCodes.Ldc_I4, int_3);
				return;
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00022470 File Offset: 0x00020670
		private static Class6.Class17 smethod_6(Class6.Class17 class17_3)
		{
			if (class17_3.vmethod_7().method_0())
			{
				object obj = class17_3.vmethod_3(null);
				if (obj != null && obj.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					object obj2 = Convert.ChangeType(obj, underlyingType);
					Class6.Class17 @class = Class6.Class15.smethod_7(Class6.Class17.smethod_1(underlyingType, obj2));
					if (@class != null)
					{
						return @class as Class6.Class18;
					}
				}
			}
			return class17_3;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000185C4 File Offset: 0x000167C4
		private static Class6.Class18 smethod_7(Class6.Class17 class17_3)
		{
			Class6.Class18 @class = class17_3 as Class6.Class18;
			if (@class == null && class17_3.iFavIhWly7())
			{
				@class = (class17_3.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000224DC File Offset: 0x000206DC
		private static IntPtr smethod_8(object object_6)
		{
			if (object_6 == null)
			{
				return IntPtr.Zero;
			}
			if (object_6.method_2())
			{
				return ((Class6.Class21)object_6).method_7();
			}
			if (object_6.iFavIhWly7())
			{
				Class6.Class23 @class = (Class6.Class23)object_6;
				IntPtr result;
				try
				{
					result = @class.vmethod_10();
				}
				catch
				{
					goto IL_32;
				}
				return result;
			}
			IL_32:
			object obj = object_6.vmethod_3(typeof(IntPtr));
			if (obj != null && obj.GetType() == typeof(IntPtr))
			{
				return (IntPtr)obj;
			}
			throw new Class6.Exception1();
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00022574 File Offset: 0x00020774
		private static object smethod_9(object object_6)
		{
			object obj = Class6.Class15.object_5;
			object result;
			lock (obj)
			{
				if (Class6.Class15.dictionary_7 == null)
				{
					Class6.Class15.dictionary_7 = new Dictionary<Type, Class6.Delegate11>();
				}
				if (object_6 != null)
				{
					try
					{
						Type type = object_6.GetType();
						Class6.Delegate11 @delegate;
						if (Class6.Class15.dictionary_7.TryGetValue(type, out @delegate))
						{
							return @delegate(object_6);
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
						{
							typeof(object)
						}, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Ldarg_0);
						ilgenerator.Emit(OpCodes.Unbox_Any, type);
						ilgenerator.Emit(OpCodes.Box, type);
						ilgenerator.Emit(OpCodes.Ret);
						Class6.Delegate11 delegate2 = (Class6.Delegate11)dynamicMethod.CreateDelegate(typeof(Class6.Delegate11));
						Class6.Class15.dictionary_7.Add(type, delegate2);
						return delegate2(object_6);
					}
					catch
					{
						return null;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00022698 File Offset: 0x00020898
		private static void smethod_10(IntPtr intptr_0, byte byte_0, int int_3)
		{
			object obj = Class6.Class15.object_5;
			lock (obj)
			{
				if (Class6.Class15.wRecHpubLl == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(Class6), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Initblk);
					ilgenerator.Emit(OpCodes.Ret);
					Class6.Class15.wRecHpubLl = (Class6.Delegate12)dynamicMethod.CreateDelegate(typeof(Class6.Delegate12));
				}
				Class6.Class15.wRecHpubLl(intptr_0, byte_0, int_3);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00022790 File Offset: 0x00020990
		private static void smethod_11(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			if (Class6.Class15.delegate13_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(uint)
				}, typeof(Class6), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldarg_1);
				ilgenerator.Emit(OpCodes.Ldarg_2);
				ilgenerator.Emit(OpCodes.Cpblk);
				ilgenerator.Emit(OpCodes.Ret);
				Class6.Class15.delegate13_0 = (Class6.Delegate13)dynamicMethod.CreateDelegate(typeof(Class6.Delegate13));
			}
			Class6.Class15.delegate13_0(intptr_0, intptr_1, uint_0);
		}

		// Token: 0x04000316 RID: 790
		internal Class6.Class12 class12_0;

		// Token: 0x04000317 RID: 791
		internal Class6.Class17[] class17_0 = new Class6.Class17[0];

		// Token: 0x04000318 RID: 792
		internal Class6.Class17[] class17_1 = new Class6.Class17[0];

		// Token: 0x04000319 RID: 793
		internal Class6.Class31 class31_0 = new Class6.Class31();

		// Token: 0x0400031A RID: 794
		internal Class6.Class17 class17_2;

		// Token: 0x0400031B RID: 795
		internal Exception exception_0;

		// Token: 0x0400031C RID: 796
		internal List<IntPtr> list_0;

		// Token: 0x0400031D RID: 797
		private int int_0;

		// Token: 0x0400031E RID: 798
		private int int_1;

		// Token: 0x0400031F RID: 799
		private int int_2 = -1;

		// Token: 0x04000320 RID: 800
		private object object_0;

		// Token: 0x04000321 RID: 801
		private bool bool_0;

		// Token: 0x04000322 RID: 802
		private bool bool_1;

		// Token: 0x04000323 RID: 803
		private bool bool_2;

		// Token: 0x04000324 RID: 804
		private bool bool_3;

		// Token: 0x04000325 RID: 805
		private static Dictionary<Type, int> dictionary_0;

		// Token: 0x04000326 RID: 806
		private static object object_1 = new object();

		// Token: 0x04000327 RID: 807
		private static Dictionary<object, Class6.Class17> dictionary_1 = new Dictionary<object, Class6.Class17>();

		// Token: 0x04000328 RID: 808
		private static object object_2 = new object();

		// Token: 0x04000329 RID: 809
		private static Dictionary<MethodBase, Class6.Delegate10> dictionary_2 = new Dictionary<MethodBase, Class6.Delegate10>();

		// Token: 0x0400032A RID: 810
		private static Dictionary<MethodBase, Class6.Delegate10> dictionary_3 = new Dictionary<MethodBase, Class6.Delegate10>();

		// Token: 0x0400032B RID: 811
		private static object object_3 = new object();

		// Token: 0x0400032C RID: 812
		private static Dictionary<Class6.Class14, Class6.Delegate10> dictionary_4 = new Dictionary<Class6.Class14, Class6.Delegate10>();

		// Token: 0x0400032D RID: 813
		private static Dictionary<Class6.Class14, Class6.Delegate10> dictionary_5 = new Dictionary<Class6.Class14, Class6.Delegate10>();

		// Token: 0x0400032E RID: 814
		private static object ivacpLcqOn = new object();

		// Token: 0x0400032F RID: 815
		private static Dictionary<Class6.Class14, Class6.Delegate10> dictionary_6 = new Dictionary<Class6.Class14, Class6.Delegate10>();

		// Token: 0x04000330 RID: 816
		private static object object_4 = new object();

		// Token: 0x04000331 RID: 817
		private static Dictionary<Type, Class6.Delegate11> dictionary_7;

		// Token: 0x04000332 RID: 818
		private static object object_5 = new object();

		// Token: 0x04000333 RID: 819
		private static Class6.Delegate12 wRecHpubLl;

		// Token: 0x04000334 RID: 820
		private static Class6.Delegate13 delegate13_0;

		// Token: 0x02000072 RID: 114
		[CompilerGenerated]
		[Serializable]
		private sealed class Class16
		{
			// Token: 0x06000466 RID: 1126 RVA: 0x00002F8D File Offset: 0x0000118D
			internal int EaecoUppfe(Class6.Class10 x, Class6.Class10 y)
			{
				return x.class11_0.int_0.CompareTo(y.class11_0.int_0);
			}

			// Token: 0x04000335 RID: 821
			public static readonly Class6.Class15.Class16 <>9 = new Class6.Class15.Class16();

			// Token: 0x04000336 RID: 822
			public static Comparison<Class6.Class10> <>9__12_0;
		}
	}

	// Token: 0x02000073 RID: 115
	internal enum Enum3 : byte
	{

	}

	// Token: 0x02000074 RID: 116
	internal enum Enum4 : byte
	{

	}

	// Token: 0x02000075 RID: 117
	internal abstract class Class17
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x000049EC File Offset: 0x00002BEC
		public Class17()
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002FAA File Offset: 0x000011AA
		internal bool method_0()
		{
			return this.enum4_0 == (Class6.Enum4)0;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002FB5 File Offset: 0x000011B5
		internal bool method_1()
		{
			return this.enum4_0 == (Class6.Enum4)1;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0002293C File Offset: 0x00020B3C
		internal bool method_2()
		{
			return this.enum4_0 == (Class6.Enum4)3 || this.enum4_0 == (Class6.Enum4)4;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002FC0 File Offset: 0x000011C0
		internal bool method_3()
		{
			return this.enum4_0 == (Class6.Enum4)2;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002FCB File Offset: 0x000011CB
		internal bool method_4()
		{
			return this.enum4_0 == (Class6.Enum4)5;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002FD6 File Offset: 0x000011D6
		internal bool method_5()
		{
			return this.enum4_0 == (Class6.Enum4)6;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002FE1 File Offset: 0x000011E1
		internal virtual bool iFavIhWly7()
		{
			return false;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002FE1 File Offset: 0x000011E1
		internal virtual bool vmethod_0()
		{
			return false;
		}

		// Token: 0x06000470 RID: 1136
		internal abstract void vmethod_1(Class6.Class17 class17_0);

		// Token: 0x06000471 RID: 1137 RVA: 0x00002FE1 File Offset: 0x000011E1
		internal virtual bool vmethod_2()
		{
			return false;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00022960 File Offset: 0x00020B60
		internal Class17(Class6.Enum4 enum4_1)
		{
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06000473 RID: 1139
		internal abstract object vmethod_3(Type type_0);

		// Token: 0x06000474 RID: 1140
		internal abstract bool vmethod_4(Class6.Class17 class17_0);

		// Token: 0x06000475 RID: 1141
		internal abstract bool vmethod_5(Class6.Class17 class17_0);

		// Token: 0x06000476 RID: 1142
		internal abstract bool vmethod_6();

		// Token: 0x06000477 RID: 1143
		internal abstract Class6.Class17 vmethod_7();

		// Token: 0x06000478 RID: 1144 RVA: 0x00002FE1 File Offset: 0x000011E1
		internal virtual bool vmethod_8()
		{
			return false;
		}

		// Token: 0x06000479 RID: 1145
		internal abstract void vmethod_9(Class6.Class17 class17_0);

		// Token: 0x0600047A RID: 1146 RVA: 0x0002297C File Offset: 0x00020B7C
		internal static Class6.Enum2 smethod_0(Type type_0)
		{
			Type type = type_0;
			if (!(type != null))
			{
				return (Class6.Enum2)18;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (type != null && Nullable.GetUnderlyingType(type) != null)
			{
				type = Nullable.GetUnderlyingType(type);
			}
			if (type == typeof(string))
			{
				return (Class6.Enum2)14;
			}
			if (type == typeof(byte))
			{
				return (Class6.Enum2)2;
			}
			if (type == typeof(sbyte))
			{
				return (Class6.Enum2)1;
			}
			if (type == typeof(short))
			{
				return (Class6.Enum2)3;
			}
			if (type == typeof(ushort))
			{
				return (Class6.Enum2)4;
			}
			if (type == typeof(int))
			{
				return (Class6.Enum2)5;
			}
			if (type == typeof(uint))
			{
				return (Class6.Enum2)6;
			}
			if (type == typeof(long))
			{
				return (Class6.Enum2)7;
			}
			if (type == typeof(ulong))
			{
				return (Class6.Enum2)8;
			}
			if (type == typeof(float))
			{
				return (Class6.Enum2)9;
			}
			if (type == typeof(double))
			{
				return (Class6.Enum2)10;
			}
			if (type == typeof(bool))
			{
				return (Class6.Enum2)11;
			}
			if (type == typeof(IntPtr))
			{
				return (Class6.Enum2)12;
			}
			if (type == typeof(UIntPtr))
			{
				return (Class6.Enum2)13;
			}
			if (type == typeof(char))
			{
				return (Class6.Enum2)15;
			}
			if (type == typeof(object))
			{
				return (Class6.Enum2)0;
			}
			if (!type.IsEnum)
			{
				return (Class6.Enum2)17;
			}
			return (Class6.Enum2)16;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00022B44 File Offset: 0x00020D44
		internal static Class6.Class17 smethod_1(Type type_0, object object_0)
		{
			Class6.Enum2 @enum = Class6.Class17.smethod_0(type_0);
			Class6.Enum2 enum2 = (Class6.Enum2)18;
			if (object_0 != null)
			{
				enum2 = Class6.Class17.smethod_0(object_0.GetType());
			}
			Class6.Class17 @class = null;
			switch (@enum)
			{
			case (Class6.Enum2)0:
				if (enum2 == (Class6.Enum2)15)
				{
					@class = new Class6.Class29(object_0);
				}
				else
				{
					@class = Class6.Class17.smethod_2(object_0);
				}
				break;
			case (Class6.Enum2)1:
				if (enum2 <= (Class6.Enum2)2)
				{
					if (enum2 == (Class6.Enum2)1)
					{
						@class = new Class6.Class19((int)((sbyte)object_0), (Class6.Enum1)1);
						break;
					}
					if (enum2 == (Class6.Enum2)2)
					{
						@class = new Class6.Class19((int)((sbyte)((byte)object_0)), (Class6.Enum1)1);
						break;
					}
				}
				else if (enum2 != (Class6.Enum2)11)
				{
					if (enum2 == (Class6.Enum2)15)
					{
						@class = new Class6.Class19((int)((sbyte)((char)object_0)), (Class6.Enum1)1);
						break;
					}
				}
				else
				{
					if (!(bool)object_0)
					{
						@class = new Class6.Class19(0, (Class6.Enum1)1);
						break;
					}
					@class = new Class6.Class19(1, (Class6.Enum1)1);
					break;
				}
				throw new InvalidCastException();
			case (Class6.Enum2)2:
				if (enum2 <= (Class6.Enum2)2)
				{
					if (enum2 == (Class6.Enum2)1)
					{
						@class = new Class6.Class19((int)((byte)((sbyte)object_0)), (Class6.Enum1)2);
						break;
					}
					if (enum2 == (Class6.Enum2)2)
					{
						@class = new Class6.Class19((int)((byte)object_0), (Class6.Enum1)2);
						break;
					}
				}
				else if (enum2 != (Class6.Enum2)11)
				{
					if (enum2 == (Class6.Enum2)15)
					{
						@class = new Class6.Class19((int)((byte)((char)object_0)), (Class6.Enum1)2);
						break;
					}
				}
				else
				{
					if (!(bool)object_0)
					{
						@class = new Class6.Class19(0, (Class6.Enum1)2);
						break;
					}
					@class = new Class6.Class19(1, (Class6.Enum1)2);
					break;
				}
				throw new InvalidCastException();
			case (Class6.Enum2)3:
				if (enum2 != (Class6.Enum2)3)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class19((int)((short)((char)object_0)), (Class6.Enum1)3);
					}
					else if ((bool)object_0)
					{
						@class = new Class6.Class19(1, (Class6.Enum1)3);
					}
					else
					{
						@class = new Class6.Class19(0, (Class6.Enum1)3);
					}
				}
				else
				{
					@class = new Class6.Class19((int)((short)object_0), (Class6.Enum1)3);
				}
				break;
			case (Class6.Enum2)4:
				if (enum2 != (Class6.Enum2)4)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class19((int)((char)object_0), (Class6.Enum1)4);
					}
					else if (!(bool)object_0)
					{
						@class = new Class6.Class19(0, (Class6.Enum1)4);
					}
					else
					{
						@class = new Class6.Class19(1, (Class6.Enum1)4);
					}
				}
				else
				{
					@class = new Class6.Class19((int)((ushort)object_0), (Class6.Enum1)4);
				}
				break;
			case (Class6.Enum2)5:
				if (enum2 != (Class6.Enum2)5)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class19((int)((char)object_0), (Class6.Enum1)5);
					}
					else if ((bool)object_0)
					{
						@class = new Class6.Class19(1, (Class6.Enum1)5);
					}
					else
					{
						@class = new Class6.Class19(0, (Class6.Enum1)5);
					}
				}
				else
				{
					@class = new Class6.Class19((int)object_0, (Class6.Enum1)5);
				}
				break;
			case (Class6.Enum2)6:
				if (enum2 != (Class6.Enum2)6)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class19((uint)((char)object_0), (Class6.Enum1)6);
					}
					else if (!(bool)object_0)
					{
						@class = new Class6.Class19(0U, (Class6.Enum1)6);
					}
					else
					{
						@class = new Class6.Class19(1U, (Class6.Enum1)6);
					}
				}
				else
				{
					@class = new Class6.Class19((uint)object_0, (Class6.Enum1)6);
				}
				break;
			case (Class6.Enum2)7:
				if (enum2 != (Class6.Enum2)7)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class20((long)((ulong)((char)object_0)), (Class6.Enum1)7);
					}
					else if ((bool)object_0)
					{
						@class = new Class6.Class20(1L, (Class6.Enum1)7);
					}
					else
					{
						@class = new Class6.Class20(0L, (Class6.Enum1)7);
					}
				}
				else
				{
					@class = new Class6.Class20((long)object_0, (Class6.Enum1)7);
				}
				break;
			case (Class6.Enum2)8:
				if (enum2 != (Class6.Enum2)8)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class20((ulong)((char)object_0), (Class6.Enum1)8);
					}
					else if (!(bool)object_0)
					{
						@class = new Class6.Class20(0UL, (Class6.Enum1)8);
					}
					else
					{
						@class = new Class6.Class20(1UL, (Class6.Enum1)8);
					}
				}
				else
				{
					@class = new Class6.Class20((ulong)object_0, (Class6.Enum1)8);
				}
				break;
			case (Class6.Enum2)9:
				if (enum2 != (Class6.Enum2)9)
				{
					throw new InvalidCastException();
				}
				@class = new Class6.Class22((float)object_0);
				break;
			case (Class6.Enum2)10:
				if (enum2 != (Class6.Enum2)10)
				{
					throw new InvalidCastException();
				}
				@class = new Class6.Class22((double)object_0);
				break;
			case (Class6.Enum2)11:
				switch (enum2)
				{
				case (Class6.Enum2)1:
					@class = new Class6.Class19((sbyte)object_0 != 0);
					goto IL_681;
				case (Class6.Enum2)2:
					@class = new Class6.Class19((byte)object_0 > 0);
					goto IL_681;
				case (Class6.Enum2)3:
					@class = new Class6.Class19((short)object_0 != 0);
					goto IL_681;
				case (Class6.Enum2)4:
					@class = new Class6.Class19((ushort)object_0 > 0);
					goto IL_681;
				case (Class6.Enum2)5:
					@class = new Class6.Class19((int)object_0 != 0);
					goto IL_681;
				case (Class6.Enum2)6:
					@class = new Class6.Class19((uint)object_0 > 0U);
					goto IL_681;
				case (Class6.Enum2)7:
					@class = new Class6.Class19((long)object_0 != 0L);
					goto IL_681;
				case (Class6.Enum2)8:
					@class = new Class6.Class19((ulong)object_0 > 0UL);
					goto IL_681;
				case (Class6.Enum2)9:
				case (Class6.Enum2)10:
				case (Class6.Enum2)12:
				case (Class6.Enum2)13:
				case (Class6.Enum2)14:
				case (Class6.Enum2)15:
				case (Class6.Enum2)16:
					throw new InvalidCastException();
				case (Class6.Enum2)11:
					@class = new Class6.Class19((bool)object_0);
					goto IL_681;
				case (Class6.Enum2)18:
					@class = new Class6.Class19(false);
					goto IL_681;
				}
				@class = new Class6.Class19(object_0 != null);
				break;
			case (Class6.Enum2)12:
				if (enum2 != (Class6.Enum2)12)
				{
					throw new InvalidCastException();
				}
				@class = new Class6.Class21((IntPtr)object_0);
				break;
			case (Class6.Enum2)13:
				if (enum2 != (Class6.Enum2)13)
				{
					throw new InvalidCastException();
				}
				@class = new Class6.Class21((UIntPtr)object_0);
				break;
			case (Class6.Enum2)14:
				@class = new Class6.Class30(object_0 as string);
				break;
			case (Class6.Enum2)15:
				switch (enum2)
				{
				case (Class6.Enum2)1:
					@class = new Class6.Class19((int)((sbyte)object_0), (Class6.Enum1)15);
					break;
				case (Class6.Enum2)2:
					@class = new Class6.Class19((int)((byte)object_0), (Class6.Enum1)15);
					break;
				case (Class6.Enum2)3:
					@class = new Class6.Class19((int)((short)object_0), (Class6.Enum1)15);
					break;
				case (Class6.Enum2)4:
					@class = new Class6.Class19((int)((ushort)object_0), (Class6.Enum1)15);
					break;
				case (Class6.Enum2)5:
					@class = new Class6.Class19((int)object_0, (Class6.Enum1)15);
					break;
				case (Class6.Enum2)6:
					@class = new Class6.Class19((int)((uint)object_0), (Class6.Enum1)15);
					break;
				default:
					if (enum2 != (Class6.Enum2)15)
					{
						throw new InvalidCastException();
					}
					@class = new Class6.Class19((int)((char)object_0), (Class6.Enum1)15);
					break;
				}
				break;
			case (Class6.Enum2)16:
			case (Class6.Enum2)17:
				@class = Class6.Class17.smethod_2(object_0);
				break;
			case (Class6.Enum2)18:
				throw new InvalidCastException();
			}
			IL_681:
			if (type_0.IsByRef)
			{
				@class = new Class6.Class28(@class, type_0.GetElementType());
			}
			return @class;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000231F4 File Offset: 0x000213F4
		private static Class6.Class17 smethod_2(object object_0)
		{
			if (object_0 != null && object_0.GetType().IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(object_0.GetType());
				object object_ = Convert.ChangeType(object_0, underlyingType);
				Class6.Class17 @class = Class6.Class17.smethod_3(Class6.Class17.smethod_1(underlyingType, object_));
				if (@class != null)
				{
					return @class as Class6.Class18;
				}
			}
			return new Class6.Class29(object_0);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001971C File Offset: 0x0001791C
		private static Class6.Class18 smethod_3(Class6.Class17 class17_0)
		{
			Class6.Class18 @class = class17_0 as Class6.Class18;
			if (@class == null && class17_0.iFavIhWly7())
			{
				@class = (class17_0.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x04000339 RID: 825
		internal Class6.Enum4 enum4_0;
	}

	// Token: 0x02000076 RID: 118
	private class Class29 : Class6.Class17
	{
		// Token: 0x0600047E RID: 1150 RVA: 0x0002324C File Offset: 0x0002144C
		public Class29() : this(null)
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00023264 File Offset: 0x00021464
		internal override void vmethod_9(Class6.Class17 class17_1)
		{
			if (class17_1 is Class6.Class29)
			{
				this.class17_0 = ((Class6.Class29)class17_1).class17_0;
				this.type_0 = ((Class6.Class29)class17_1).type_0;
				return;
			}
			this.class17_0 = class17_1.vmethod_7();
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00017418 File Offset: 0x00015618
		internal override void vmethod_1(Class6.Class17 class17_1)
		{
			this.vmethod_9(class17_1);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000232A8 File Offset: 0x000214A8
		public Class29(object object_0) : base((Class6.Enum4)0)
		{
			this.class17_0 = object_0;
			this.type_0 = null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000232CC File Offset: 0x000214CC
		public Class29(object object_0, Type type_1) : base((Class6.Enum4)0)
		{
			this.class17_0 = object_0;
			this.type_0 = type_1;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000232F0 File Offset: 0x000214F0
		public override string ToString()
		{
			if (this.class17_0 == null)
			{
				return ((Class6.Enum5)5).ToString();
			}
			return this.class17_0.ToString();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00023324 File Offset: 0x00021524
		internal override object vmethod_3(Type type_1)
		{
			if (this.class17_0 == null)
			{
				return null;
			}
			if (type_1 != null && type_1.IsByRef)
			{
				type_1 = type_1.GetElementType();
			}
			if (!(this.class17_0 is Class6.Class17))
			{
				object obj = this.class17_0;
				if (obj != null && type_1 != null && obj.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (!(this.type_0 != null))
			{
				object obj2 = ((Class6.Class17)this.class17_0).vmethod_3(type_1);
				if (obj2 != null && type_1 != null && obj2.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj2 is Type)
					{
						obj2 = ((Type)obj2).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
					{
						obj2 = ((MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}
			return ((Class6.Class17)this.class17_0).vmethod_3(this.type_0);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00023514 File Offset: 0x00021714
		internal override bool vmethod_4(Class6.Class17 class17_1)
		{
			if (!class17_1.iFavIhWly7())
			{
				object obj = this.vmethod_3(null);
				object obj2 = class17_1.vmethod_3(null);
				return obj == obj2;
			}
			return ((Class6.Class23)class17_1).vmethod_4(this);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0002354C File Offset: 0x0002174C
		internal override bool vmethod_5(Class6.Class17 class17_1)
		{
			if (!class17_1.iFavIhWly7())
			{
				object obj = this.vmethod_3(null);
				object obj2 = class17_1.vmethod_3(null);
				return obj != obj2;
			}
			return ((Class6.Class23)class17_1).vmethod_5(this);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00023588 File Offset: 0x00021788
		internal override Class6.Class17 vmethod_7()
		{
			Class6.Class17 @class = this.class17_0 as Class6.Class17;
			if (@class == null)
			{
				return this;
			}
			return @class.vmethod_7();
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000235B0 File Offset: 0x000217B0
		internal override bool vmethod_6()
		{
			if (this.class17_0 != null)
			{
				Class6.Class17 @class = this.class17_0 as Class6.Class17;
				return @class == null || @class.vmethod_3(null) != null;
			}
			return false;
		}

		// Token: 0x0400033A RID: 826
		public Class6.Class17 class17_0;

		// Token: 0x0400033B RID: 827
		public Type type_0;
	}

	// Token: 0x02000077 RID: 119
	private class Class30 : Class6.Class17
	{
		// Token: 0x06000489 RID: 1161 RVA: 0x000235E8 File Offset: 0x000217E8
		public Class30(string string_1) : base((Class6.Enum4)6)
		{
			this.string_0 = string_1;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00023608 File Offset: 0x00021808
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			this.string_0 = ((Class6.Class30)class17_0).string_0;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00017418 File Offset: 0x00015618
		internal override void vmethod_1(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00023628 File Offset: 0x00021828
		public override string ToString()
		{
			if (this.string_0 == null)
			{
				return ((Class6.Enum5)5).ToString();
			}
			return '*'.ToString() + this.string_0 + '*'.ToString();
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002FE4 File Offset: 0x000011E4
		internal override bool vmethod_6()
		{
			return this.string_0 != null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002FEF File Offset: 0x000011EF
		internal override object vmethod_3(Type type_0)
		{
			return this.string_0;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00023670 File Offset: 0x00021870
		internal override bool vmethod_4(Class6.Class17 class17_0)
		{
			if (class17_0.iFavIhWly7())
			{
				return ((Class6.Class23)class17_0).vmethod_4(this);
			}
			object obj = this.string_0;
			object obj2 = class17_0.vmethod_3(null);
			return obj == obj2;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000236A8 File Offset: 0x000218A8
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (!class17_0.iFavIhWly7())
			{
				object obj = this.string_0;
				object obj2 = class17_0.vmethod_3(null);
				return obj != obj2;
			}
			return ((Class6.Class23)class17_0).vmethod_5(this);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000296B File Offset: 0x00000B6B
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x0400033C RID: 828
		public string string_0;
	}

	// Token: 0x02000078 RID: 120
	internal class Class31
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00002FF7 File Offset: 0x000011F7
		public int method_0()
		{
			return this.list_0.Count;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000236E0 File Offset: 0x000218E0
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000236F8 File Offset: 0x000218F8
		public void method_2(Class6.Class17 class17_0)
		{
			this.list_0.Add(class17_0);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00003004 File Offset: 0x00001204
		public Class6.Class17 method_3()
		{
			return this.list_0[this.list_0.Count - 1];
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000301E File Offset: 0x0000121E
		public Class6.Class17 method_4()
		{
			Class6.Class17 result = this.method_3();
			if (this.list_0.Count != 0)
			{
				this.list_0.RemoveAt(this.list_0.Count - 1);
			}
			return result;
		}

		// Token: 0x0400033D RID: 829
		private List<Class6.Class17> list_0 = new List<Class6.Class17>();
	}

	// Token: 0x02000079 RID: 121
	internal enum Enum5
	{

	}

	// Token: 0x0200007A RID: 122
	[CompilerGenerated]
	[Serializable]
	private sealed class Class32<T>
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x00002F8D File Offset: 0x0000118D
		internal int method_0(Class6.Class10 x, Class6.Class10 y)
		{
			return x.class11_0.int_0.CompareTo(y.class11_0.int_0);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000304B File Offset: 0x0000124B
		internal static bool smethod_0()
		{
			return Class6.Class32<T>.object_0 == null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00003055 File Offset: 0x00001255
		internal static object smethod_1()
		{
			return Class6.Class32<T>.object_0;
		}

		// Token: 0x0400033F RID: 831
		public static readonly Class6.Class32<T> <>9 = new Class6.Class32<T>();

		// Token: 0x04000340 RID: 832
		public static Comparison<Class6.Class10> <>9__45_0;

		// Token: 0x04000341 RID: 833
		internal static object object_0;
	}
}
