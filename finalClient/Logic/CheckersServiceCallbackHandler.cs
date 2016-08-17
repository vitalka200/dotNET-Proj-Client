using finalClient.CheckersService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalClient.Logic
{

    public class CheckersServiceCallbackHandler : IDuplexCheckersServiceCallback
    {
        public GameBoard GameBoard;
        public Login Login;
        public History History;

        public void LoginCallback(Player player, Game[] playerGames, Status status)
        {
            if (Status.LOGIN_SUCCEDED == status)
            {
                GameBoard.SetPlayer(player);
                if (playerGames != null && playerGames.Length > 0)
                {
                    GameBoard.AllowSecondPlayerGame();
                }
                else
                {
                    MessageBox.Show("No games against other player, you may only play against computer", "Warning");
                }
                Login.Hide();
                GameBoard.Show();
            }
            else
            {
                // user not correct
                MessageBox.Show("Incorrect user or password", "Error");
            }
        }

        public void MakeMoveCallback(Status status)
        {
            //throw new NotImplementedException();
        }

        public void PlayerTurnCallback(Move lastMove)
        {
            if (lastMove == null)
            { return; }

            if (lastMove.From.X != -1) // Not the initial move
            {
                GameBoard.updateMoves(lastMove);
            }
            GameBoard.GridViewEnableFlag(true);
        }

        public void StartGameCallback(Game game, Status status)
        {
            if (Status.GAME_STARTED == status)
            {
                GameBoard.ActiveGame = game;
                GameBoard.FirstCheakersConfig();
                if (GameBoard.ActivePlayer.Id == game.Player1.Id) // we black
                {
                    GameBoard.updateTurnPanel(true);
                }
                else // we white
                {
                    GameBoard.updateTurnPanel(false);
                }
            }
            else
            {
                MessageBox.Show(status.ToString(), status.ToString());
            }
        }

        public void GameEnd(Move lastRivalMove, Status status)
        {
            if (Status.GAME_WIN == status) { new WinnerWin(lastRivalMove.PlayerId.ToString()).Show(); }
            else { new LoserWin(lastRivalMove.PlayerId.ToString()).Show(); }
            GameBoard.InitNewGame();
        }
    }
}
