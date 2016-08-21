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
            //We are black and now is our turn
            if (GameBoard.ActivePlayer.Id == GameBoard.ActiveGame.Player2.Id) { GameBoard.updateTurnPanel(true); }
            //We are black and now is our turn
            else { GameBoard.updateTurnPanel(false); }
        }

        public void PlayerTurnCallback(Move lastMove)
        {
            if (lastMove == null)
            { return; }

            if (lastMove.From.X != -1) // Not the initial move
            {
                GameBoard.updateMoves(lastMove);
                //We are black and now is our turn
                if (lastMove.PlayerId == GameBoard.ActiveGame.Player2.Id) { GameBoard.updateTurnPanel(true); }
                //We are black and now is our turn
                else { GameBoard.updateTurnPanel(false); }
            }
            GameBoard.GridViewEnableFlag(true);
        }

        public void StartGameCallback(Game game, Status status)
        {
            if (GameBoard.ActiveGame != null && GameBoard.ActiveGame.Id == game.Id) { return; } // make sure we are not starting same game twice
            if (Status.GAME_STARTED == status)
            {
                GameBoard.ActiveGame = game;
                GameBoard.InitNewGame();
                GameBoard.FirstCheakersConfig();
                GameBoard.updateRivalPlayerName();

                //First moves black
                GameBoard.updateTurnPanel(true);

            }
            else
            {
                MessageBox.Show(status.ToString(), status.ToString());
            }
        }

        public void GameEnd(Game game, Move lastRivalMove, Status status)
        {
            if (Status.GAME_WIN == status) { new WinnerWin(GameBoard).Show(); }
            else { new LoserWin(GameBoard).Show(); }
        }
    }
}
