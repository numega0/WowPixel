using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;
using AutoItX3Lib;

namespace WowPixel
{


    public partial class frmWowPixel : Form
    {
        [DllImport("user32.dll")]

        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;

        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        AutoItX3 au3 = new AutoItX3();

        Keys jey = Keys.Space;
        Keys mey = Keys.Space;
        Keys FireKey = Keys.D3;
        public frmWowPixel()
        {
            InitializeComponent();
        }

        bool DUR = false;
        string Renk;

        int x = 22;

        public static Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }


        private void tmrCursor_Tick(object sender, EventArgs e)
        {
            lblCursor.Text = Cursor.Position.X.ToString() + "/" + Cursor.Position.Y.ToString() + " = " + HexConverter(GetColorAt(Cursor.Position.X, Cursor.Position.Y));


            if (DUR == false)
            {
                Renk = HexConverter(GetColorAt(1119, 582));

                switch (Renk)
                {
                    case "#8CFBFF":
                        {
                            tmrSpam.Enabled = false;
                            SendKeys.Send(txtKey1.Text);
                            break;
                        }
                    default:
                        tmrSpam.Enabled = true;
                        break;
                }
            }


            Renk = HexConverter(GetColorAt(1161, 594));

            switch (Renk)
            {
                case "#F7FFFF":
                    {
                        tmrSpam.Enabled = false;
                        DUR = true;
                        SendKeys.Send(txtKey2.Text);
                        break;
                    }
                default:
                    {
                        DUR = false;
                        tmrSpam.Enabled = true;
                        break;
                    }
            }




        }

