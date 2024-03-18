using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Id_SkinChander_v_1._0
{
	// Token: 0x02000039 RID: 57
	public partial class Loader : Form
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00012954 File Offset: 0x00010B54
		public Loader()
		{
			this.InitializeComponent();
			this.label4.Text = " " + login.KeyAuthApp.user_data.username;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0001299C File Offset: 0x00010B9C
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			Priavte priavte = new Priavte();
			priavte.Show();
			base.Hide();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000129C0 File Offset: 0x00010BC0
		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
			Process.Start("https://t.me/dimker69");
		}
	}
}
