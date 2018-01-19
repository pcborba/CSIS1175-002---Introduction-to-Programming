using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSimul
{
    class BankAccount
    {
        private decimal _balance;
        
        public BankAccount (decimal startBalance)
        {
            _balance = startBalance;
        }

        public decimal balance
        {
            get
            {
                return _balance;
            }
        }

        public void deposit(decimal dep)
        {
            _balance += dep;
        }

        public void withdrawal(decimal with)
        {
            _balance -= with;
        }
    }
}
