using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3solution
{
    class Rental
    {
        private string _bikeType, _accType, _insType;
        private decimal _hrs;

        public Rental(string bikeType, string accType, 
            string insType, decimal hrs)
        {
            _bikeType = bikeType;
            _accType = accType;
            _insType = insType;
            _hrs = hrs;
        }

        public string bType
        {
            get
            {
                string Type = "";
                if(_bikeType == "1")
                {
                    Type = "Single-speed";
                }
                if (_bikeType == "2")
                {
                    Type = "Seven-speed";
                }
                if (_bikeType == "3")
                {
                    Type = "Tandem";
                }
                if (_bikeType == "4")
                {
                    Type = "Mountain";
                }
                return Type;
            }
        }

        public string aType
        {
            get
            {
                string Type = "";
                int len = 0;
                if(_accType.Contains('C'))
                { Type = "Child seat & "; }
                if (_accType.Contains('L'))
                { Type = Type + "Lock & "; }
                if (_accType.Contains('R'))
                { Type = Type + "Rack & "; }
                if (_accType.Contains('N'))
                { Type = "Non requested & "; }
                len = Type.Length;
                Type = Type.Substring(0, len - 2);
                return Type;
            }
        }

        public string iType
        {
            get
            {
                string Type = "";
                if(_insType=="Y")
                { Type = "Yes"; }
                else
                { Type = "No"; }
                return Type;
            }
        }

        public decimal Amt
        {
            get
            {
                decimal Amount = 0;
                if (_hrs>5)
                {
                    Amount = 60 + (_hrs - 5) * 10;
                }
                else
                {
                    Amount = _hrs * 12;
                }
                return Amount;
            }
        }
    }
}
