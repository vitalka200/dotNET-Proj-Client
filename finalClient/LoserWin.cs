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
    public partial class LoserWin : Form
    {
        public LoserWin(String name)
        {
            InitializeComponent();
            lblUserName.Text = name;
            pictureBox1.Image = Util.resizeImage(Properties.Resources.loser, 215, 160);
        }
    }
}
