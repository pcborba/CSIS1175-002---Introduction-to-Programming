using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePlan
{
    class Plan
    {
        decimal _planMinAmtCost, _planDataAmtCost, _minACost, _minBCost, _data1Cost, _data2Cost, _data4Cost, _dataNoCost;

        public Plan ()
        {
            _minACost = 0.1m;
            _minBCost = 0.05m;
            _data1Cost = 10m;
            _data2Cost = 15m;
            _data4Cost = 20m;
        }

        public void PlanOption(int min, string dataplan)
        {
            _planMinAmtCost = 0;
            _planDataAmtCost = 0;

            if (min <= 1000)
            {
                _planMinAmtCost = min * _minACost;
            }
            else
            {
                _planMinAmtCost = min * _minBCost;
            }

            if (dataplan == "1")
            {
                _planDataAmtCost = int.Parse(dataplan) * _data1Cost;
            }
            if (dataplan == "2")
            {
                _planDataAmtCost = int.Parse(dataplan) * _data2Cost;
            }
            if (dataplan == "4")
            {
                _planDataAmtCost = int.Parse(dataplan) * _data4Cost;
            }
            if (dataplan == "n")
            {
            }
        }

        public decimal PlanMinCost
        {
            get
            {
                return _planMinAmtCost;
            }
        }

        public decimal PlanDataCost
        {
            get
            {
                return _planDataAmtCost;
            }
        }

    }
}
