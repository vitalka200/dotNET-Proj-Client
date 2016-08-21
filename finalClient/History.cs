using finalClient.CheckersService;
using finalClient.HelperUtil;
using finalClient.Logic;
using finalClient.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalClient
{
    public partial class History : Form
    {
        private BindingSource TblBindingSource = new BindingSource();
        private GameBoard GameBoard;
        private List<Game> PlayerGames { get; set; }


        public void InitHistoryParams(GameBoard gameBoard)
        {
            InitializeComponent();
            this.GameBoard = gameBoard;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            pictureBoxHistory.Image = Util.resizeImage(Properties.Resources.history, 173, 245);
            historyGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PlayerGames = GameBoard.SoapService.GetGamesByPlayer(GameBoard.ActivePlayer).ToList();
            var games =
                (from g in PlayerGames
                let winner = g.WinnerPlayerNum == 1 ? g.Player1.Name : (g.WinnerPlayerNum == 2 ? g.Player2.Name : "No Winner" )
                where g.GameStatus == CheckersService.Status.GAME_COMPLETED
                select new { Id = g.Id,
                    CreationDate = g.CreatedDateTime,
                    Player1Name = g.Player1.Name,
                    Player2Name = g.Player2.Name,
                    Winner = winner}).ToList();
            if (games.Count > 0)
            {
                TblBindingSource.DataSource = games;
                historyGridView.DataSource = TblBindingSource;
            }
            else
            {
                MessageBox.Show("There is no completed games", "Info");
                this.Dispose();
            }
        }

        private void btnMoves_Click(object sender, EventArgs e)
        {
            //return to previous window list of moves
            if(historyGridView.SelectedRows.Count > 0)
            {
                int gameId = Convert.ToInt32(historyGridView.SelectedRows[0].Cells[0].Value);
                List<Move> allMoves = GameBoard.SoapService.RecoverGameMovesByGameId(gameId).ToList();
                Game game = PlayerGames.Where(g=>g.Id == gameId).First();
                this.Dispose();
                GameBoard.InitNewGame();
                
                GameBoard.Login.ServiceCallBackHandler.StartGameCallback(game, Status.GAME_STARTED);

                foreach (Move move in allMoves)
                {
                    if (move.From.X != -1)
                    {
                        GameBoard.Login.ServiceCallBackHandler.PlayerTurnCallback(move);
                        Thread.Sleep(50);
                    }
                }
                if (allMoves.Count() > 0)
                {
                    Player winner = game.WinnerPlayerNum == 1 ? game.Player1 : game.Player2;
                    if (game.WinnerPlayerNum != 0)
                    {
                        Status status = GameBoard.ActivePlayer.Id == winner.Id ? Status.GAME_WIN : Status.GAME_LOSE;
                        GameBoard.Login.ServiceCallBackHandler.GameEnd(game, allMoves.Last(), status);
                    }
                }

            }
        }
    }
}
