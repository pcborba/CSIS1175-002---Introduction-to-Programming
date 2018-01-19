using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Week11
{
    class Customer
    {
        private string _firstName, _lastName, _id;

        public Customer(string info)
        {
            string[] selectedCustomer = info.Split(' ');
            _firstName = selectedCustomer[0];
            _lastName = selectedCustomer[1];
            _id = selectedCustomer[2];
        }

        public string getID
        {
            get { return _id; }
        }

        public string getFullName
        {
            get { return _lastName+", "+_firstName; }
        }
    }
}
