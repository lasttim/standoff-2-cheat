namespace Id_SkinChander_v_1._0
{
	// Token: 0x02000010 RID: 16
	public partial class watermark : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x000050D4 File Offset: 0x000032D4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005104 File Offset: 0x00003304
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm_0 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel_0 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel_1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel_3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel_2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel_4 = new Guna.UI2.WinForms.Guna2Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.guna2Panel_5 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm_0
            // 
            this.guna2BorderlessForm_0.BorderRadius = 1;
            this.guna2BorderlessForm_0.ContainerControl = this;
            this.guna2BorderlessForm_0.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm_0.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm_0.ResizeForm = false;
            this.guna2BorderlessForm_0.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2BorderlessForm_0.TransparentWhileDrag = true;
            // 
            // guna2Panel_0
            // 
            this.guna2Panel_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel_0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel_0.BorderRadius = 3;
            this.guna2Panel_0.FillColor = System.Drawing.Color.Red;
            this.guna2Panel_0.Location = new System.Drawing.Point(7, 2);
            this.guna2Panel_0.Name = "guna2Panel_0";
            this.guna2Panel_0.Size = new System.Drawing.Size(6, 18);
            this.guna2Panel_0.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "dimker.tg";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(87, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "exe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "unhook";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown_1);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove_1);
            // 
            // guna2Panel_1
            // 
            this.guna2Panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel_1.BorderRadius = 3;
            this.guna2Panel_1.FillColor = System.Drawing.Color.Red;
            this.guna2Panel_1.Location = new System.Drawing.Point(182, 2);
            this.guna2Panel_1.Name = "guna2Panel_1";
            this.guna2Panel_1.Size = new System.Drawing.Size(6, 18);
            this.guna2Panel_1.TabIndex = 6;
            // 
            // guna2Panel_3
            // 
            this.guna2Panel_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel_3.Location = new System.Drawing.Point(-4, 0);
            this.guna2Panel_3.Name = "guna2Panel_3";
            this.guna2Panel_3.Size = new System.Drawing.Size(210, 1);
            this.guna2Panel_3.TabIndex = 8;
            // 
            // guna2Panel_2
            // 
            this.guna2Panel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel_2.Location = new System.Drawing.Point(201, -4);
            this.guna2Panel_2.Name = "guna2Panel_2";
            this.guna2Panel_2.Size = new System.Drawing.Size(1, 210);
            this.guna2Panel_2.TabIndex = 9;
            // 
            // guna2Panel_4
            // 
            this.guna2Panel_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel_4.Location = new System.Drawing.Point(0, -94);
            this.guna2Panel_4.Name = "guna2Panel_4";
            this.guna2Panel_4.Size = new System.Drawing.Size(1, 210);
            this.guna2Panel_4.TabIndex = 10;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            this.colorDialog1.FullOpen = true;
            // 
            // guna2Panel_5
            // 
            this.guna2Panel_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel_5.Location = new System.Drawing.Point(0, 21);
            this.guna2Panel_5.Name = "guna2Panel_5";
            this.guna2Panel_5.Size = new System.Drawing.Size(210, 1);
            this.guna2Panel_5.TabIndex = 7;
            // 
            // watermark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(203, 22);
            this.Controls.Add(this.guna2Panel_4);
            this.Controls.Add(this.guna2Panel_2);
            this.Controls.Add(this.guna2Panel_3);
            this.Controls.Add(this.guna2Panel_5);
            this.Controls.Add(this.guna2Panel_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Panel_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "watermark";
            this.ShowIcon = false;
            this.Text = "watermark";
            this.Load += new System.EventHandler(this.watermark_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.watermark_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.watermark_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000041 RID: 65
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000042 RID: 66
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm_0;

		// Token: 0x04000043 RID: 67
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel_0;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000047 RID: 71
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel_1;

		// Token: 0x04000048 RID: 72
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel_2;

		// Token: 0x04000049 RID: 73
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel_3;

		// Token: 0x0400004A RID: 74
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel_4;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x0400004C RID: 76
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel_5;
	}
}
