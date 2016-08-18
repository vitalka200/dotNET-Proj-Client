﻿using finalClient.CheckersService;
using finalClient.HelperUtil;
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
        private GameBoard GameBoard;


        public void InitHistoryParams(GameBoard gameBoard)
        {
            InitializeComponent();
            this.GameBoard = gameBoard;
        }

        //public int UserID { get; set;}
        //public String UserName { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            pictureBoxHistory.Image = Util.resizeImage(Properties.Resources.history, 173, 245);
            historyGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var games =
                (from g in GameBoard.SoapService.GetGamesByPlayer(GameBoard.ActivePlayer)
                let winner = g.WinnerPlayerNum == 1 ? g.Player1.Name : g.Player2.Name
                //where g.GameStatus == CheckersService.Status.GAME_COMPLETED
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
                int gameId = (int)historyGridView.SelectedRows[0].Cells[0].Value;
                Move[] allMoves = GameBoard.SoapService.RecoverGameMovesByPlayer();
            }
        }
    }
}
