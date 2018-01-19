using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        int _year;
        string _make;
        int _speed;
        string _warning;
        public Car(int year, string make)
        {
            _year = year;
            _make = make;
            _speed = 0;
        }

        public int year()
        {
            return _year;
        }

        public string make()
        {
            return _make;
        }

        public int speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public void accelerate(int acel)
        {
            _speed += acel;
        }

        public void breaking(int brk)
        {
            _speed -= brk;
        }

        public void warning()
        {
            _warning = "";
            if (_speed < 30)
            {
                _warning = "Too slow";
            }

            if (_speed > 90)
            {
                _warning = "Your " + _make + " is to fast!!";
            }
        }

        public string warningalert
        {
            get
            {
                warning();
                return _warning;
            }
        }


    }
}
