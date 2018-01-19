using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhone
{
    class CellPhone
    {
        string _brand, _model;
        decimal _price;

        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0;
        }


        public string brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }

        public string model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public decimal price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

    }
}
