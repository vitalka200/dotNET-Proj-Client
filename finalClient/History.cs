using finalClient.Logic;
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
    public partial class History : Form
    {
        private BindingSource TblBindingSource = new BindingSource();

        public History(int userId, string userName)
        {
            InitializeComponent();
            UserID = userId;
            UserName = userName;
        //    MoveList = new List<Move>();
        }

        public int UserID { get; set;}
        public String UserName { get; set; }
    //    public List<Move> MoveList { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            pictureBoxHistory.Image = Util.resizeImage(Properties.Resources.history, 173, 245);
            historyGridView.DataSource = "";
        }

        private void btnMoves_Click(object sender, EventArgs e)
        {
            //return to previous window list of moves
        }
    }
}
