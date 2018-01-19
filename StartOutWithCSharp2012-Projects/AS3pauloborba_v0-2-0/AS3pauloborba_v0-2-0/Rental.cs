using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS3pauloborba_v0_2_0
{
    class Rental
    {
        private string _access, _bike, _insur, _accessDesc, _bikeDesc, _insurDesc;
        private double _hourRent, _charge;
        int _accessL;

        public Rental (string access, string bike, string insur, double hour)
        {
            _access = access;
            _bike = bike;
            _insur = insur;
            _hourRent = hour;
        }
        public string Accessory
        {
            get
            {
                if (_access.Contains("N"))
                {
                    _accessDesc = " not accessory requested";
                }
                if (_access.Contains("C"))
                {
                    _accessDesc = _accessDesc + " Child seat &";
                }
                if (_access.Contains("L"))
                {
                    _accessDesc = _accessDesc + " Lock &";
                }
                if (_access.Contains("R"))
                {
                    _accessDesc = _accessDesc + " Rack &";
                }
                _accessL = _accessDesc.Length-2;
                return _accessDesc.Substring(0, _accessL);
            }
        }
        public string Bike
        {
            get
            {
                if (_bike == "1")
                {
                    _bikeDesc = "Single-speed";
                }
                if (_bike == "2")
                {
                    _bikeDesc = "Seven-speed";
                }
                if (_bike == "3")
                {
                    _bikeDesc = "Tandem";
                }
                if (_bike == "4")
                {
                    _bikeDesc = "Mountain";
                }
                return _bikeDesc;
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
                if (_hourRent <= 5)
                {
                    _charge = _hourRent * 12;
                }
                else
                {
                    _charge = (5 * 12)+((_hourRent-5)*10);
                }
                return _charge;
            }
        }
    }
}
