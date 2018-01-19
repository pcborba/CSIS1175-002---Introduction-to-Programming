using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS3pauloborbaT_v0_1
{    
    class Rental
    {
        private string _bikeT, _access, _insur, _bikeDesc, _accessDesc, _insurDesc;
        private double _hrs, _amt;

        public Rental (string bikeT, string access, string insur, double hours)
        {
            _bikeT = bikeT;
            _access = access;
            _insur = insur;
            _hrs = hours;
        }

        public string BikeType
        {
            get
            {
                if (_bikeT == "1")
                {
                    _bikeDesc = "Single-speed";
                }
                if (_bikeT == "2")
                {
                    _bikeDesc = "Seven-speed";
                }
                if (_bikeT == "3")
                {
                    _bikeDesc = "Tandem";
                }
                if (_bikeT == "4")
                {
                    _bikeDesc = "Moutain";
                }
                return _bikeDesc;
            }
        }

        public string Accessories
        {
            get
            {
                if (_access.Contains("N"))
                {
                    _accessDesc = " Not required accessories  ";
                }
                else
                {
                    if(_access.Contains("C"))
                    {
                        _accessDesc = _accessDesc + " Child seat &";
                    }
                    if (_access.Contains("R"))
                    {
                        _accessDesc = _accessDesc + " Rack &";
                    }
                    if (_access.Contains("L"))
                    {
                        _accessDesc = _accessDesc + " Lock &";
                    }
                }
                return _accessDesc.Substring(0, _accessDesc.Length -2);
            }
        }

        public string Insurance
        {
            get
            {
                if (_insur == "Y")
                {
                    _insurDesc = "Yes";
                }
                if (_insur == "N")
                {
                    _insurDesc = "No";
                }
                return _insurDesc;
            }
        }

        public double Charge
        {
            get
            {
                if (_hrs <= 5)
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
