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
using finalClient.CheckersService;
using finalClient.Logic;

namespace finalClient
{
    public partial class Login : Form
    {
        public ISoapCheckersService SoapService { get; private set; }
        public DuplexCheckersServiceClient DuplexService { get; private set; }
        public CheckersServiceCallbackHandler ServiceCallBackHandler { get; private set; }

        private GameBoard gameBoard = new GameBoard();
        private History history = new History();
        private GameChooser gameChoser = new GameChooser();

        public Login()
        {
            InitializeComponent();
            SoapService = new SoapCheckersServiceClient();
            ServiceCallBackHandler = new CheckersServiceCallbackHandler();

            ServiceCallBackHandler.Login = this;
            ServiceCallBackHandler.History = history;
            ServiceCallBackHandler.GameChooser = gameChoser;
            ServiceCallBackHandler.GameBoard = gameBoard;

            DuplexService = new DuplexCheckersServiceClient(new System.ServiceModel.InstanceContext(ServiceCallBackHandler));

            gameBoard.Login = this;
            gameBoard.DuplexService = DuplexService;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DuplexService.Login(userTextBox.Text, passwordTextBox.Text);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
