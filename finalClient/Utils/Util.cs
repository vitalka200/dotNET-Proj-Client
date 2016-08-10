using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalClient
{
    class Util
    {
        internal static Bitmap resizeImage(Image image, int width, int hegith)
        {
            return new Bitmap(image, width, hegith);
        }
    }
}
