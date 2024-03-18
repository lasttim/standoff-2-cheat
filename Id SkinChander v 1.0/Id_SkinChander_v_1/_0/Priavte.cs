using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using Guna.UI2.WinForms;
using Memory;
using static System.Windows.Forms.AxHost;

namespace Id_SkinChander_v_1._0
{
    public partial class Priavte : Form
    {
        public Priavte()
        {
            this.InitializeComponent();
            int procIdFromName = this.m.GetProcIdFromName("HD-Player");
            if (procIdFromName > 0)
            {
                this.m.OpenProcess(procIdFromName);
                MessageBox.Show("Inject");
            }
            else
            {
                MessageBox.Show("Non Inject");
                Application.Exit();
            }
        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.guna2Panel_5.Visible = true;
            this.guna2Panel_3.Visible = false;
            this.guna2Panel12.Visible = false;
            this.guna2Panel10.Visible = false;
            this.guna2Panel14.Visible = false;
            this.guna2Panel_7.Visible = false;
            this.label2.ForeColor = this.colorDialog1.Color;
            this.label1.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label5.ForeColor = Color.White;
            this.label34.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.guna2Panel_3.Visible = true;
            this.guna2Panel_5.Visible = false;
            this.guna2Panel12.Visible = false;
            this.guna2Panel10.Visible = false;
            this.guna2Panel14.Visible = false;
            this.guna2Panel_7.Visible = false;
            this.label1.ForeColor = this.colorDialog1.Color;
            this.label2.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label5.ForeColor = Color.White;
            this.label34.ForeColor = Color.White;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.guna2Panel_7.Visible = true;
            this.guna2Panel_5.Visible = false;
            this.guna2Panel12.Visible = false;
            this.guna2Panel10.Visible = false;
            this.guna2Panel14.Visible = false;
            this.guna2Panel_3.Visible = false;
            this.label3.ForeColor = this.colorDialog1.Color;
            this.label1.ForeColor = Color.White;
            this.label2.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label5.ForeColor = Color.White;
            this.label34.ForeColor = Color.White;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.guna2Panel10.Visible = true;
            this.guna2Panel_5.Visible = false;
            this.guna2Panel12.Visible = false;
            this.guna2Panel_3.Visible = false;
            this.guna2Panel14.Visible = false;
            this.guna2Panel_7.Visible = false;
            this.label5.ForeColor = this.colorDialog1.Color;
            this.label1.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label2.ForeColor = Color.White;
            this.label34.ForeColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.guna2Panel12.Visible = true;
            this.guna2Panel_5.Visible = false;
            this.guna2Panel14.Visible = false;
            this.guna2Panel_3.Visible = false;
            this.guna2Panel10.Visible = false;
            this.guna2Panel_7.Visible = false;
            this.label4.ForeColor = this.colorDialog1.Color;
            this.label1.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label2.ForeColor = Color.White;
            this.label5.ForeColor = Color.White;
            this.label34.ForeColor = Color.White;
        }

        private void guna2Panel14_Paint(object sender, PaintEventArgs e)
        {
            if (this.colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                this.label1.ForeColor = this.colorDialog1.Color;
                this.guna2Button1.BorderColor = this.colorDialog1.Color;
                this.guna2Button2.BorderColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_4.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_3.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_2.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_1.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_8.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_5.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_0.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_6.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_7.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox10.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox11.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox12.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox13.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox15.CheckMarkColor = this.colorDialog1.Color;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                this.label5.ForeColor = Color.White;
                this.label1.ForeColor = Color.White;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = this.colorDialog1.Color;
                this.label2.ForeColor = Color.White;
                this.guna2Button2.DisabledState.BorderColor = this.colorDialog1.Color;
                this.guna2Button3.FillColor = this.colorDialog1.Color;
                this.guna2Button4.BorderColor = this.colorDialog1.Color;
                this.search.BorderColor = this.colorDialog1.Color;
                this.change.BorderColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_4.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_3.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_2.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_1.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_8.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_5.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_0.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_6.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox_7.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox10.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox11.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox12.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox13.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox15.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox16.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox17.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox18.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox19.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox20.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox21.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox22.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox23.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox25.CheckMarkColor = this.colorDialog1.Color;
                this.guna2CustomCheckBox26.CheckMarkColor = this.colorDialog1.Color;
            }
        }

