using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Week10
{
    class Pet
    {
        private string _name;

        public Pet()
        {
            _name = "Douglas";
        }

        public string PetName
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
    }
}
