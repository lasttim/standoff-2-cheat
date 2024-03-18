using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Id_SkinChander_v_1._0
{
	public partial class watermark : Form
	{
		public watermark()
		{
			this.InitializeComponent();
			base.TopMost = true;
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}
		private void watermark_Load(object sender, EventArgs e)
		{
			//watermark.<watermark_Load>d__2 <watermark_Load>d__ = new watermark.<watermark_Load>d__2();
			//<watermark_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<watermark_Load>d__.<>4__this = this;
			//<watermark_Load>d__.sender = sender;
			//<watermark_Load>d__.e = e;
			//<watermark_Load>d__.<>1__state = -1;
			//<watermark_Load>d__.<>t__builder.Start<watermark.<watermark_Load>d__2>(ref <watermark_Load>d__);
		}
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}
		private void label2_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}
		private void label2_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}
		private void label6_Click(object sender, EventArgs e)
		{
			if (this.colorDialog1.ShowDialog() != DialogResult.Cancel)
			{
				this.label1.ForeColor = this.colorDialog1.Color;
				this.guna2Panel_0.FillColor = this.colorDialog1.Color;
				this.guna2Panel_1.FillColor = this.colorDialog1.Color;
			}
		}
		private void label1_Click(object sender, EventArgs e)
		{
		}
		private void label6_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}
		private void label6_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}
		private void label2_MouseDown_1(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}
		private void label2_MouseMove_1(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}
		private void watermark_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}
		private void watermark_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}
		private void label2_Click_1(object sender, EventArgs e)
		{
		}
		private Point lastPoint;
	}
}
