using System;
using System.Reflection;

// Token: 0x02000041 RID: 65
internal class Class1
{
	// Token: 0x060001A2 RID: 418 RVA: 0x000155B0 File Offset: 0x000137B0
	internal static void smethod_0(int typemdt)
	{
		Type type = Class1.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class1.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x040002A4 RID: 676
	internal static Module module_0 = typeof(Class1).Assembly.ManifestModule;

	// Token: 0x02000042 RID: 66
	// (Invoke) Token: 0x060001A6 RID: 422
	internal delegate void Delegate0(object o);
}
