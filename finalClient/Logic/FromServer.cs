using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalClient.Logic
{
    class FromServer
    {
        static int gameID = 0;

        public FromServer() { }

        public int getGameId()
        {
            return ++gameID;
        }
    }
}
