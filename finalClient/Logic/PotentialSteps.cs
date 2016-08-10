using finalClient.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalClient.Logic
{
    class PotentialSteps
    {
        public CheckerView Cheaker;
        public List<Coordinate> PotentialMoves { get; set; }

        public PotentialSteps()
        {
            Cheaker = null;
            PotentialMoves = new List<Coordinate>();
        }

        public void GetPotentialStepBlackCheakers(int currentX, int currentY)
        { 
            if (currentX == 0)
            {
                PotentialMoves.Add(null);
            }
            else
            {
                int nextX = currentX - 1;
                if (currentY == 3) { PotentialMoves.Add(new Coordinate(nextX, currentY - 1)); }
                else if (currentY == 0) { PotentialMoves.Add(new Coordinate(nextX, currentY + 1)); }
                else
                {
                    PotentialMoves.Add(new Coordinate(nextX, currentY - 1));
                    PotentialMoves.Add(new Coordinate(nextX, currentY + 1));
                }
            }
        }

        public void GetPotentialStepWhiteCheakers(int currentX, int currentY)
        {
            if (currentX == 7)
            {
                PotentialMoves.Add(null);
            }
            else
            {
                int nextX = currentX + 1;
                if (currentY == 3) { PotentialMoves.Add(new Coordinate(nextX, currentY - 1)); }
                else if (currentY == 0) { PotentialMoves.Add(new Coordinate(nextX, currentY + 1)); }
                else
                {
                    PotentialMoves.Add(new Coordinate(nextX, currentY - 1));
                    PotentialMoves.Add(new Coordinate(nextX, currentY + 1));
                }
            }
        }


        internal bool IsStepExist(Coordinate coordinate)
        {
            foreach(Coordinate step in PotentialMoves)
            {
                if ((step != null) && (step.X == coordinate.X) && (step.Y == coordinate.Y)) { return true; } 
            }
            return false;
        }
    }
}
