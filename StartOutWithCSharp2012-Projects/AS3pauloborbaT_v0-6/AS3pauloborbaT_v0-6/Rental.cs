using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS3pauloborbaT_v0_6
{
    class Rental
    {
        private string _bikeT, _access, _insur, _bikeD, _accessD, _insurD;
        private double _hrs, _amt;

        public Rental(string bikeT, string access, string insur, double hrs)
        {
            _bikeT = bikeT;
            _access = access;
            _insur = insur;
            _hrs = hrs;
            _amt = 0;
        }

        public string BikeType
        {
            get
            {
                if(_bikeT=="1")
                {
                    _bikeD = "Single-speed";
                }
                if (_bikeT == "2")
                {
                    _bikeD = "Seven-speed";
                }
                if (_bikeT == "3")
                {
                    _bikeD = "Tandem";
                }
                if (_bikeT == "4")
                {
                    _bikeD = "Mountain";
                }
                return _bikeD;
            }
        }

        public string Accessories
        {
            get
            {
                if (_access.Contains("N"))
                {
                    _accessD = " Not required accessories  ";
                }
                else
                {
                    if (_access.Contains("C"))
                    {
                        _accessD = _accessD+" Child seat &";
                    }
                    if (_access.Contains("R"))
                    {
                        _accessD = _accessD + " Rack &";
                    }
                    if (_access.Contains("L"))
                    {
                        _accessD = _accessD + " Lock &";
                    }
                }
                return _accessD.Substring(0, _accessD.Length - 2);
            }
        }

        public string Insurance
        {
            get
            {
                if(_insur=="Y")
                {
                    _insurD = "Yes";
                }
                if (_insur == "N")
                {
                    _insurD = "No";
                }
                return _insurD;
            }
        }

        public double Charge
        {
            get
            {
                if (_hrs <=5)
                {
                    _amt = _hrs * 12;
                }
                if (_hrs > 5)
                {
                    _amt = 60 + ((_hrs-5) * 10);
                }
                return _amt;
            }
        }
    }
}
