using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS3pauloborba_v0_2_2
{
    class Rental
    {
        private string _bikeT, _access, _insur, _bikeDesc, _accessDesc, _insurDesc;
        private double _amt, _hours;

        public Rental(string bikeT, string access, string insur, double hours)
        {
            _bikeT = bikeT;
            _access = access;
            _insur = insur;
            _hours = hours;
        }
        public string BikeType
        {
            get
            {
                if(_bikeT == "1")
                {
                    _bikeDesc = "Single - speed";
                }
                if (_bikeT == "2")
                {
                    _bikeDesc = "Seven - speed";
                }
                if (_bikeT == "3")
                {
                    _bikeDesc = "Tandem";
                }
                if (_bikeT == "4")
                {
                    _bikeDesc = "Mountain";
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
                    _accessDesc = " not accessory requested  ";
                }
                else
                {
                    if(_access.Contains("C"))
                    {
                        _accessDesc = _accessDesc +" Child seat &";
                    }
                    if (_access.Contains("L"))
                    {
                        _accessDesc = _accessDesc + " Lock &";
                    }
                    if (_access.Contains("R"))
                    {
                        _accessDesc = _accessDesc + " Rack &";
                    }
                }
                return _accessDesc.Substring(0, _accessDesc.Length-2);
            }
        }
        public string Insurance
        {
            get
            {
                if(_insur=="Y")
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
                if (_hours <=5 )
                {
                    _amt = _hours * 12;
                }
                else
                {
                    _amt = (5*12) +((_hours-5) * 10);
                }
                return _amt;
            }
        }
    }
}
