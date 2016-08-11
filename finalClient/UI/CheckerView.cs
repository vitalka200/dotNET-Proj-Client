using finalClient.CheckersService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalClient.UI
{
    class CheckerView : PictureBox
    {
        public CheckerView(int id, int userId, int checkerHeight, int checkerWidth, Coordinate coordinatePosiotin, Coordinate coordinateOldPosiotin, Color checkerColor, Image image, Point location)
        {
            this.ID = id;
            this.UserID = userId;
            this.InGame = true;
            this.CheckerHeight = checkerHeight;
            this.CheckerWidth = checkerWidth;
            this.CoordinatePosition = coordinatePosiotin;
            this.Location = location;
            this.CoordinateOldPosiotin = coordinateOldPosiotin;
            this.CheckerColor = checkerColor;
            this.Image = (Image)(new Bitmap(image, checkerWidth, checkerHeight));
            this.BackColor = Color.Transparent;

        }
        
        public int ID { get; set; }
        public int UserID { get; set; }
        public Boolean InGame { get; set; }
        public int CheckerHeight { get; set; }
        public int CheckerWidth { get; set; }
        public Coordinate CoordinatePosition { get; set; }
        public Coordinate CoordinateOldPosiotin { get; set; }
        public Color CheckerColor { get; set; }
    }
}
