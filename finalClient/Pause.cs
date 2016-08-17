using finalClient.HelperUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalClient
{
    public partial class Pause : Form
    {
        Timer t = new Timer();

        public Pause()
        {
            InitializeComponent();
        }

        private void Pause_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Util.resizeImage(Properties.Resources.time_for_a_break, 100, 100);
            clockTime.Text = DateTime.Now.ToString();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loaded
            t.Start();
        }

        //timer event handler
        private void t_Tick(object sender, EventArgs e)
        {
            //Current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            String time = "";
            if (hh < 10) { time += "0" + hh; }
            else { time += hh; }
            time += ":";
            if (mm < 10) { time += "0" + mm; }
            else { time += mm; }
            time += ":";
            if (ss < 10) { time += "0" + ss; }
            else { time += ss; }

            clockTime.Text = time;
        }
    }
}
