using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace finalClient
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            /* String id = "";
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\FinalProject.mdf;Integrated Security=True;Connect Timeout=30");
             SqlCommand cmd = new SqlCommand("SELECT Id FROM Users WHERE USERNAME='" + userTextBox.Text + "' and PASSWORD='" + passwordTextBox.Text + "'");
             SqlDataReader data = null;
             try
             {

                 cmd.Connection = con;
                 con.Open();
                 data = cmd.ExecuteReader();
                 id = (data["Id"].ToString());
                 con.Close();
             } catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             MessageBox.Show("Id = " + id);*/
            this.Hide();
            (new GameBoard(1, "USER1", this)).Show();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
