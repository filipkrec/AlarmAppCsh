using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace AlarmAppCsh
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hr-HR");
            foreach (CultureInfo cl in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                comboBox1.Items.Add(cl.NativeName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(timer);
            t.Start();
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void timer(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToShortDateString(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (CultureInfo cl in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                if (cl.NativeName.Equals(comboBox1.SelectedItem.ToString()))
                {
                    Thread.CurrentThread.CurrentCulture = cl;
                    break;
                }
            }
        }
    }
}
