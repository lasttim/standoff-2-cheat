using System;
using System.Windows.Forms;

namespace Id_SkinChander_v_1._0
{
	// Token: 0x0200003B RID: 59
	internal static class Program
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00014EFC File Offset: 0x000130FC
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new login());
		}
	}
}
