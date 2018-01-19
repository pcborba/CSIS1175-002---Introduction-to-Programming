using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TossClass
{
    class Coin
    {

        private string sideUp;
        public Coin()
        {
            sideUp = "";
        }

        public void Toss()
        {
            Random rand = new Random();

            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }


        public string getSideUp()
        {
            return sideUp;
        }

    }
}