        private void tmrSpam_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.D3) < 0)
            {


                Renk = HexConverter(GetColorAt(487, 584));

                switch (Renk)
                {
                    case "#96F1F8":
                        {
                            SendKeys.Send("1");
                            break;
                        }
                    default:
                        SendKeys.Send(txtKey3.Text);
                        break;
                }

            }
        }

        private void chkTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrigger.Checked == true)
            {
                tmrCursor.Enabled = true;
            }
            else
            {
                tmrCursor.Enabled = false;
            }
        }

        private void chkSpam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpam.Checked == true)
            {
                tmrSpam.Enabled = true;
            }
            else
            {
                tmrSpam.Enabled = false;
            }
        }


        private void tmrFortniteTrigger_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.Q) < 0)
            {

                Task.Delay(10).ContinueWith(t => MouseClickYolla());
            }
        }

        void MouseClickYolla()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, MousePosition.X, MousePosition.Y);
            mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, MousePosition.X, MousePosition.Y);
        }

        private void chkRogueTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRogueTrigger.Checked == true)
            {

                textBox2.Enabled = false;

            }
            else
            {
                textBox2.Enabled = true;

            }
        }

        private void tmrRogueSpam_Tick(object sender, EventArgs e)
        {
            if (chkMonk.Checked == true)
            {
                if (GetAsyncKeyState(mey) < 0)
                {
                    Renk = HexConverter(GetColorAt(1178, 615));
                    Console.WriteLine(Renk);
                    switch (Renk)
                    {
                        case "#646157":
                            {
                                SendKeys.Send("1");
                                break;
                            }
                        case "#202D28":
                            {
                                SendKeys.Send("2");
                                break;
                            }

                        case "#EDD97C":
                            {
                                SendKeys.Send("4");
                                break;
                            }
                        case "#001FA5":
                            {
                                SendKeys.Send("3");
                                break;
                            }
                        //#091518
                        case "#091518":
                            {
                                SendKeys.Send("5");
                                break;
                            }

                    }

                }

            }



            if (chkRogueTrigger.Checked == true)
            {

                if (GetAsyncKeyState(jey) < 0 )
                {

                    Console.WriteLine("Garrote buff -> " + HexConverter(GetColorAt(1073, 558)));
                    if (HexConverter(GetColorAt(1073, 558)) == "#000000")
                    {
                        //SendKeys.Send("5");
                        SendKeys.Send("5");
                    }

                    Renk = HexConverter(GetColorAt(1119, 550));
                    Console.WriteLine("Orta - > " + Renk);
                    switch (Renk)
                    {
                        case "#CAA08A": // garrote
                            {
                                if (chkVanish.Checked == true)
                                {
                                    Console.WriteLine("Vanish -> " + HexConverter(GetColorAt(1080, 599)));

                                    if (HexConverter(GetColorAt(1080, 599)) == "#6B7984")
                                    {
                                        SendKeys.Send("Q");
                                    }
                                }
                                //SendKeys.Send("5");
                                SendKeys.Send("5");
                                break;
                            }

                        case "#474347": // rupture
                            {
                                SendKeys.Send("4");
                                break;
                            }
                        case "#C4D693": //envenom & crimson tempest
                            {
                                Console.WriteLine("Crimson -> " + HexConverter(GetColorAt(1081, 535)));
                                if (HexConverter(GetColorAt(1081, 535)) == "#C9C8D4")
                                {
                                    SendKeys.Send("9");
                                }
                                else
                                {
                                    SendKeys.Send("2");
                                }


                                break;
                            }
                        case "#1D5AB2": // mutilate
                            {
                                if (chkAoe.Checked == true)
                                {

                                    if (HexConverter(GetColorAt(1111, 600)) == "#CE149C")
                                    {
                                        Console.WriteLine("Fan of Knives -> " + HexConverter(GetColorAt(1111, 600)));
                                        SendKeys.Send("7");
                                    }
                                    else
                                    {
                                        SendKeys.Send("3");
                                    }
                                }
                                else
                                {
                                    SendKeys.Send("3");
                                }


                                break;
                            }
                        case "#33E72E": // toxic blade & exsanguinate
                            {
                                SendKeys.Send("6");
                                break;
                            }

                        /////////////////////// SUBLETY
                        case "#C0A182":
                            {

                                if (HexConverter(GetColorAt(1199, 566)) == "#290400") // Shadow Dance
                                {
                                    if (HexConverter(GetColorAt(1170, 567)) == "#080417") // Symbols of Death
                                    {
                                        SendKeys.Send("6");
                                        SendKeys.Send("5");
                                    }
                                    else
                                    {
                                        SendKeys.Send("5");
                                    }


                                }

                                if (chkVanish.Checked == true)
                                {
                                    if (HexConverter(GetColorAt(1080, 599)) == "#6B7984")
                                    {
                                        SendKeys.Send("Q");
                                    }
                                }

                                SendKeys.Send("2");
                                break;
                            }

                        case "#9E5A63":
                            {


                                SendKeys.Send("2");
                                break;
                            }

                        case "#625968":
                            {
                                SendKeys.Send("4");
                                break;
                            }

                        case "#241712":
                            {
                                SendKeys.Send("3");
                                break;
                            }



                            ///////////////////////////////////

                    }

                    if (HexConverter(GetColorAt(1231, 570)) == "#3F2746")
                    {
                        SendKeys.Send("6");
                    }
                }


            }

            if (chkShadowStep.Checked == true)
            {
                if (GetAsyncKeyState(Keys.F11) < 0)
                {
                    Console.WriteLine("F11 BASIYO");

                    Renk = HexConverter(GetColorAt(859, 534));
                    Console.WriteLine("Shadowstep > " + Renk);
                    if (Renk == "#150E2D")
                    {
                        SendKeys.Send("{F10}");
                    }

                    Renk = HexConverter(GetColorAt(525, 191));
                    Console.WriteLine("Kidney / Cheapshot > " + Renk);

                    if (Renk == "#BC1F00")
                    {
                        SendKeys.Send("{F6}");
                    }

                    else if (Renk == "#9F9087") // #1D1E1C  151312
                    {
                        SendKeys.Send("{F8}");
                    }


                }


                if (GetAsyncKeyState(Keys.F12) < 0)
                {
                    Console.WriteLine("F12 BASIYO");
                    Renk = HexConverter(GetColorAt(812, 243));



                    if (Renk == "#CEC19A")
                    {
                        SendKeys.Send("{F5}");
                    }
                    else
                    {
                        Renk = HexConverter(GetColorAt(458, 190));

                        if (Renk == "#F4D3AD")
                        {

                            SendKeys.Send("{F7}");
                        }
                    }

                }





            }



        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            jey = e.KeyCode;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tmrF.Enabled = true;
                tmrGeri.Enabled = true;

            }

            else
            {
                tmrF.Enabled = false;
                tmrGeri.Enabled = false;
                tmrYakala.Enabled = false;
            }

        }

        private void tmrF_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("1");
            x = 22;
            labelYakala.Text = "";

            Cursor.Position = new Point(600, 200);
            tmrYakala.Enabled = true;
        }

        private void tmrGeri_Tick(object sender, EventArgs e)
        {
            x--;
            label7.Text = x.ToString();

            if (x == 1)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);

            }

        }

        private void tmrYakala_Tick(object sender, EventArgs e)
        {

            if (Cursor.Position.X > 930)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(600, Cursor.Position.Y + 25);
            }

            if (Cursor.Position.Y > 331)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(600, 200);
            }

            if (HexConverter(GetColorAt(1517, 692)) == "#000000")
            {
                labelYakala.Text = "Yakalandı";
                tmrYakala.Enabled = false;
                Cursor.Position = new Point(Cursor.Position.X - 2, Cursor.Position.Y + 2);

            }
            else
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X + 5, Cursor.Position.Y);
            }

        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            mey = e.KeyCode;
        }

        private void chkFireTriggerKey_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFireTriggerKey.Checked == true)
            {

                txtFireTriggerKey.Enabled = false;

            }
            else
            {
                txtFireTriggerKey.Enabled = true;

            }
        }

        private void txtFireTriggerKey_KeyDown(object sender, KeyEventArgs e)
        {
            FireKey = e.KeyCode;
        }

        private void tmrFire_Tick(object sender, EventArgs e)
        {

            if (chkFireTriggerKey.Checked)
            {
                if (GetAsyncKeyState(FireKey) < 0)
                {
                    Renk = HexConverter(GetColorAt(1157, 550));
                    Console.WriteLine(Renk);
                    switch (Renk)
                    {
                        case "#FFDC55":
                            {
                                SendKeys.Send("9");
                                break;
                            }
                        case "#FFF7DE":
                            {
                                SendKeys.Send("2");
                                break;
                            }

                        case "#FFFDBF":
                            {

                                Renk = HexConverter(GetColorAt(1125, 552));
                                if (Renk == "#FFFBCE")
                                {
                                    SendKeys.Send("4");
                                }
                                else
                                {
                                    SendKeys.Send("3");
                                }


                                break;


                            }
                        case "#390C00":
                            {
                                SendKeys.Send("4");
                                break;
                            }


                    }
                }
            }

        }




    }
}

