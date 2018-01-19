using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Week10
{
    class Coin
    {
        private string sideUp;

        Random ran = new Random();


        public Coin()
        {
            sideUp = "";
        }

        public void Toss()
        {
            if (ran.Next(2)==0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }
        public string getSide()
        {
            return sideUp;
        }
    }
}
