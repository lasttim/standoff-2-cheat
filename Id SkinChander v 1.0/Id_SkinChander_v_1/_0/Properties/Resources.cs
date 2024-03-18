using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Id_SkinChander_v_1._0.Properties
{
	// Token: 0x0200003C RID: 60
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		// Token: 0x06000191 RID: 401 RVA: 0x000049EC File Offset: 0x00002BEC
		internal Resources()
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00014F20 File Offset: 0x00013120
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("Id_SkinChander_v_1._0.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00014F64 File Offset: 0x00013164
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00014F7C File Offset: 0x0001317C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400029C RID: 668
		private static ResourceManager resourceMan;

		// Token: 0x0400029D RID: 669
		private static CultureInfo resourceCulture;
	}
}