        private void guna2Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.Left += e.X - this.lastPoint.X;
                base.Top += e.Y - this.lastPoint.Y;
            }
        }

        // Token: 0x060000B5 RID: 181 RVA: 0x000063D8 File Offset: 0x000045D8
        private void guna2Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        // Token: 0x060000B6 RID: 182 RVA: 0x000063D8 File Offset: 0x000045D8
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        // Token: 0x060000B7 RID: 183 RVA: 0x0000637C File Offset: 0x0000457C
        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.Left += e.X - this.lastPoint.X;
                base.Top += e.Y - this.lastPoint.Y;
            }
        }

        // Token: 0x060000B8 RID: 184 RVA: 0x0000637C File Offset: 0x0000457C
        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.Left += e.X - this.lastPoint.X;
                base.Top += e.Y - this.lastPoint.Y;
            }
        }

        // Token: 0x060000B9 RID: 185 RVA: 0x000063D8 File Offset: 0x000045D8
        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        // Token: 0x060000BA RID: 186 RVA: 0x000063D8 File Offset: 0x000045D8
        private void guna2Panel6_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        // Token: 0x060000BB RID: 187 RVA: 0x0000637C File Offset: 0x0000457C
        private void guna2Panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.Left += e.X - this.lastPoint.X;
                base.Top += e.Y - this.lastPoint.Y;
            }
        }

        // Token: 0x060000BC RID: 188 RVA: 0x000063D8 File Offset: 0x000045D8
        private void guna2Panel12_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        // Token: 0x060000BD RID: 189 RVA: 0x0000637C File Offset: 0x0000457C
        private void guna2Panel12_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.Left += e.X - this.lastPoint.X;
                base.Top += e.Y - this.lastPoint.Y;
            }
        }

        // Token: 0x060000BE RID: 190 RVA: 0x000063D8 File Offset: 0x000045D8
        private void guna2Panel10_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        // Token: 0x060000BF RID: 191 RVA: 0x000063D8 File Offset: 0x000045D8
        private void guna2Panel8_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        // Token: 0x060000C0 RID: 192 RVA: 0x0000637C File Offset: 0x0000457C
        private void guna2Panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.Left += e.X - this.lastPoint.X;
                base.Top += e.Y - this.lastPoint.Y;
            }
        }

        // Token: 0x060000C1 RID: 193 RVA: 0x000063FC File Offset: 0x000045FC
        private void guna2Panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.Left += e.X - this.lastPoint.X;
                base.Top += e.Y - this.lastPoint.Y;
            }
        }

        // Token: 0x060000C2 RID: 194 RVA: 0x00006458 File Offset: 0x00004658
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Token: 0x060000C3 RID: 195 RVA: 0x0000646C File Offset: 0x0000466C
        private void sss()
        {
            //Priavte.<>c__DisplayClass91_0 CS$<>8__locals1 = new Priavte.<>c__DisplayClass91_0();
            //<>4__this = this;
            Mem m = new Mem();
            int procIdFromName = m.GetProcIdFromName("HD-Player.exe");
            if (procIdFromName > 0)
            {
                m.OpenProcess(procIdFromName);
            }
            Priavte._hook = Hook.GlobalEvents();
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Capital)
                {
                    if (Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "freeze";
                    }
                    else
                    {
                        Priavte.InfoBind = "unhook";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Capital)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "unhook";
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "freeze";
                    }
                    else
                    {
                        Priavte.InfoBind = "hook";
                        if (aimCHECK)
                        {
                            m.WriteMemory(aimADR, "bytes", aimSIGN, "", null, true);
                        }
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (cipCHECK)
                        {
                            m.WriteMemory(cipADR, "bytes", cipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "freeze";
                    }
                    else
                    {
                        Priavte.InfoBind = "hook";
                        if (recCHECK)
                        {
                            m.WriteMemory(recADR, "bytes", recSIGN, "", null, true);
                        }
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (aCHECK)
                        {
                            m.WriteMemory(aADR, "bytes", aSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (heCHECK)
                        {
                            m.WriteMemory(heADR, "bytes", heSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "freeze";
                    }
                    else
                    {
                        Priavte.InfoBind = "hook";
                        if (bool_2)
                        {
                            m.WriteMemory(clipADR, "bytes", clipSIGN, "", null, true);
                        }
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (lipCHECK)
                        {
                            m.WriteMemory(lipADR, "bytes", lipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (bool_0)
                        {
                            m.WriteMemory(wallADR, "bytes", wallSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (allCHECK)
                        {
                            m.WriteMemory(allADR, "bytes", allSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "freeze";
                    }
                    else
                    {
                        Priavte.InfoBind = "hook";
                        if (walCHECK)
                        {
                            m.WriteMemory(walADR, "bytes", walSIGN, "", null, true);
                        }
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "freeze";
                    }
                    else
                    {
                        Priavte.InfoBind = "hook";
                        if (llCHECK)
                        {
                            m.WriteMemory(llADR, "bytes", llSIGN, "", null, true);
                        }
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "freeze";
                    }
                    else
                    {
                        Priavte.InfoBind = "hook";
                        if (llCHECK)
                        {
                            m.WriteMemory(llADR, "bytes", llSIGN, "", null, true);
                        }
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (wCHECK)
                        {
                            m.WriteMemory(wADR, "bytes", wSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (waCHECK)
                        {
                            m.WriteMemory(waADR, "bytes", waSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (addscoreCHECK)
                        {
                            m.WriteMemory(string_0, "bytes", addscoreSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (bool_1)
                        {
                            m.WriteMemory(flashADR, "bytes", string_3, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (addscoreCHECK)
                        {
                            m.WriteMemory(string_0, "bytes", addscoreSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (adscoreCHECK)
                        {
                            m.WriteMemory(string_1, "bytes", string_2, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
            Priavte._hook.KeyUp += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == selectedBind)
                {
                    if (!Control.IsKeyLocked(Keys.Capital))
                    {
                        Priavte.InfoBind = "hook";
                        if (ipCHECK)
                        {
                            m.WriteMemory(ipADR, "bytes", ipSIGN, "", null, true);
                        }
                    }
                    else
                    {
                        Priavte.InfoBind = "freeze";
                    }
                }
            };
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.Capital))
            {
                Priavte.InfoBind = "freeze";
            }
            else
            {
                Priavte.InfoBind = "unhook";
            }
            if (this.watermarkForm == null || this.watermarkForm.IsDisposed)
            {
                this.watermarkForm = new watermark();
            }
            this.watermarkForm.Show();
            base.Focus();
            this.sss();
        }

        // Token: 0x060000C5 RID: 197 RVA: 0x000068DC File Offset: 0x00004ADC
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.guna2Button2.Text = "...";
            this.guna2Button2.Enabled = false;
            this.isWaitingForKey = true;
            base.KeyPreview = true;
            this.MainForm_KeyDown();
        }

        // Token: 0x060000C6 RID: 198 RVA: 0x0000691C File Offset: 0x00004B1C
        private void MainForm_KeyDown()
        {
            Priavte._hook = Hook.GlobalEvents();
            Priavte._hook.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (this.isWaitingForKey)
                {
                    this.selectedBind = e.KeyCode;
                    this.guna2Button2.Text = e.KeyCode.ToString();
                    this.guna2Button2.Enabled = true;
                    base.KeyPreview = false;
                    this.isWaitingForKey = false;
                }
            };
        }

        // Token: 0x060000C7 RID: 199 RVA: 0x0000694C File Offset: 0x00004B4C
        private void guna2CustomCheckBox7_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox7_Click > d__97 < guna2CustomCheckBox7_Click > d__ = new Priavte.< guna2CustomCheckBox7_Click > d__97();

            //< guna2CustomCheckBox7_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox7_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox7_Click > d__.sender = sender;

            //< guna2CustomCheckBox7_Click > d__.e = e;

            //< guna2CustomCheckBox7_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox7_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox7_Click > d__97 > (ref < guna2CustomCheckBox7_Click > d__);
        }

        // Token: 0x060000C8 RID: 200 RVA: 0x0000699C File Offset: 0x00004B9C
        private void guna2CustomCheckBox16_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox16_Click > d__98 < guna2CustomCheckBox16_Click > d__ = new Priavte.< guna2CustomCheckBox16_Click > d__98();

            //< guna2CustomCheckBox16_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox16_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox16_Click > d__.sender = sender;

            //< guna2CustomCheckBox16_Click > d__.e = e;

            //< guna2CustomCheckBox16_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox16_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox16_Click > d__98 > (ref < guna2CustomCheckBox16_Click > d__);
        }

        // Token: 0x060000C9 RID: 201 RVA: 0x000069EC File Offset: 0x00004BEC
        private void guna2CustomCheckBox17_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox17_Click > d__99 < guna2CustomCheckBox17_Click > d__ = new Priavte.< guna2CustomCheckBox17_Click > d__99();

            //< guna2CustomCheckBox17_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox17_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox17_Click > d__.sender = sender;

            //< guna2CustomCheckBox17_Click > d__.e = e;

            //< guna2CustomCheckBox17_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox17_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox17_Click > d__99 > (ref < guna2CustomCheckBox17_Click > d__);
        }

        // Token: 0x060000CA RID: 202 RVA: 0x00006A3C File Offset: 0x00004C3C
        private void guna2CustomCheckBox18_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox18_Click > d__100 < guna2CustomCheckBox18_Click > d__ = new Priavte.< guna2CustomCheckBox18_Click > d__100();

            //< guna2CustomCheckBox18_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox18_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox18_Click > d__.sender = sender;

            //< guna2CustomCheckBox18_Click > d__.e = e;

            //< guna2CustomCheckBox18_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox18_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox18_Click > d__100 > (ref < guna2CustomCheckBox18_Click > d__);
        }

        // Token: 0x060000CB RID: 203 RVA: 0x00006A8C File Offset: 0x00004C8C
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox1_Click > d__101 < guna2CustomCheckBox1_Click > d__ = new Priavte.< guna2CustomCheckBox1_Click > d__101();

            //< guna2CustomCheckBox1_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox1_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox1_Click > d__.sender = sender;

            //< guna2CustomCheckBox1_Click > d__.e = e;

            //< guna2CustomCheckBox1_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox1_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox1_Click > d__101 > (ref < guna2CustomCheckBox1_Click > d__);
        }

        // Token: 0x060000CC RID: 204 RVA: 0x00006ADC File Offset: 0x00004CDC
        private void guna2CustomCheckBox2_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (this.guna2CustomCheckBox_3.Checked)
                {
                    this.processingCheckBoxChange = true;
                    this.aimCHECK = true;
                    this.aimSIGN = "CD CC 4C 3E B0 B5 0C 46 06 49 05 46 E0 69 79 44 FD F6";
                    this.guna2CustomCheckBox_1.Checked = false;
                    this.guna2CustomCheckBox_2.Checked = false;
                    this.guna2CustomCheckBox22.Checked = false;
                    this.guna2CustomCheckBox23.Checked = false;
                    this.processingCheckBoxChange = false;
                }
                else
                {
                    this.aimCHECK = false;
                }
            }
        }

        // Token: 0x060000CD RID: 205 RVA: 0x00006B5C File Offset: 0x00004D5C
        private void guna2CustomCheckBox3_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (!this.guna2CustomCheckBox_2.Checked)
                {
                    this.aimCHECK = false;
                }
                else
                {
                    this.processingCheckBoxChange = true;
                    this.aimCHECK = true;
                    this.aimSIGN = "00 00 20 41 B0 B5 0C 46 06 49 05 46 E0 69 79 44 FD F6";
                    this.guna2CustomCheckBox_1.Checked = false;
                    this.guna2CustomCheckBox_3.Checked = false;
                    this.guna2CustomCheckBox22.Checked = false;
                    this.guna2CustomCheckBox23.Checked = false;
                    this.processingCheckBoxChange = false;
                }
            }
        }

        // Token: 0x060000CE RID: 206 RVA: 0x00006BDC File Offset: 0x00004DDC
        private void guna2CustomCheckBox4_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (this.guna2CustomCheckBox_1.Checked)
                {
                    this.processingCheckBoxChange = true;
                    this.aimCHECK = true;
                    this.aimSIGN = "00 00 B0 41 B0 B5 0C 46 06 49 05 46 E0 69 79 44 FD F6";
                    this.guna2CustomCheckBox_3.Checked = false;
                    this.guna2CustomCheckBox_2.Checked = false;
                    this.guna2CustomCheckBox22.Checked = false;
                    this.guna2CustomCheckBox23.Checked = false;
                    this.processingCheckBoxChange = false;
                }
                else
                {
                    this.aimCHECK = false;
                }
            }
        }

        // Token: 0x060000CF RID: 207 RVA: 0x00006C5C File Offset: 0x00004E5C
        private void guna2CustomCheckBox15_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox15_Click > d__105 < guna2CustomCheckBox15_Click > d__ = new Priavte.< guna2CustomCheckBox15_Click > d__105();

            //< guna2CustomCheckBox15_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox15_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox15_Click > d__.sender = sender;

            //< guna2CustomCheckBox15_Click > d__.e = e;

            //< guna2CustomCheckBox15_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox15_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox15_Click > d__105 > (ref < guna2CustomCheckBox15_Click > d__);
        }

        // Token: 0x060000D0 RID: 208 RVA: 0x00006CAC File Offset: 0x00004EAC
        private void guna2CustomCheckBox14_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox14_Click > d__106 < guna2CustomCheckBox14_Click > d__ = new Priavte.< guna2CustomCheckBox14_Click > d__106();

            //< guna2CustomCheckBox14_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox14_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox14_Click > d__.sender = sender;

            //< guna2CustomCheckBox14_Click > d__.e = e;

            //< guna2CustomCheckBox14_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox14_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox14_Click > d__106 > (ref < guna2CustomCheckBox14_Click > d__);
        }

        // Token: 0x060000D1 RID: 209 RVA: 0x00006CFC File Offset: 0x00004EFC
        private void guna2CustomCheckBox13_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox13_Click > d__107 < guna2CustomCheckBox13_Click > d__ = new Priavte.< guna2CustomCheckBox13_Click > d__107();

            //< guna2CustomCheckBox13_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox13_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox13_Click > d__.sender = sender;

            //< guna2CustomCheckBox13_Click > d__.e = e;

            //< guna2CustomCheckBox13_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox13_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox13_Click > d__107 > (ref < guna2CustomCheckBox13_Click > d__);
        }

        // Token: 0x060000D2 RID: 210 RVA: 0x00006D4C File Offset: 0x00004F4C
        private void guna2CustomCheckBox12_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox12_Click > d__108 < guna2CustomCheckBox12_Click > d__ = new Priavte.< guna2CustomCheckBox12_Click > d__108();

            //< guna2CustomCheckBox12_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox12_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox12_Click > d__.sender = sender;

            //< guna2CustomCheckBox12_Click > d__.e = e;

            //< guna2CustomCheckBox12_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox12_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox12_Click > d__108 > (ref < guna2CustomCheckBox12_Click > d__);
        }

        // Token: 0x060000D3 RID: 211 RVA: 0x00006D9C File Offset: 0x00004F9C
        private void guna2CustomCheckBox11_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox11_Click > d__109 < guna2CustomCheckBox11_Click > d__ = new Priavte.< guna2CustomCheckBox11_Click > d__109();

            //< guna2CustomCheckBox11_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox11_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox11_Click > d__.sender = sender;

            //< guna2CustomCheckBox11_Click > d__.e = e;

            //< guna2CustomCheckBox11_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox11_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox11_Click > d__109 > (ref < guna2CustomCheckBox11_Click > d__);
        }

        // Token: 0x060000D4 RID: 212 RVA: 0x00006DEC File Offset: 0x00004FEC
        private void guna2CustomCheckBox19_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox19_Click > d__110 < guna2CustomCheckBox19_Click > d__ = new Priavte.< guna2CustomCheckBox19_Click > d__110();

            //< guna2CustomCheckBox19_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox19_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox19_Click > d__.sender = sender;

            //< guna2CustomCheckBox19_Click > d__.e = e;

            //< guna2CustomCheckBox19_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox19_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox19_Click > d__110 > (ref < guna2CustomCheckBox19_Click > d__);
        }

        // Token: 0x060000D5 RID: 213 RVA: 0x00006E3C File Offset: 0x0000503C
        private void guna2CustomCheckBox21_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox21_Click > d__111 < guna2CustomCheckBox21_Click > d__ = new Priavte.< guna2CustomCheckBox21_Click > d__111();

            //< guna2CustomCheckBox21_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox21_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox21_Click > d__.sender = sender;

            //< guna2CustomCheckBox21_Click > d__.e = e;

            //< guna2CustomCheckBox21_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox21_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox21_Click > d__111 > (ref < guna2CustomCheckBox21_Click > d__);
        }

        // Token: 0x060000D6 RID: 214 RVA: 0x00006E8C File Offset: 0x0000508C
        private void guna2CustomCheckBox20_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (this.guna2CustomCheckBox20.Checked)
                {
                    this.processingCheckBoxChange = true;
                    this.cipCHECK = true;
                    this.cipSIGN = "0A 0A 84 ED 0E 1A 84 ED 05 3A 84 ED 00 2A 84 ED 08 D0 8D E2 70 80 BD E8 00 00 7A 43 9A 99 29 40 10 2A 00 EE 00 10 80 E5 10 3A 01 EE 14 10 80 E5";
                    this.processingCheckBoxChange = false;
                }
                else
                {
                    this.cipCHECK = false;
                }
            }
        }

        // Token: 0x060000D7 RID: 215 RVA: 0x00006EDC File Offset: 0x000050DC
        private void guna2CustomCheckBox5_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox5_Click > d__113 < guna2CustomCheckBox5_Click > d__ = new Priavte.< guna2CustomCheckBox5_Click > d__113();

            //< guna2CustomCheckBox5_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox5_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox5_Click > d__.sender = sender;

            //< guna2CustomCheckBox5_Click > d__.e = e;

            //< guna2CustomCheckBox5_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox5_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox5_Click > d__113 > (ref < guna2CustomCheckBox5_Click > d__);
        }

        // Token: 0x060000D8 RID: 216 RVA: 0x00006F2C File Offset: 0x0000512C
        private void guna2CustomCheckBox10_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (this.guna2CustomCheckBox10.Checked)
                {
                    this.processingCheckBoxChange = true;
                    this.recCHECK = true;
                    this.recSIGN = "00 00 FA 43 DB 0F 49 40 F0 B5 03 AF 93 B0";
                    this.guna2CustomCheckBox_7.Checked = false;
                    this.guna2CustomCheckBox_6.Checked = false;
                    this.guna2CustomCheckBox_5.Checked = false;
                    this.processingCheckBoxChange = false;
                }
                else
                {
                    this.recCHECK = false;
                }
            }
        }

        // Token: 0x060000D9 RID: 217 RVA: 0x00006FA0 File Offset: 0x000051A0
        private void guna2CustomCheckBox9_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (!this.guna2CustomCheckBox_7.Checked)
                {
                    this.recCHECK = false;
                }
                else
                {
                    this.processingCheckBoxChange = true;
                    this.recCHECK = true;
                    this.recSIGN = "00 00 2F 44 DB 0F 49 40 F0 B5 03 AF 93 B0";
                    this.guna2CustomCheckBox10.Checked = false;
                    this.guna2CustomCheckBox_6.Checked = false;
                    this.guna2CustomCheckBox_5.Checked = false;
                    this.processingCheckBoxChange = false;
                }
            }
        }

        // Token: 0x060000DA RID: 218 RVA: 0x00007014 File Offset: 0x00005214
        private void guna2CustomCheckBox8_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (!this.guna2CustomCheckBox_6.Checked)
                {
                    this.recCHECK = false;
                }
                else
                {
                    this.processingCheckBoxChange = true;
                    this.recCHECK = true;
                    this.recSIGN = "00 80 6D 44 DB 0F 49 40 F0 B5 03 AF 93 B0";
                    this.guna2CustomCheckBox_7.Checked = false;
                    this.guna2CustomCheckBox10.Checked = false;
                    this.guna2CustomCheckBox_5.Checked = false;
                    this.processingCheckBoxChange = false;
                }
            }
        }

        // Token: 0x060000DB RID: 219 RVA: 0x00007088 File Offset: 0x00005288
        private void guna2CustomCheckBox6_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (this.guna2CustomCheckBox_5.Checked)
                {
                    this.processingCheckBoxChange = true;
                    this.recCHECK = true;
                    this.recSIGN = "A0 C2 22 49 DB 0F 49 40 F0 B5 03 AF 93 B0";
                    this.guna2CustomCheckBox_7.Checked = false;
                    this.guna2CustomCheckBox_6.Checked = false;
                    this.guna2CustomCheckBox10.Checked = false;
                    this.processingCheckBoxChange = false;
                }
                else
                {
                    this.recCHECK = false;
                }
            }
        }

        // Token: 0x060000DC RID: 220 RVA: 0x000070FC File Offset: 0x000052FC
        private void label34_Click(object sender, EventArgs e)
        {
            this.guna2Panel_3.Visible = false;
            this.guna2Panel_5.Visible = false;
            this.guna2Panel12.Visible = false;
            this.guna2Panel10.Visible = false;
            this.guna2Panel_7.Visible = false;
            this.guna2Panel14.Visible = true;
            this.label5.ForeColor = Color.White;
            this.label34.ForeColor = this.colorDialog1.Color;
            this.label1.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label2.ForeColor = Color.White;
        }

        // Token: 0x060000DD RID: 221 RVA: 0x00002240 File Offset: 0x00000440
        private void guna2CustomCheckBox25_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x060000DE RID: 222 RVA: 0x000071B8 File Offset: 0x000053B8
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2Button4_Click > d__120 < guna2Button4_Click > d__ = new Priavte.< guna2Button4_Click > d__120();

            //< guna2Button4_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2Button4_Click > d__.<> 4__this = this;

            //< guna2Button4_Click > d__.sender = sender;

            //< guna2Button4_Click > d__.e = e;

            //< guna2Button4_Click > d__.<> 1__state = -1;

            //< guna2Button4_Click > d__.<> t__builder.Start < Priavte.< guna2Button4_Click > d__120 > (ref < guna2Button4_Click > d__);
        }

        // Token: 0x060000DF RID: 223 RVA: 0x00007208 File Offset: 0x00005408
        public string Translate(string x)
        {
            string text = int.Parse(x).ToString("X8");
            string text2 = text.Substring(0, 2);
            string text3 = text.Substring(2, 2);
            string text4 = text.Substring(4, 2);
            string text5 = text.Substring(6, 2);
            return string.Concat(new string[]
            {
                text5,
                " ",
                text4,
                " ",
                text3,
                " ",
                text2
            });
        }

        // Token: 0x060000E0 RID: 224 RVA: 0x0000729C File Offset: 0x0000549C
        private void guna2CustomCheckBox23_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (this.guna2CustomCheckBox23.Checked)
                {
                    this.processingCheckBoxChange = true;
                    this.aimCHECK = true;
                    this.aimSIGN = "00 00 80 3F B0 B5 0C 46 06 49 05 46 E0 69 79 44 FD F6";
                    this.guna2CustomCheckBox_3.Checked = false;
                    this.guna2CustomCheckBox_1.Checked = false;
                    this.guna2CustomCheckBox_2.Checked = false;
                    this.guna2CustomCheckBox22.Checked = false;
                    this.processingCheckBoxChange = false;
                }
                else
                {
                    this.aimCHECK = false;
                }
            }
        }

        // Token: 0x060000E1 RID: 225 RVA: 0x0000731C File Offset: 0x0000551C
        private void guna2CustomCheckBox24_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox24_Click > d__123 < guna2CustomCheckBox24_Click > d__ = new Priavte.< guna2CustomCheckBox24_Click > d__123();

            //< guna2CustomCheckBox24_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox24_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox24_Click > d__.sender = sender;

            //< guna2CustomCheckBox24_Click > d__.e = e;

            //< guna2CustomCheckBox24_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox24_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox24_Click > d__123 > (ref < guna2CustomCheckBox24_Click > d__);
        }

        // Token: 0x060000E2 RID: 226 RVA: 0x0000736C File Offset: 0x0000556C
        private void guna2CustomCheckBox25_Click_1(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox25_Click_1 > d__124 < guna2CustomCheckBox25_Click_1 > d__ = new Priavte.< guna2CustomCheckBox25_Click_1 > d__124();

            //< guna2CustomCheckBox25_Click_1 > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox25_Click_1 > d__.<> 4__this = this;

            //< guna2CustomCheckBox25_Click_1 > d__.sender = sender;

            //< guna2CustomCheckBox25_Click_1 > d__.e = e;

            //< guna2CustomCheckBox25_Click_1 > d__.<> 1__state = -1;

            //< guna2CustomCheckBox25_Click_1 > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox25_Click_1 > d__124 > (ref < guna2CustomCheckBox25_Click_1 > d__);
        }

        // Token: 0x060000E3 RID: 227 RVA: 0x000073BC File Offset: 0x000055BC
        private void guna2CustomCheckBox26_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox26_Click > d__125 < guna2CustomCheckBox26_Click > d__ = new Priavte.< guna2CustomCheckBox26_Click > d__125();

            //< guna2CustomCheckBox26_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox26_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox26_Click > d__.sender = sender;

            //< guna2CustomCheckBox26_Click > d__.e = e;

            //< guna2CustomCheckBox26_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox26_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox26_Click > d__125 > (ref < guna2CustomCheckBox26_Click > d__);
        }

        private void guna2CustomCheckBox27_Click(object sender, EventArgs e)
        {
            //Priavte.< guna2CustomCheckBox27_Click > d__126 < guna2CustomCheckBox27_Click > d__ = new Priavte.< guna2CustomCheckBox27_Click > d__126();

            //< guna2CustomCheckBox27_Click > d__.<> t__builder = AsyncVoidMethodBuilder.Create();

            //< guna2CustomCheckBox27_Click > d__.<> 4__this = this;

            //< guna2CustomCheckBox27_Click > d__.sender = sender;

            //< guna2CustomCheckBox27_Click > d__.e = e;

            //< guna2CustomCheckBox27_Click > d__.<> 1__state = -1;

            //< guna2CustomCheckBox27_Click > d__.<> t__builder.Start < Priavte.< guna2CustomCheckBox27_Click > d__126 > (ref < guna2CustomCheckBox27_Click > d__);
        }

        // Token: 0x060000E5 RID: 229 RVA: 0x0000745C File Offset: 0x0000565C
        private void guna2CustomCheckBox22_Click(object sender, EventArgs e)
        {
            if (!this.processingCheckBoxChange)
            {
                if (this.guna2CustomCheckBox22.Checked)
                {
                    this.processingCheckBoxChange = true;
                    this.aimCHECK = true;
                    this.aimSIGN = "0A D7 23 3E B0 B5 0C 46 06 49 05 46 E0 69 79 44 FD F6";
                    this.guna2CustomCheckBox_2.Checked = false;
                    this.guna2CustomCheckBox_1.Checked = false;
                    this.guna2CustomCheckBox_3.Checked = false;
                    this.guna2CustomCheckBox23.Checked = false;
                    this.processingCheckBoxChange = false;
                }
                else
                {
                    this.aimCHECK = false;
                }
            }
        }

        // Token: 0x060000E6 RID: 230 RVA: 0x000074DC File Offset: 0x000056DC
        private void Priavte_Load(object sender, EventArgs e)
        {
            this.guna2Panel10.Visible = false;
            this.guna2Panel_7.Visible = false;
            this.guna2Panel14.Visible = false;
        }

        // Token: 0x04000053 RID: 83
        private List<Tuple<string, string>> SchId = new List<Tuple<string, string>>();

        // Token: 0x04000054 RID: 84
        public Mem m = new Mem();

        // Token: 0x04000055 RID: 85
        public string aimADR;

        // Token: 0x04000056 RID: 86
        public string recADR;

        // Token: 0x04000057 RID: 87
        public string heADR;

        // Token: 0x04000058 RID: 88
        public string aADR;

        // Token: 0x04000059 RID: 89
        public string wallADR;

        // Token: 0x0400005A RID: 90
        public string allADR;

        // Token: 0x0400005B RID: 91
        public string llADR;

        // Token: 0x0400005C RID: 92
        public string lADR;

        // Token: 0x0400005D RID: 93
        public string wADR;

        // Token: 0x0400005E RID: 94
        public string walADR;

        // Token: 0x0400005F RID: 95
        public string waADR;

        // Token: 0x04000060 RID: 96
        public string flADR;

        // Token: 0x04000061 RID: 97
        public string rADR;

        // Token: 0x04000062 RID: 98
        public string string_0;

        // Token: 0x04000063 RID: 99
        public string string_1;

        // Token: 0x04000064 RID: 100
        public string flashADR;

        // Token: 0x04000065 RID: 101
        public string clipADR;

        // Token: 0x04000066 RID: 102
        public string cipADR;

        // Token: 0x04000067 RID: 103
        public string lipADR;

        // Token: 0x04000068 RID: 104
        public string ipADR;

        // Token: 0x04000069 RID: 105
        private bool aimCHECK = false;

        // Token: 0x0400006A RID: 106
        private bool heCHECK = false;

        // Token: 0x0400006B RID: 107
        private bool bool_0 = false;

        // Token: 0x0400006C RID: 108
        private bool allCHECK = false;

        // Token: 0x0400006D RID: 109
        private bool llCHECK = false;

        // Token: 0x0400006E RID: 110
        private bool lCHECK = false;

        // Token: 0x0400006F RID: 111
        private bool walCHECK = false;

        // Token: 0x04000070 RID: 112
        private bool wCHECK = false;

        // Token: 0x04000071 RID: 113
        private bool waCHECK = false;

        // Token: 0x04000072 RID: 114
        private bool flCHECK = false;

        // Token: 0x04000073 RID: 115
        private bool rCHECK = false;

        // Token: 0x04000074 RID: 116
        private bool aCHECK = false;

        // Token: 0x04000075 RID: 117
        private bool addscoreCHECK = false;

        // Token: 0x04000076 RID: 118
        private bool adscoreCHECK = false;

        // Token: 0x04000077 RID: 119
        private bool recCHECK = false;

        // Token: 0x04000078 RID: 120
        private bool bool_1 = false;

        // Token: 0x04000079 RID: 121
        private bool bool_2 = false;

        // Token: 0x0400007A RID: 122
        private bool cipCHECK = false;

        // Token: 0x0400007B RID: 123
        private bool lipCHECK = false;

        // Token: 0x0400007C RID: 124
        private bool ipCHECK = false;

        // Token: 0x0400007D RID: 125
        private string aimSIGN = "";

        // Token: 0x0400007E RID: 126
        private string heSIGN = "";

        // Token: 0x0400007F RID: 127
        private string wallSIGN = "";

        // Token: 0x04000080 RID: 128
        private string allSIGN = "";

        // Token: 0x04000081 RID: 129
        private string llSIGN = "";

        // Token: 0x04000082 RID: 130
        private string lSIGN = "";

        // Token: 0x04000083 RID: 131
        private string walSIGN = "";

        // Token: 0x04000084 RID: 132
        private string waSIGN = "";

        // Token: 0x04000085 RID: 133
        private string wSIGN = "";

        // Token: 0x04000086 RID: 134
        private string flSIGN = "";

        // Token: 0x04000087 RID: 135
        private string rSIGN = "";

        // Token: 0x04000088 RID: 136
        private string aSIGN = "";

        // Token: 0x04000089 RID: 137
        private string recSIGN = "";

        // Token: 0x0400008A RID: 138
        private string addscoreSIGN = "";

        // Token: 0x0400008B RID: 139
        private string string_2 = "";

        // Token: 0x0400008C RID: 140
        private string string_3 = "";

        // Token: 0x0400008D RID: 141
        private string clipSIGN = "";

        private string cipSIGN = "";

        private string lipSIGN = "";

        private string ipSIGN = "";

        private static IKeyboardMouseEvents _hook;

        public static string InfoBind;

        public watermark watermarkForm;

        private bool processingCheckBoxChange = false;

        private Point lastPoint;

        private bool isWaitingForKey = false;

        private Keys selectedBind;
    }
}
