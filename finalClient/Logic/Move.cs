using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalClient.Logic
{
    class Move
    {
        static int id = 0;

        public Move(int gameID, int playerID, int checkerId, DateTime date, Coordinate from, Coordinate to)
        {
            ID = id;
            GameID = gameID;
            PlayerID = playerID;
            CheckerID = checkerId;
            Date = date;
            From = from;
            To = to; 
        }

        public int ID { get; set; }
        public int GameID { get; set; }
        public int PlayerID { get; set; }
        public int CheckerID { get; set; }
        public DateTime Date { get; set; }
        public Coordinate From { get; set; }
        public Coordinate To { get; set; }  
    }

}
