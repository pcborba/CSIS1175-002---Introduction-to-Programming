using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Registration
{
    class Fee
    {

        double _credLDcost, _credUDcost, _credIcost, _regAmtcost;
        bool _studentDomestic;

        public Fee()
        {
            _credLDcost = 99.65;
            _credUDcost = 119.45;
            _credIcost = 530;
        }

        public void regCost(bool domestic, int lQty, int uQty)
        {
            if (domestic == true)
            {
                _regAmtcost = _credLDcost * lQty;
                _regAmtcost += _credUDcost * uQty;
            }
            else
            {
                _regAmtcost = _credIcost * (lQty + uQty);
            }
        }

        public double regAmtcost
            {
            get
            {
                return _regAmtcost;
            }
            }

    }
}
