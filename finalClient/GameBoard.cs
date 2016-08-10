using finalClient.Logic;
using finalClient.UI;
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
    public partial class GameBoard : Form
    {
        const int ROW_HEIGTH = 61;
        const int NUMBER_OF_ROWS = 8;
        const int NUMBER_OF_COLS = 4;

        private int userId;
        private int rivalId = -1;

        private int cellWidth;
        private int cellHeight;
        private int checkerWidth;
        private int checkerHeight;

        private DataCellInfo[,] data = new DataCellInfo[NUMBER_OF_ROWS, NUMBER_OF_COLS];
        private CheckerView[] checkers = new CheckerView[8];
        private PotentialSteps lastMoves = new PotentialSteps();

        private FromServer server = new FromServer();
        private Game newGame;
        private Login login;

        private int turn = 0;
        private bool isGameOver = false;

        private Image blackChaker = Properties.Resources.black_checker;
        private Image whiteChecker = Properties.Resources.white_checker;
        private Image blackChakerKing = Properties.Resources.black_checker_king;
        private Image whiteCheckerKing = Properties.Resources.white_checker_king;
        private Image playButton = Properties.Resources.play;
        private Image pauseButton = Properties.Resources.pasue;
        private Image undoButton = Properties.Resources.undo;

        public GameBoard(int id, String user, Login login)
        {
            InitializeComponent();
            lblUserName.Text = user;
            this.userId = id;
            this.login = login;
        }


        private void GameBoard_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back;
            LoadImageView();
            InitializeBoardGame();
            FirstCheakersConfig();
            gameDataView.Enabled = false;
        }

        private void FirstCheakersConfig()
        {
            cellHeight = gameDataView.Rows[0].Height;
            cellWidth = gameDataView.Columns[0].Width;
            checkerHeight = (int)(cellHeight * 0.7);
            checkerWidth = (int)(cellWidth * 0.7);

            LoadWhiteCheakers(new Point((cellWidth / 2 - checkerWidth / 2) + cellWidth, cellHeight / 2 - checkerHeight / 2));
            LoadBlackCheakers(new Point((cellWidth / 2 - checkerWidth / 2) + cellWidth, cellHeight / 2 - checkerHeight / 2 + (NUMBER_OF_ROWS - 2) * (cellHeight)));

            foreach(CheckerView cv in checkers)
            {
                cv.Parent = gameDataView;
                if(cv.CheckerColor == Color.Black) { cv.MouseClick += checker_MouseClick; }
            }
        }

        private void LoadBlackCheakers(Point point)
        {
            checkers[4] = new CheckerView(5, userId, checkerHeight, checkerWidth, new Coordinate(6, 1), new Coordinate(-1, -1), Color.Black, blackChaker, point);
            data[6, 1].IsFill = true;
            point.X += cellWidth * 2;

            checkers[5] = new CheckerView(6, userId, checkerHeight, checkerWidth, new Coordinate(6, 3), new Coordinate(-1, -1), Color.Black, blackChaker, point);
            data[6, 3].IsFill = true;
           
            point.Y += cellHeight;
            point.X = (int)((cellWidth / 2 - cellWidth / 2) + (cellWidth * 0.15));

             checkers[6] = new CheckerView(7, userId, checkerHeight, checkerWidth, new Coordinate(7, 0), new Coordinate(-1, -1), Color.Black, blackChaker, point);
             data[7, 0].IsFill = true;
             point.X += cellWidth * 2;

             checkers[7] = new CheckerView(8, userId, checkerHeight, checkerWidth, new Coordinate(7, 2), new Coordinate(-1, -1), Color.Black, blackChaker, point);
             data[7, 2].IsFill = true;
        }

        private void LoadWhiteCheakers(Point point)
        {
            checkers[0] = new CheckerView(1, rivalId, checkerHeight, checkerWidth, new Coordinate(0, 1), new Coordinate(-1, -1), Color.White, whiteChecker, point);
            data[0, 1].IsFill = true;
            point.X += cellWidth * 2;

            checkers[1] = new CheckerView(2, rivalId, checkerHeight, checkerWidth, new Coordinate(0, 3), new Coordinate(-1, -1), Color.White, whiteChecker, point);
            data[0, 3].IsFill = true;
            point.X += cellWidth * 2;

            point.Y += cellHeight;
            point.X = (int)((cellWidth / 2 - cellWidth / 2) + (cellWidth * 0.15));

            checkers[2] = new CheckerView(3, rivalId, checkerHeight, checkerWidth, new Coordinate(1, 0), new Coordinate(-1, -1), Color.White, whiteChecker, point);
            data[1, 0].IsFill = true;
            point.X += cellWidth * 2;

            checkers[3] = new CheckerView(4, rivalId, checkerHeight, checkerWidth, new Coordinate(1, 2), new Coordinate(-1, -1), Color.White, whiteChecker, point);
            data[1, 2].IsFill = true;
        }

        private void updateTurnPanel()
        {
            if(turn == userId) { pictureBoxTurn.Image = Util.resizeImage(blackChaker, 100, 100); }
            else { pictureBoxTurn.Image = Util.resizeImage(whiteChecker, 100, 100); }
        }

        private void checker_MouseClick(object sender, MouseEventArgs e)
        {
            
            CheckerView cv = (CheckerView)sender;

            if (lastMoves != null)
            {
                lastMoves = null;
                lastMoves = new PotentialSteps();
            }

            if (data[cv.CoordinatePosition.X, cv.CoordinatePosition.Y].BackColor != Color.White)
            {
                if ((userId == cv.UserID))
                { 
                    if (cv.CheckerColor == Color.Black) { lastMoves.GetPotentialStepBlackCheakers(cv.CoordinatePosition.X, cv.CoordinatePosition.Y); }
                    else { lastMoves.GetPotentialStepWhiteCheakers(cv.CoordinatePosition.X, cv.CoordinatePosition.Y); }
                    if (lastMoves.PotentialMoves != null)
                    {
                        foreach (Coordinate step in lastMoves.PotentialMoves)
                        {
                            if ((step != null) && (step.X >= 0) && (step.Y >= 0) && (step.X <= 7) && (step.Y <= 3))
                            {
                                if ((!data[step.X, step.Y].IsFill) || ((data[step.X, step.Y].IsFill) && ((getCheckerByCoordinate(step.X, step.Y)).CheckerColor != cv.CheckerColor)))
                                {
                                    gameDataView.Rows[step.X].Cells[step.Y].Style.BackColor = Color.Green;
                                }
                            }
                        }
                    }
                    lastMoves.Cheaker = cv;
                }
            }
        }

        private void LoadImageView()
        {
            pnlWhite.BackgroundImage = Util.resizeImage(whiteChecker, 50, 50);
            pnlWhite.BackgroundImageLayout = ImageLayout.Center;
            pnlBlack.BackgroundImage = Util.resizeImage(blackChaker, 50, 50);
            pnlBlack.BackgroundImageLayout = ImageLayout.Center;
            bthPlay.BackgroundImage = Util.resizeImage(playButton, 30, 30);
            bthPlay.BackgroundImageLayout = ImageLayout.Center;
            btnUndo.BackgroundImage = Util.resizeImage(undoButton, 30, 30);
            btnUndo.BackgroundImageLayout = ImageLayout.Center;
            btnPasue.BackgroundImage = Util.resizeImage(pauseButton, 30, 30);
            btnPasue.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxTurn.BackgroundImage = Util.resizeImage(whiteChecker, 90, 90);
            pictureBoxTurn.BackgroundImageLayout = ImageLayout.Center;
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
                    if ((row % 2 == 0) && (col % 2 == 0)) { gameDataView[col, row].Style.BackColor = Color.White; gameDataView[col, row].ToolTipText = "{" + col + " , " + row + "}"; }
                    if ((row % 2 == 0) && (col % 2 == 1)) { gameDataView[col, row].Style.BackColor = Color.Black; gameDataView[col, row].ToolTipText = "{" + col + " , " + row + "}"; }
                    if ((row % 2 == 1) && (col % 2 == 0)) { gameDataView[col, row].Style.BackColor = Color.Black; gameDataView[col, row].ToolTipText = "{" + col + " , " + row + "}"; }
                    if ((row % 2 == 1) && (col % 2 == 1)) { gameDataView[col, row].Style.BackColor = Color.White; gameDataView[col, row].ToolTipText = "{" + col + " , " + row + "}"; }

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
            if ((lastMoves.Cheaker != null) && (userId == lastMoves.Cheaker.UserID) && (lastMoves.IsStepExist(new Coordinate(e.RowIndex, e.ColumnIndex))))
            {
                if (lastMoves.Cheaker.CheckerColor == Color.Black) { makeBlackMove(e.RowIndex, e.ColumnIndex); }
                else { makeWhiteMove(e.RowIndex, e.ColumnIndex); }
                foreach (Coordinate step in lastMoves.PotentialMoves)
                {
                    if (step != null) { gameDataView.Rows[step.X].Cells[step.Y].Style.BackColor = Color.Black; }
                }
            }
            gameDataView.ClearSelection();
        }

        private void makeWhiteMove(int row, int col)
        {
            CheckerView cv = null;
            lastMoves.Cheaker.CoordinateOldPosiotin = lastMoves.Cheaker.CoordinatePosition;
            data[lastMoves.Cheaker.CoordinatePosition.X, lastMoves.Cheaker.CoordinatePosition.Y].IsFill = false;
            int x = lastMoves.Cheaker.Location.X;
            int y = lastMoves.Cheaker.Location.Y;
            if ((data[row, col].IsFill)) { cv = getCheckerByCoordinate(row, col); }
            if ((data[row, col].IsFill) && (cv.CheckerColor != lastMoves.Cheaker.CheckerColor))
            {
                if (lastMoves.Cheaker.CoordinatePosition.Y < col ) { x += cellWidth; }
                else { x -= cellWidth; }
                y += cellHeight * 2;
            }
            else
            {
                if (lastMoves.Cheaker.CoordinatePosition.Y < col) { x += cellWidth; }
                else { x -= cellWidth; }
                y += cellHeight;
            }
            if (row == 7) { lastMoves.Cheaker.Image = (Image)new Bitmap(whiteCheckerKing, checkerWidth, checkerHeight); }
            lastMoves.Cheaker.Location = new Point(x, y);
            lastMoves.Cheaker.CoordinatePosition = new Coordinate(row, col);
            data[row, col].IsFill = true;
            if(cv != null)
            {
                cv.InGame = false;
                cv.Dispose();
                lblBlackScore.Text = (Int32.Parse(lblBlackScore.Text) + 1).ToString();
            }
            newGame.GameMoves.Add(new Move(newGame.GameId, rivalId, lastMoves.Cheaker.ID, DateTime.Now, lastMoves.Cheaker.CoordinateOldPosiotin, lastMoves.Cheaker.CoordinatePosition));
        }

        private void makeBlackMove(int row, int col)
        {
            CheckerView cv = null;
            lastMoves.Cheaker.CoordinateOldPosiotin = lastMoves.Cheaker.CoordinatePosition;
            data[lastMoves.Cheaker.CoordinatePosition.X, lastMoves.Cheaker.CoordinatePosition.Y].IsFill = false;
            int x = lastMoves.Cheaker.Location.X;
            int y = lastMoves.Cheaker.Location.Y;
            if ((data[row, col].IsFill)) { cv = getCheckerByCoordinate(row, col); }
            if ((data[row, col].IsFill) && (cv.CheckerColor != lastMoves.Cheaker.CheckerColor))
            {
                //Add check if can jump 2 cubes 
                row -= 2;
                col += 2;

                if (lastMoves.Cheaker.CoordinatePosition.Y < col) { x += cellWidth; }
                else { x -= cellWidth; }
                y -= cellHeight * 2;

            } else
            {
                if (lastMoves.Cheaker.CoordinatePosition.Y < col) { x += cellWidth; }
                else { x -= cellWidth; }
                y -= cellHeight ;

                lastMoves.Cheaker.CoordinatePosition = new Coordinate(row, col);
                data[row, col].IsFill = true;
            }
            if (row == 0) { lastMoves.Cheaker.Image = (Image)new Bitmap(blackChakerKing, checkerWidth, checkerHeight); }
            lastMoves.Cheaker.Location = new Point(x, y);
            lastMoves.Cheaker.Parent = gameDataView;
            if(cv != null)
            {
                cv.InGame = false;
                cv.Dispose();
                lblWhiteScore.Text = (Int32.Parse(lblWhiteScore.Text) + 1).ToString();
            }
            newGame.GameMoves.Add(new Move(newGame.GameId, userId, lastMoves.Cheaker.ID, DateTime.Now, lastMoves.Cheaker.CoordinateOldPosiotin, lastMoves.Cheaker.CoordinatePosition));
        }

        private CheckerView getCheckerByCoordinate(int row, int col)
        {
            Coordinate coordinateToCheck = new Coordinate(row, col);
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
            newGame = new Game(server.getGameId(), DateTime.Now, userId, rivalId);
            turn = userId;
            //call back with service
            gameDataView.Enabled = true;
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            newGame = new Game(server.getGameId(), DateTime.Now, userId, 0);
            //call back with service with rival id which is 0  -> saved to game aginst computer
            gameDataView.Enabled = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            gameDataView.Enabled = false;
            History historyWin = new History(userId, lblUserName.Text);
            historyWin.StartPosition = FormStartPosition.CenterParent;
            historyWin.Show();
          //  List<Move> historyMoves = historyWin.ShowDialog();

            /*Check if returned list of moves
            if yes - check if in middle of game
                        if yes - ask for stop the game */
        }

        private void btnPasue_Click(object sender, EventArgs e)
        {
            gameDataView.Enabled = false;
            Pause pasueWin = new Pause();
            pasueWin.StartPosition = FormStartPosition.CenterParent;
            pasueWin.Show();
            gameDataView.Enabled = true;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(newGame.GameMoves.Count == 0) { MessageBox.Show("Cannot preform Undo step"); }
            else
            {
                Move lastMove = newGame.GameMoves.Last();
                CheckerView cv = getCheckerByID(lastMove.CheckerID);
                if (!(cv.CoordinateOldPosiotin.Equals(new Coordinate(-1, -1))))
                {
                    int x = cv.Location.X;
                    int y = cv.Location.Y;
                    if (cv.CheckerColor == Color.Black)
                    {
                        if (cv.CoordinatePosition.Y < cv.CoordinateOldPosiotin.Y) { x += cellWidth; }
                        else { x -= cellWidth; }
                        y += cellHeight;
                    }
                    cv.Location = new Point(x, y);
                    gameDataView.Rows[cv.CoordinatePosition.X].Cells[cv.CoordinatePosition.Y].Selected = false;
                    data[cv.CoordinatePosition.X, cv.CoordinatePosition.Y].IsFill = false;
                    data[cv.CoordinateOldPosiotin.X, cv.CoordinateOldPosiotin.Y].IsFill = true;
                    cv.CoordinatePosition = cv.CoordinateOldPosiotin;
                    cv.CoordinateOldPosiotin = new Coordinate(-1, -1);
                    cv.Parent = gameDataView;
                    newGame.GameMoves.Remove(lastMove);

                }
            }
        }

        private void bthPlay_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isGameOver)
            {
                InitializeBoardGame();
                FirstCheakersConfig();
                gameDataView.Enabled = false;
            }
            else
            {
                const string message =
                         "Are you sure that you would like to start new game?";
                const string caption = "New Game";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    InitNewGame();
                    InitializeBoardGame();
                    FirstCheakersConfig();
                    gameDataView.Enabled = false;

                }
            }
        }

        private void InitNewGame()
        {
            foreach (CheckerView cv in checkers) { cv.Dispose(); }
            data = new DataCellInfo[NUMBER_OF_ROWS, NUMBER_OF_COLS];
            gameDataView.ClearSelection();
        }

        private void GameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.login.Dispose();
        }
    }
}
