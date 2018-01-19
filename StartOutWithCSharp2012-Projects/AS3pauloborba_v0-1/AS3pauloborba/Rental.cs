using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS3pauloborba
{
    class Rental
    {
        private DateTime _date;
        private string _type, _insur, _access, _typeDesc, _accessDesc, _insurDesc;
        private double _hour, _amt;
        
        public Rental (DateTime date, string type, string access, string insur, double hour)
        {
            _date = date;
            _hour = hour;
            _type = type;
            _access = access;
            _insur = insur;
        }

        public string Access
        {
            get
            {
                if (_access.Contains("N"))
                {
                    _accessDesc = _accessDesc+" not accessory requested &";
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
                    _accessDesc = _accessDesc + "Rack &";
                }
                _access = _accessDesc.Length.ToString();
                _accessDesc = _accessDesc.Substring(0, int.Parse(_access) - 2);
                string accessDesc = _accessDesc;
                return accessDesc;
            }
        }

        public string Insur
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
                string insurDesc=_insurDesc;
                return insurDesc;
            }
        }

        public string Amount
        {
            get
            {
                if (_hour <= 5)
                {
                    _amt = _hour * 12;
                }
                else
                {
                    _amt = 5 * 12;
                    _amt = _amt + ((_hour - 5) * 10);
                }
                string amt = _amt.ToString();
                return amt;
            }
        }

        public string Biket
        {
            get
            {
                if (_type == "1")
                {
                    _typeDesc = "Single - speed";
                }
                if (_type == "2")
                {
                    _typeDesc = "Seven - speed";
                }
                if (_type == "3")
                {
                    _typeDesc = "Tandem";
                }
                if (_type == "4")
                {
                    _typeDesc = "Mountain";
                }
                string typeDesc = _typeDesc;
                return typeDesc;
            }
        }

    }
}
