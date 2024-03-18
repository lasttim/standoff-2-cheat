namespace Id_SkinChander_v_1._0
{

	public partial class login : global::System.Windows.Forms.Form
	{

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Id_SkinChander_v_1._0.login));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.guna2Panel_0 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel_1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.label25 = new global::System.Windows.Forms.Label();
			this.uname = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.pswrd = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2PictureBox1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.msg = new global::Guna.UI2.WinForms.Guna2MessageDialog();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			//this.guna2PictureBox1.BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.panel1.Location = new global::System.Drawing.Point(0, -12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(2, 422);
			this.panel1.TabIndex = 0;
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.panel2.Location = new global::System.Drawing.Point(495, -34);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(2, 422);
			this.panel2.TabIndex = 1;
			this.guna2Panel_0.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.guna2Panel_0.Location = new global::System.Drawing.Point(-31, 352);
			this.guna2Panel_0.Name = "guna2Panel1";
			this.guna2Panel_0.Size = new global::System.Drawing.Size(544, 2);
			this.guna2Panel_0.TabIndex = 2;
			this.guna2Panel_1.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.guna2Panel_1.Location = new global::System.Drawing.Point(-24, 0);
			this.guna2Panel_1.Name = "guna2Panel2";
			this.guna2Panel_1.Size = new global::System.Drawing.Size(544, 2);
			this.guna2Panel_1.TabIndex = 3;
			this.label25.AutoSize = true;
			this.label25.Font = new global::System.Drawing.Font("Horst Blackletter", 36f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label25.ForeColor = global::System.Drawing.Color.White;
			this.label25.Location = new global::System.Drawing.Point(154, 9);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(188, 53);
			this.label25.TabIndex = 8;
			this.label25.Text = "DIMKER";
			this.uname.BorderColor = global::System.Drawing.Color.Red;
			this.uname.BorderRadius = 3;
			this.uname.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.uname.DefaultText = "";
			this.uname.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.uname.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.uname.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.uname.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.uname.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.uname.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.uname.FocusedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.uname.Font = new global::System.Drawing.Font("Verdana", 9f);
			this.uname.ForeColor = global::System.Drawing.Color.White;
			this.uname.HoverState.BorderColor = global::System.Drawing.Color.Red;
			this.uname.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.uname.Location = new global::System.Drawing.Point(149, 114);
			this.uname.Name = "uname";
			this.uname.PasswordChar = '\0';
			this.uname.PlaceholderText = "Username";
			this.uname.SelectedText = "";
			this.uname.Size = new global::System.Drawing.Size(198, 25);
			this.uname.TabIndex = 17;
			this.pswrd.BorderColor = global::System.Drawing.Color.Red;
			this.pswrd.BorderRadius = 3;
			this.pswrd.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.pswrd.DefaultText = "";
			this.pswrd.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.pswrd.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.pswrd.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pswrd.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pswrd.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.pswrd.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.pswrd.FocusedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.pswrd.Font = new global::System.Drawing.Font("Verdana", 9f);
			this.pswrd.ForeColor = global::System.Drawing.Color.White;
			this.pswrd.HoverState.BorderColor = global::System.Drawing.Color.Red;
			this.pswrd.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.pswrd.Location = new global::System.Drawing.Point(149, 145);
			this.pswrd.Name = "pswrd";
			this.pswrd.PasswordChar = '\0';
			this.pswrd.PlaceholderText = "Password";
			this.pswrd.SelectedText = "";
			this.pswrd.Size = new global::System.Drawing.Size(198, 25);
			this.pswrd.TabIndex = 18;
			this.guna2Button3.BorderColor = global::System.Drawing.Color.Red;
			this.guna2Button3.BorderRadius = 3;
			this.guna2Button3.BorderThickness = 1;
			this.guna2Button3.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.Red;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button3.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.guna2Button3.Font = new global::System.Drawing.Font("Verdana", 9f);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button3.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.guna2Button3.Location = new global::System.Drawing.Point(149, 183);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new global::System.Drawing.Size(198, 25);
			this.guna2Button3.TabIndex = 19;
			this.guna2Button3.Text = "Login";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			//this.guna2PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2PictureBox1.Image");
			this.guna2PictureBox1.ImageRotate = 0f;
			this.guna2PictureBox1.Location = new global::System.Drawing.Point(474, 4);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new global::System.Drawing.Size(20, 20);
			this.guna2PictureBox1.TabIndex = 20;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.Click += new global::System.EventHandler(this.guna2PictureBox1_Click);
            this.msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK; //this.msg.Buttons = (Guna.UI2.WinForms.MessageDialogButtons)4;
            this.msg.Caption = null;
			this.msg.Icon = 0;
			this.msg.Parent = null;
            this.msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark; //this.msg.Style = (Guna.UI2.WinForms.MessageDialogStyle)2;
            this.msg.Text = null;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(497, 355);
			base.Controls.Add(this.guna2PictureBox1);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.pswrd);
			base.Controls.Add(this.uname);
			base.Controls.Add(this.label25);
			base.Controls.Add(this.guna2Panel_1);
			base.Controls.Add(this.guna2Panel_0);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "login";
			base.ShowIcon = false;
			this.Text = "login";
			base.Load += new global::System.EventHandler(this.login_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
			//this.guna2PictureBox1.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Panel panel1;

		private global::System.Windows.Forms.Panel panel2;

		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel_0;

		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel_1;

		private global::System.Windows.Forms.Label label25;

		private global::Guna.UI2.WinForms.Guna2TextBox uname;

		private global::Guna.UI2.WinForms.Guna2TextBox pswrd;

		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

		private global::Guna.UI2.WinForms.Guna2MessageDialog msg;

		private global::System.Windows.Forms.Timer timer1;
	}
}
