using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;
        public string User { get; set; }
        public void Deposit(double increaseFunds)
        {
            _balance += increaseFunds;
        }

        public double GetBalance()
        {
            return _balance;
        }


    
       
    }
}

