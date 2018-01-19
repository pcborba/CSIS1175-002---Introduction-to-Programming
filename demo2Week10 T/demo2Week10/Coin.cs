using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2Week10
{
    class Coin
    {
        private string sideUp;
        Random rand = new Random();
        public Coin()
        {
            sideUp = "";
        }

        public void flip()
        {
            if (rand.Next(2)==0)
            { sideUp = "heads";}
            else
            { sideUp = "tails"; }
        }

        public string getSide()
        {
            return sideUp;
        }
    }
}
