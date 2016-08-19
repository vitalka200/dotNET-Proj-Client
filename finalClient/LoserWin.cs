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
        private GameBoard Board { get; set; }

        public LoserWin(GameBoard Board)
        {
            this.Board = Board;
            InitializeComponent();
            lblUserName.Text = Board.ActivePlayer.Name;
            pictureBox1.Image = Util.resizeImage(Properties.Resources.loser, 215, 160);
        }

        private void LoserWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Board.InitNewGame();
        }
    }
}
