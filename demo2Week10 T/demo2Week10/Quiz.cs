using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2Week10
{
    class Quiz
    {
        private int _q1, _q2, _q3, _q4;

        public Quiz(int q1, int q2, int q3, int q4)
        {
            _q1 = q1;
            _q2 = q2;
            _q3 = q3;
            _q4 = q4;
        }

        public double Avg()
        {

            
            int smaller = 0;
            if (_q1 < _q2)
            { smaller = _q1; }
            else
            { smaller = _q2; }

            if (_q3 < smaller)
            { smaller = _q3; }

            if (_q4 < smaller)
            { smaller = _q4; }

            return ((_q1 + _q2 + _q3 + _q4 - smaller) / 3);
            
        }
    }
}
