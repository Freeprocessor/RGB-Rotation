using System;
using System.Web;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Rotation
{
    public partial class Form1 : Form
    {
        public static int[] i = new int[18];
        public static int level = 10;
        public static bool autostart = false;
        public static int updown_select = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i[0] = 0;
            Color_update();
            button1.Enabled = false;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i[1] = 0;
            Color_update();
            button2.Enabled = false;
            button2.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            i[2] = 0;
            Color_update();
            button3.Enabled = false;
            button3.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            i[3] = 0;
            Color_update();
            button4.Enabled = false;
            button4.Enabled = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            i[4] = 0;
            Color_update();
            button5.Enabled = false;
            button5.Enabled = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            i[5] = 0;
            Color_update();
            button6.Enabled = false;
            button6.Enabled = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            i[6] = 0;
            Color_update();
            button7.Enabled = false;
            button7.Enabled = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            i[7] = 0;
            Color_update();
            button8.Enabled = false;
            button8.Enabled = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            i[8] = 0;
            Color_update();
            button9.Enabled = false;
            button9.Enabled = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            i[9] = 0;
            Color_update();
            button10.Enabled = false;
            button10.Enabled = true;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            i[10] = 0;
            Color_update();
            button11.Enabled = false;
            button11.Enabled = true;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            i[11] = 0;
            Color_update();
            button12.Enabled = false;
            button12.Enabled = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            i[12] = 0;
            Color_update();
            button13.Enabled = false;
            button13.Enabled = true;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            i[13] = 0;
            Color_update();
            button14.Enabled = false;
            button14.Enabled = true;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            i[14] = 0;
            Color_update();
            button15.Enabled = false;
            button15.Enabled = true;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            i[15] = 0;
            Color_update();
            button16.Enabled = false;
            button16.Enabled = true;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            i[16] = 0;
            Color_update();
            button17.Enabled = false;
            button17.Enabled = true;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            i[17] = 0;
            Color_update();
            button18.Enabled = false;
            button18.Enabled = true;
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //int j = 0;
            Reset_Color();
            Color_update();
        }
        private void btn_AutoRun_Click(object sender, EventArgs e)
        {
            if (autostart == false)
            {
                autostart = true;
                timer1.Start();
            }
            else if (autostart == true)
            {
                autostart = false;
                timer1.Stop();
            }

        }
        private void btn_StepRun_Click(object sender, EventArgs e)
        {
            if (autostart==false)
            {
                i = ShiftRight(i);
                Color_update();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Stop();
            textBox1.Text = "" + timer1.Interval;
            textBox2.Text = "200";
            Color_update();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = ShiftRight(i);
            Color_update();
        }


        private void Color_update()
        {
            int j = 0;
            int k = 0;

            for (j = 0; j < 18; j++)
            {
                if (i[j] == 0)
                    switch (j)
                    {
                        case 0:
                            button1.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 1:
                            button2.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 2:
                            button3.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 3:
                            button4.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 4:
                            button5.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 5:
                            button6.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 6:
                            button7.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 7:
                            button8.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 8:
                            button9.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 9:
                            button10.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 10:
                            button11.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 11:
                            button12.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 12:
                            button13.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 13:
                            button14.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 14:
                            button15.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 15:
                            button16.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 16:
                            button17.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case 17:
                            button18.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                    }
                if (i[j] == 1)
                    switch (j)
                    {
                        case 0:
                            button1.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 1:
                            button2.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 2:
                            button3.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 3:
                            button4.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 4:
                            button5.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 5:
                            button6.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 6:
                            button7.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 7:
                            button8.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 8:
                            button9.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 9:
                            button10.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 10:
                            button11.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 11:
                            button12.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 12:
                            button13.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 13:
                            button14.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 14:
                            button15.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 15:
                            button16.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 16:
                            button17.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                        case 17:
                            button18.BackColor = Color.FromArgb(255, 0, 0);
                            break;
                    }
                if (i[j] == 2)
                    switch (j)
                    {
                        case 0:
                            button1.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 1:
                            button2.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 2:
                            button3.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 3:
                            button4.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 4:
                            button5.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 5:
                            button6.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 6:
                            button7.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 7:
                            button8.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 8:
                            button9.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 9:
                            button10.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 10:
                            button11.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 11:
                            button12.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 12:
                            button13.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 13:
                            button14.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 14:
                            button15.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 15:
                            button16.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 16:
                            button17.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 17:
                            button18.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                    }
                if (i[j] == 3)
                    switch (j)
                    {
                        case 0:
                            button1.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 1:
                            button2.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 2:
                            button3.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 3:
                            button4.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 4:
                            button5.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 5:
                            button6.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 6:
                            button7.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 7:
                            button8.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 8:
                            button9.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 9:
                            button10.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 10:
                            button11.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 11:
                            button12.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 12:
                            button13.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 13:
                            button14.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 14:
                            button15.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 15:
                            button16.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 16:
                            button17.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                        case 17:
                            button18.BackColor = Color.FromArgb(0, 0, 255);
                            break;
                    }
            }

            for (j = 0; j < 18; j++)
            {
                if (i[j] == 0)
                {
                    k++;
                    if (k > 17)
                    {
                        k = int.Parse(textBox2.Text);
                        Delay(k);
                        Reset_Color();
                        Color_update();
                    }
                }

            }
        }
        public int[] ShiftLeft(int[] arr)
        {
            int[] demo = new int[arr.Length];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                demo[i] = arr[i + 1];
            }

            demo[demo.Length - 1] = arr[0];

            return demo;
        }

        public int[] ShiftRight(int[] arr)
        {
            int[] demo = new int[arr.Length];

            for (int i = 1; i < arr.Length; i++)
            {
                demo[i] = arr[i - 1];
            }

            demo[0] = arr[demo.Length - 1];

            return demo;
        }

        private void Reset_Color()
        {
            i[0] = 1;
            i[1] = 2;
            i[2] = 3;
            i[3] = 1;
            i[4] = 2;
            i[5] = 3;
            i[6] = 1;
            i[7] = 2;
            i[8] = 3;
            i[9] = 1;
            i[10] = 2;
            i[11] = 3;
            i[12] = 1;
            i[13] = 2;
            i[14] = 3;
            i[15] = 1;
            i[16] = 2;
            i[17] = 3;
        }
        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Move_Click(object sender, EventArgs e)
        {
            updown_select = 1;
        }
        private void Delay_Click(object sender, EventArgs e)
        {
            updown_select = 2;
        }

        private void Level_btn_Click(object sender, EventArgs e)
        {
            if (level == 10)
            {
                level = 100;
                Level_btn.Text = level + "";
            }
            else if (level == 100)
            {
                level = 1000;
                Level_btn.Text = level + "";
            }
            else if (level == 1000)
            {
                level = 10;
                Level_btn.Text = level + "";
            }
        }

        private void Up_btn_Click(object sender, EventArgs e)
        {
            if (updown_select == 1)
            {
                int i = 0;
                i = int.Parse(textBox1.Text);
                i += level;
                textBox1.Text = i + "";
                timer1.Interval = int.Parse(textBox1.Text);
            }
            else if (updown_select == 2)
            {
                int i = 0;
                i = int.Parse(textBox2.Text);
                i += level;
                textBox2.Text = i + "";
            }
        }

        private void Down_btn_Click(object sender, EventArgs e)
        {
            if (updown_select == 1)
            {
                int i = 0;
                i = int.Parse(textBox1.Text);
                i -= level;
                textBox1.Text = i + "";
                timer1.Interval = int.Parse(textBox1.Text);
            }
            else if (updown_select == 2)
            {
                int i = 0;
                i = int.Parse(textBox2.Text);
                i -= level;
                textBox2.Text = i + "";
            }
        }
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
    }
}
