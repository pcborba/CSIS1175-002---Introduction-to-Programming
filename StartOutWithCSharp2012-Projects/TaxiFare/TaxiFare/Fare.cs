using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiFare
{
    class Fare
    {
        decimal _bFare, _discFare, _sFare, _subFare, _tipAmt, _totAmt;
        public Fare(double dist, int suit, bool disc, int tip)
        {
            if (dist <= 2)
            {
                _bFare = 10m;
            }
            else
            {
                _bFare = (decimal)dist * 4m ;
            }

            if (disc == true)
            {
                _discFare = _bFare * -0.1m;
            }

            _sFare = suit * 4.5m;
            _subFare = _bFare + _sFare + _discFare;
            _tipAmt = _subFare * ((decimal)tip / 100);
            _totAmt = _subFare + _tipAmt;
        }
        public decimal BaseFare
        {
            get
            {
                return _bFare;
            }                            
        }
        public decimal DiscFare
        {
            get
            {
                return _discFare;
            }
        }
        public decimal LugageFare
        {
            get
            {
                return _sFare;
            }
        }
        public decimal SubTotalFare
        {
            get
            {
                return _subFare;
            }
        }
        public decimal TipFare
        {
            get
            {
                return _tipAmt;
            }
        }
        public decimal TotalFare
        {
            get
            {
                return _totAmt;
            }
        }
    }
}
