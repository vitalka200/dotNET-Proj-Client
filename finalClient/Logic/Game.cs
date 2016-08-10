using finalClient.Logic;
using System;
using System.Collections.Generic;

namespace finalClient
{
    internal class Game
    {

        public Game(int getGameId, DateTime dateTime, int userId, int rivalId)
        {
            this.GameId = getGameId;
            this.Date = dateTime;
            this.UserId = userId;
            this.RivalId = rivalId;
            this.GameMoves = new List<Move>();
        }

        public int GameId { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int RivalId { get; set; }
        public List<Move> GameMoves { get; set; }
    }
}