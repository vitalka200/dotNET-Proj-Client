using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalClient
{
    class RowView
    {
        public Image Cell1 { get; set; }
        public Image Cell2 { get; set; } 
        public Image Cell3 { get; set; }
        public Image Cell4 { get; set; }

        private Image blackSquare = Properties.Resources.black_square;
        private Image whiteSquare = Properties.Resources.white_square;
        
        public RowView(int line)
        {
            if(line == 0)
            {
                Cell1 = blackSquare;
                Cell2 = whiteSquare;
                Cell3 = blackSquare;
                Cell4 = whiteSquare;
            }
            else
            {
                Cell1 = whiteSquare;
                Cell2 = blackSquare;
                Cell3 = whiteSquare;
                Cell4 = blackSquare;
            }
        } 

    }
}
