using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TossClass
{
    class Pet
    {
        string _name, _weight;

        public Pet()
        {
            _name = "";
            _weight = "";
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public string fullCharacteristics
        {
            get
            {
                return "Its name is " + _name + " and its weight is " + _weight;
            }
        }

    }
}
