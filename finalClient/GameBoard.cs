﻿using finalClient.HelperUtil;
using finalClient.Logic;
using finalClient.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace finalClient
{
    public partial class GameBoard : Form
    {
        const int ROW_HEIGTH = 61;
        const int NUMBER_OF_ROWS = 8;
        const int NUMBER_OF_COLS = 4;
        
        public int RivalId { get; set; }

        private int cellWidth;
        private int cellHeight;
        private int checkerWidth;
        private int checkerHeight;

        private DataCellInfo[,] data = new DataCellInfo[NUMBER_OF_ROWS, NUMBER_OF_COLS];
        private CheckerView[] checkers = new CheckerView[8];
        private PotentialSteps lastMoves = new PotentialSteps();

        public CheckersService.Game ActiveGame { get; set; }
        public CheckersService.Player ActivePlayer { get; set; }
        public CheckersService.ISoapCheckersService SoapService { get; set; }
        public CheckersService.DuplexCheckersServiceClient DuplexService { get; set; }
        public Login Login { get; set; }

        public bool turn { get; set; }
        private bool isGameOver = false;

        private Image blackChaker = Properties.Resources.black_checker;
        private Image whiteChecker = Properties.Resources.white_checker;
        private Image blackChakerKing = Properties.Resources.black_checker_king;
        private Image whiteCheckerKing = Properties.Resources.white_checker_king;


        public GameBoard()
        {
            InitializeComponent();
            lblUserColor.Visible = false;
            lblRivalName.Visible = false;
            lblRivalColor.Visible = false;

        }


        public void AllowSecondPlayerGame()
        {
            btnFriend.Enabled = true;
        }

        public void SetPlayer(CheckersService.Player player)
        {
            lblUserName.Text = player.Name;
            this.ActivePlayer = player;
        }

        internal void updateMoves(CheckersService.Move lastMove)
        {
            CheckerView cv = getCheckerByCoordinate(lastMove.From.X, lastMove.From.Y);
            lastMoves.Cheaker = cv;
            if(cv.CheckerColor == Color.Black) { makeBlackMove(lastMove.To.X, lastMove.To.Y); }
            else { makeWhiteMove(lastMove.To.X, lastMove.To.Y); }
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back;
            LoadImageView();
            InitializeBoardGame();
            gameDataView.Enabled = false;
        }

        public CheckersService.Move CreateMoveWrapper(Coordinate from, Coordinate to)
        {
            CheckersService.Move move = new CheckersService.Move() {
                From = from,
                To = to,
                DateTime = DateTime.Now,
                GameId = ActiveGame.Id,
                PlayerId = ActivePlayer.Id
            };
            return move;
        }

        public void FirstCheakersConfig()
        {
            RivalId = ActivePlayer.Id == ActiveGame.Player1.Id ? ActiveGame.Player2.Id : ActiveGame.Player1.Id;

            cellHeight = gameDataView.Rows[0].Height;
            cellWidth = gameDataView.Columns[0].Width;
            checkerHeight = (int)(cellHeight * 0.7);
            checkerWidth = (int)(cellWidth * 0.7);

            LoadWhiteCheakers(new Point((cellWidth / 2 - checkerWidth / 2) + cellWidth, cellHeight / 2 - checkerHeight / 2));
            LoadBlackCheakers(new Point((cellWidth / 2 - checkerWidth / 2) + cellWidth, 
                              cellHeight / 2 - checkerHeight / 2 + (NUMBER_OF_ROWS - 2) * (cellHeight)));

            foreach(CheckerView cv in checkers)
            {
                cv.Parent = gameDataView;
                if (cv.UserID == ActivePlayer.Id) { cv.MouseClick += checker_MouseClick; }
            }
        }

        public void GridViewEnableFlag(bool flag)
        {
            gameDataView.Enabled = flag;
        }

        private void LoadBlackCheakers(Point point)
        {
            int playerId = ActivePlayer.Id == ActiveGame.Player1.Id ? ActivePlayer.Id : RivalId;

            List<CheckersService.Move> initialMoves = new List<CheckersService.Move>();
            CheckersService.Move move = CreateMoveWrapper(new Coordinate { X = -1, Y = -1 }, new Coordinate { X = 6, Y = 1 });
            checkers[4] = new CheckerView(5,
                                         playerId, checkerHeight, checkerWidth,
                                         move.To,
                                         move.From, 
                                         Color.Black, blackChaker, point);
            initialMoves.Add(move);
            data[6, 1].IsFill = true;
            point.X += cellWidth * 2;


            move = CreateMoveWrapper(new Coordinate { X = -1, Y = -1 }, new Coordinate { X = 6, Y = 3 });
            checkers[5] = new CheckerView(6,
                                         playerId, checkerHeight, checkerWidth,
                                         move.To,
                                         move.From,
                                         Color.Black, blackChaker, point);
            initialMoves.Add(move);
            data[6, 3].IsFill = true;
      
            point.Y += cellHeight;
            point.X = (int)((cellWidth / 2 - cellWidth / 2) + (cellWidth * 0.15));

            move = CreateMoveWrapper(new Coordinate { X = -1, Y = -1 }, new Coordinate { X = 7, Y = 0 });
            checkers[6] = new CheckerView(7,
                                          playerId, checkerHeight, checkerWidth,
                                          move.To,
                                          move.From,
                                          Color.Black, blackChaker, point);
            initialMoves.Add(move);
            data[7, 0].IsFill = true;
            point.X += cellWidth * 2;

            move = CreateMoveWrapper(new Coordinate { X = -1, Y = -1 }, new Coordinate { X = 7, Y = 2 });
            checkers[7] = new CheckerView(8,
                                          playerId, checkerHeight, checkerWidth,
                                          move.To,
                                          move.From, 
                                          Color.Black, blackChaker, point);
            initialMoves.Add(move);
            data[7, 2].IsFill = true;

            // Make sure that initial steps sent only once per player
            if (ActiveGame.Player1.Id == ActivePlayer.Id)
            {
                DuplexService.SaveInitialPositionsAsync(initialMoves.ToArray(), CheckersService.Status.GAME_STARTED);
            }
        }

        private void LoadWhiteCheakers(Point point)
        {
            int playerId = ActivePlayer.Id == ActiveGame.Player2.Id ? ActivePlayer.Id : RivalId;

            List<CheckersService.Move> initialMoves = new List<CheckersService.Move>();
            CheckersService.Move move = CreateMoveWrapper(new Coordinate { X = -1, Y = -1 }, new Coordinate { X = 0, Y = 1 });
            checkers[0] = new CheckerView(1,
                                          playerId, checkerHeight, checkerWidth,
                                          move.To, 
                                          move.From,
                                          Color.White, whiteChecker, point);
            initialMoves.Add(move);
            data[0, 1].IsFill = true;
            point.X += cellWidth * 2;

            move = CreateMoveWrapper(new Coordinate { X = -1, Y = -1 }, new Coordinate { X = 0, Y = 3 });
            checkers[1] = new CheckerView(2,
                                          playerId, checkerHeight, checkerWidth,
                                          move.To,
                                          move.From, 
                                          Color.White, whiteChecker, point);
            initialMoves.Add(move);
            data[0, 3].IsFill = true;
            point.X += cellWidth * 2;

            point.Y += cellHeight;
            point.X = (int)((cellWidth / 2 - cellWidth / 2) + (cellWidth * 0.15));

            move = CreateMoveWrapper(new Coordinate { X = -1, Y = -1 }, new Coordinate { X = 1, Y = 0 });
            checkers[2] = new CheckerView(3,
                                         playerId, checkerHeight, checkerWidth, 
                                         move.To,
                                         move.From, 
                                         Color.White, whiteChecker, point);
            initialMoves.Add(move);
            data[1, 0].IsFill = true;
            point.X += cellWidth * 2;

            move = CreateMoveWrapper(new Coordinate { X = -1, Y = -1 }, new Coordinate { X = 1, Y = 2 });
            checkers[3] = new CheckerView(4,
                                         playerId, checkerHeight, checkerWidth,
                                         move.To,
                                         move.From,
                                         Color.White, whiteChecker, point);
            initialMoves.Add(move);
            data[1, 2].IsFill = true;

            // Make sure that initial steps sent only once per player
            if (ActiveGame.Player2.Id == ActivePlayer.Id)
            {
                DuplexService.SaveInitialPositionsAsync(initialMoves.ToArray(), CheckersService.Status.GAME_STARTED);
            }
        }

        public void updateTurnPanel(bool turn)
        {
            if(!pictureBoxTurn.Visible) { pictureBoxTurn.Visible = true; }
            pictureBoxTurn.Image = null;
            if(turn) { pictureBoxTurn.Image = Util.resizeImage(blackChaker, 100, 100); }
            else { pictureBoxTurn.Image = Util.resizeImage(whiteChecker, 100, 100); }
        }

        private void checker_MouseClick(object sender, MouseEventArgs e)
        {
            List<Coordinate> stepsToRemove = new List<Coordinate>();
            List<Coordinate> stepsToAdd = new List<Coordinate>();
            CheckerView cv = (CheckerView)sender;
            CheckerView rivalChecker = null;
            if (cv.UserID == ActivePlayer.Id)
            { 
                if (lastMoves != null)
                {
                    lastMoves = null;
                    lastMoves = new PotentialSteps();
                }

                if (data[cv.CoordinatePosition.X, cv.CoordinatePosition.Y].BackColor != Color.White)
                {
                    if ((ActivePlayer.Id == cv.UserID))
                    {
                        if (cv.CheckerColor == Color.Black) { lastMoves.GetPotentialStepBlackCheakers(cv.CoordinatePosition.X, cv.CoordinatePosition.Y); }
                        else { lastMoves.GetPotentialStepWhiteCheakers(cv.CoordinatePosition.X, cv.CoordinatePosition.Y); }
                        if (lastMoves.PotentialMoves != null)
                        {
                            foreach (Coordinate step in lastMoves.PotentialMoves)
                            {
                                if ((step != null) && (step.X >= 0) && (step.Y >= 0) && (step.X <= 7) && (step.Y <= 3))
                                {
                                    if ((!data[step.X, step.Y].IsFill)) { gameDataView.Rows[step.X].Cells[step.Y].Style.BackColor = Color.Green; }
                                    else
                                    {
                                        Coordinate newStepToEatRival = new Coordinate { X = step.X, Y = step.Y };
                                        rivalChecker = getCheckerByCoordinate(step.X, step.Y);
                                        if (rivalChecker.CheckerColor != cv.CheckerColor)
                                        {
                                            if (rivalChecker.CheckerColor == Color.White)
                                            {
                                                newStepToEatRival.X -= 1;
                                                if (newStepToEatRival.Y > cv.CoordinatePosition.Y) { newStepToEatRival.Y += 1; }
                                                else { newStepToEatRival.Y -= 1; }
                                                if (newStepToEatRival.X >= 0 && newStepToEatRival.Y >= 0 && newStepToEatRival.Y <= 3) { gameDataView.Rows[newStepToEatRival.X].Cells[newStepToEatRival.Y].Style.BackColor = Color.Green; }
                                                else { stepsToRemove.Add(newStepToEatRival); }
                                            }
                                            else
                                            {
                                                newStepToEatRival.X += 1;
                                                if (newStepToEatRival.Y > cv.CoordinatePosition.Y) { newStepToEatRival.Y += 1; }
                                                else { newStepToEatRival.Y -= 1; }
                                                if (newStepToEatRival.X <= 7 && newStepToEatRival.Y >= 0 && newStepToEatRival.Y <= 3) { gameDataView.Rows[newStepToEatRival.X].Cells[newStepToEatRival.Y].Style.BackColor = Color.Green; }
                                                else { stepsToRemove.Add(newStepToEatRival); }
                                            }
                                        }
                                        stepsToRemove.Add(step);
                                        stepsToAdd.Add(newStepToEatRival);
                                    }
                                }
                            }
                        }
                        lastMoves.Cheaker = cv;
                        foreach (Coordinate step in stepsToAdd) { lastMoves.PotentialMoves.Add(step); }
                        foreach (Coordinate step in stepsToRemove) { lastMoves.PotentialMoves.Remove(step); }
                    }
                }
            }
        }

        private void LoadImageView()
        {
            pnlWhite.BackgroundImage = Util.resizeImage(whiteChecker, 50, 50);
            pnlWhite.BackgroundImageLayout = ImageLayout.Center;
            pnlBlack.BackgroundImage = Util.resizeImage(blackChaker, 50, 50);
            pnlBlack.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxTurn.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxTurn.Visible = false;
        }

        private void InitializeBoardGame()
        {
            gameDataView.Parent = boardPanel;
            gameDataView.RowCount = NUMBER_OF_ROWS;
            gameDataView.ColumnCount = NUMBER_OF_COLS;
            gameDataView.Height = ROW_HEIGTH * NUMBER_OF_ROWS;

            Image blackChecker = Properties.Resources.black_checker;
            Image whiteChecker = Properties.Resources.white_checker;

            gameDataView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            for (int row = 0; row < NUMBER_OF_ROWS; row++)
            {
                for (int col = 0; col < NUMBER_OF_COLS; col++)
                {
                    if ((row % 2 == 0) && (col % 2 == 0)) { gameDataView[col, row].Style.BackColor = Color.White; }
                    if ((row % 2 == 0) && (col % 2 == 1)) { gameDataView[col, row].Style.BackColor = Color.Black; }
                    if ((row % 2 == 1) && (col % 2 == 0)) { gameDataView[col, row].Style.BackColor = Color.Black; }
                    if ((row % 2 == 1) && (col % 2 == 1)) { gameDataView[col, row].Style.BackColor = Color.White; }

                    data[row, col] = new DataCellInfo(row, col, gameDataView[col, row].Style.BackColor);
                }
            }

            foreach (DataGridViewRow row in gameDataView.Rows)
            {
                row.Height = ROW_HEIGTH;
                row.ReadOnly = true;
            }
        }

        private void gameDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //If cheaker has choosen and the cekk that choosed is an option for this cheaker than start animation for moving checker
            if ((lastMoves.Cheaker != null) && (ActivePlayer.Id == lastMoves.Cheaker.UserID) && (
                lastMoves.IsStepExist(new Coordinate { X = e.RowIndex, Y = e.ColumnIndex })))
            {
                if (lastMoves.Cheaker.CheckerColor == Color.Black) { makeBlackMove(e.RowIndex, e.ColumnIndex); }
                else { makeWhiteMove(e.RowIndex, e.ColumnIndex); }
                foreach (Coordinate step in lastMoves.PotentialMoves)
                {
                    if (step != null) { gameDataView.Rows[step.X].Cells[step.Y].Style.BackColor = Color.Black; }
                }
                CheckersService.Move move = new CheckersService.Move {
                    GameId = ActiveGame.Id,
                    PlayerId = ActivePlayer.Id,
                    DateTime = DateTime.Now,
                    From = lastMoves.Cheaker.CoordinateOldPosiotin,
                    To = lastMoves.Cheaker.CoordinatePosition
                };
                DuplexService.MakeMoveAsync(move);

                gameDataView.ClearSelection();
                gameDataView.Enabled = false;
            }
        }

        public void makeWhiteMove(int row, int col)
        {
            CheckerView cvMayEat = null;
            bool flagEatRivalChecker = false;
            if(lastMoves.Cheaker.CoordinatePosition.X + 2 == row)
            {
                flagEatRivalChecker = true;
                int eatenRivalCheckerX = row - 1;
                int eatenRivalCheckerY = 0;
                if(col < lastMoves.Cheaker.CoordinatePosition.Y) { eatenRivalCheckerY = col + 1; }
                else { eatenRivalCheckerY = col - 1; }
                cvMayEat = getCheckerByCoordinate(eatenRivalCheckerX, eatenRivalCheckerY);
            }
            lastMoves.Cheaker.CoordinateOldPosiotin = lastMoves.Cheaker.CoordinatePosition;
            data[lastMoves.Cheaker.CoordinatePosition.X, lastMoves.Cheaker.CoordinatePosition.Y].IsFill = false;
            int x = lastMoves.Cheaker.Location.X;
            int y = lastMoves.Cheaker.Location.Y;

            if(flagEatRivalChecker)
            {
                data[cvMayEat.CoordinatePosition.X, cvMayEat.CoordinatePosition.Y].IsFill = false;

                if (lastMoves.Cheaker.CoordinatePosition.Y < col ) { x += 2 * cellWidth; }
                    else { x -= 2 * cellWidth; }
                    y += cellHeight * 2;
            }
            else
            {
                if (lastMoves.Cheaker.CoordinatePosition.Y < col) { x += cellWidth; }
                else { x -= cellWidth; }
                y += cellHeight;
            }
            if(row <= 7 && col >= 0 && col <= 3 )
            {
                if(row == 7) { lastMoves.Cheaker.Image = (Image)new Bitmap(whiteCheckerKing, checkerWidth, checkerHeight); }

                lastMoves.Cheaker.Location = new Point(x, y);
                lastMoves.Cheaker.CoordinatePosition = new Coordinate { X = row, Y = col };
                data[row, col].IsFill = true;
                if(cvMayEat != null)
                {
                    cvMayEat.InGame = false;
                    cvMayEat.Dispose();
                    lblBlackScore.Text = (Int32.Parse(lblBlackScore.Text) + 1).ToString();
                }
            }
        }

        public void makeBlackMove(int row, int col)
        {
            CheckerView cvMayEat = null;
            bool flagEatRivalChecker = false;
            if(lastMoves.Cheaker.CoordinatePosition.X - 2 == row)
            {
                flagEatRivalChecker = true;
                int eatenRivalChekerX = row + 1;
                int eatenRivalChekerY = 0;
                if (col > lastMoves.Cheaker.CoordinatePosition.Y) { eatenRivalChekerY = col - 1; }
                else { eatenRivalChekerY = col + 1; }
                cvMayEat = getCheckerByCoordinate(eatenRivalChekerX, eatenRivalChekerY);
            }
            lastMoves.Cheaker.CoordinateOldPosiotin = lastMoves.Cheaker.CoordinatePosition;
            data[lastMoves.Cheaker.CoordinatePosition.X, lastMoves.Cheaker.CoordinatePosition.Y].IsFill = false;
            int x = lastMoves.Cheaker.Location.X;
            int y = lastMoves.Cheaker.Location.Y;

            if(flagEatRivalChecker)
            {
                data[cvMayEat.CoordinatePosition.X, cvMayEat.CoordinatePosition.Y].IsFill = false;
                if (lastMoves.Cheaker.CoordinatePosition.Y < col) { x += 2 * cellWidth; }
                    else { x -= 2* cellWidth; }
                    y -= cellHeight * 2;
            } else
            {
                if (lastMoves.Cheaker.CoordinatePosition.Y < col) { x += cellWidth; }
                else { x -= cellWidth; }
                y -= cellHeight;

            }

            if(row >= 0 && col >= 0 && col <= 3)
            {
                if(row == 0) { lastMoves.Cheaker.Image = (Image)new Bitmap(blackChakerKing, checkerWidth, checkerHeight); }
                lastMoves.Cheaker.Location = new Point(x, y);
                lastMoves.Cheaker.CoordinatePosition = new Coordinate { X = row, Y = col };
                data[row, col].IsFill = true;
                lastMoves.Cheaker.Parent = gameDataView;
                if (cvMayEat != null)
                {
                    cvMayEat.InGame = false;
                    cvMayEat.Dispose();
                    lblWhiteScore.Text = (Int32.Parse(lblWhiteScore.Text) + 1).ToString();
                }
            }
        }

        public CheckerView getCheckerByCoordinate(int row, int col)
        {
            Coordinate coordinateToCheck = new Coordinate { X = row, Y = col };
            foreach (CheckerView cv in checkers)
            {
                if (cv.CoordinatePosition.Equals(coordinateToCheck)) { return cv; }
            }
            return null;
        }

        private CheckerView getCheckerByID(int id)
        {
            foreach (CheckerView cv in checkers)
            {
                if (cv.ID == id) { return cv; }
            }
            return null;
        }

        private void btnFriend_Click(object sender, EventArgs e)
        {
            GameChooser gameChooser = new GameChooser(this);
            gameChooser.Show();
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            DuplexService.StartGameAsync(new CheckersService.Game { Player1 = ActivePlayer, CreatedDateTime = DateTime.Now }, true);
            gameDataView.Enabled = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            gameDataView.Enabled = false;
            History historyWin = new History();
            historyWin.InitHistoryParams(this);
            historyWin.StartPosition = FormStartPosition.CenterParent;
            historyWin.Show();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!isGameOver)
            {
                const string message =
                         "Are you sure that you would like to start new game?";
                const string caption = "New Game";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes) { InitNewGame(); }
            } else { InitNewGame(); }
        }

        public void InitNewGame()
        {
            foreach (CheckerView cv in checkers) { if (cv != null) { cv.Dispose(); } }
            data = new DataCellInfo[NUMBER_OF_ROWS, NUMBER_OF_COLS];
            gameDataView.ClearSelection();
            InitializeBoardGame();
            gameDataView.Enabled = false;
        }

        private void GameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Login.Dispose();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            gameDataView.Enabled = false;
            Pause pasueWin = new Pause();
            pasueWin.StartPosition = FormStartPosition.CenterParent;
            pasueWin.Show();
            gameDataView.Enabled = true;
        }

        public void updateRivalPlayerName()
        {
            lblUserName.Text = "";
            if (ActivePlayer.Name.Equals(ActiveGame.Player1.Name)) //We are black
            {
                lblUserName.Text = ActivePlayer.Name;
                lblRivalName.Text = ActiveGame.Player2.Name;
                lblUserColor.Text = "as black";
                lblUserColor.ForeColor = Color.Black;
                lblRivalColor.Text = "as white";
                lblRivalColor.ForeColor = Color.White;
            }
            else //we are white
            {
                lblRivalName.Text = ActiveGame.Player1.Name;
                lblUserName.Text = ActivePlayer.Name;
                lblRivalColor.Text = "as black";
                lblRivalColor.ForeColor = Color.Black;
                lblUserColor.Text = "as white";
                lblUserColor.ForeColor = Color.White;
            }

            lblRivalName.Visible = true;
            lblRivalColor.Visible = true;
            lblUserColor.Visible = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = string.Format("Name: {0,-22} ID: {1,-10}\nName: {2,-15} ID: {3,-10}", "Vitali Karabitski", "317721652", "Dana Schvarzman", "305699282");
            MessageBox.Show(this, message, "About");
        }
    }
}
