using finalClient.HelperUtil;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalClient
{
    class DataCellInfo
    {
          //  private Coordinate coordinate;
          //  private Color backColor;
           // private bool isFill;
           // private Image cheaker;

            public DataCellInfo(int row, int col, Color backColor)
            {
                CoordinateCell = new Coordinate { X = row, Y = col };
                BackColor = backColor;
                IsFill = false;
            }

            public Coordinate CoordinateCell { get; set; }
            public Color BackColor { get; set; }
            public bool IsFill { get; set; }
        }
}
