using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmAppCsh
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        int timeZone = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer);
            t.Start();
        }

        private void timer(object sender, EventArgs e)
        {
            DateTime Today = DateTime.UtcNow;
            int h = Today.Hour + timeZone;
            if(h > 24)
            {
                Today = Today.AddDays(1);
                h = h % 24;
            }
            else if (h < 0)
            {
                Today = Today.AddDays(-1);
                h = Math.Abs(h);
            }

            string time = "";
            time += h;
            time += ":";
            time += Today.Minute;
            time += ":";
            time += Today.Second;
            lbClock.Text = time;

            string date = "";
            date += Today.Day;
            date += ".";
            date += Today.Month;
            date += ".";
            date += Today.Year;
            date += ".";
            lbDate.Text = date;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    timeZone = 0; break;
                case 1:
                    timeZone = 1; break;
                case 2:
                    timeZone = 2; break;
                case 3:
                    timeZone = 3; break; 
                case 4:
                    timeZone = 4; break;
                case 5:
                    timeZone = 5; break;
                case 6:
                    timeZone = 6; break;
                case 7:
                    timeZone = 7; break;
                case 8:
                    timeZone = 8; break;
                case 9:
                    timeZone = 9; break;
                case 10:
                    timeZone = 10; break;
                case 11:
                    timeZone = 11; break;
                case 12:
                    timeZone = 12; break;
                case 13:
                    timeZone = 13; break;
                case 14:
                    timeZone = 14; break;
                case 15:
                    timeZone = -1; break;
                case 16:
                    timeZone = -2; break;
                case 17:
                    timeZone = -3; break;
                case 18:
                    timeZone = -4; break;
                case 19:
                    timeZone = -5; break;
                case 20:
                    timeZone = -6; break;
                case 21:
                    timeZone = -7; break;
                case 22:
                    timeZone = -8; break;
                case 23:
                    timeZone = -9; break;
                case 24:
                    timeZone = -10; break;
                case 25:
                    timeZone = -11; break;
                case 26:
                    timeZone = -12; break;
                default: break; 

                    
            }
            comboBox1.SelectedValueChanged += new EventHandler(this.timer);
        }
    }
}
