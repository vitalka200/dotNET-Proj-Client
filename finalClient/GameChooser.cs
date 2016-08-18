using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finalClient.CheckersService;

namespace finalClient
{
    public partial class GameChooser : Form
    {
        private GameBoard GameBoard;
        public Game[] PlayerGames { get; set; }
        private int RadioID = -1;

        public GameChooser()
        {
            InitializeComponent();
        }

        public GameChooser(GameBoard gameBoard): this()
        {
            this.GameBoard = gameBoard;
        }

        private void GameChooser_Load(object sender, EventArgs e)
        {
            PlayerGames = GameBoard.SoapService.GetGamesByPlayer(GameBoard.ActivePlayer);

            if (PlayerGames != null)
            {
                PlayerGames =
                    (from g in PlayerGames
                     where Status.GAME_COMPLETED != g.GameStatus
                     select g).ToArray();
            }

            if (PlayerGames != null && PlayerGames.Length > 0)
            {
                int locationForWaiting = 1;
                int locationForReady = 1;


                for (int i = 0; i < PlayerGames.Count(); i++)
                {
                    RadioButton radio = new RadioButton();
                    radio.Name = i.ToString();
                    if (PlayerGames[i].Player2 == null || PlayerGames[i].Player1 == null)
                    {
                        radio.Text = "Game number " + PlayerGames[i].Id;
                        radio.Location = new Point(5, 30 * locationForWaiting);
                        grpWait.Controls.Add(radio);
                        locationForWaiting += 1;
                        radio.Enabled = false;
                    }
                    else
                    {
                        radio.Text = PlayerGames[i].Player1.Name + " vs. " + PlayerGames[i].Player2.Name;
                        radio.Location = new Point(5, 30 * locationForReady);
                        radio.Enabled = true;
                        radio.Click += new EventHandler(radio_Click);
                        radio.AutoSize = true;
                        grpPlay.Controls.Add(radio);
                        locationForReady += 1;
                    }
                }
            }
        }

        private void radio_Click(object sender, EventArgs e)
        {
            RadioID = Int32.Parse(((RadioButton)sender).Name);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (RadioID >= 0)
            {
                this.Dispose();
                GameBoard.DuplexService.StartGameAsync(PlayerGames[RadioID], false);
            }
            else
            {
                MessageBox.Show("Please select game");
            }
        }
    }
}
