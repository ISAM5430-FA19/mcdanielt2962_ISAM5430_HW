using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.B
{
    class Account
    {
        public string Name { get; set; }
        private decimal balance;
        public Account(string acctName, decimal initialBalance)
        {
            Name = acctName;
            balance = initialBalance;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if(value>0.0m)
                {
                    balance = value;
                }
            }
        }
        public void Deposit (decimal depositAmount)
        {
            if(depositAmount>0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }
        public void Withdrawl(decimal withdrawlAmount)
        {
            if(withdrawlAmount>balance)
            {
                Console.WriteLine("The amount is greater than the balance.");
            }
            else
            {
                Balance = Balance - withdrawlAmount;
            }
        }
    }
}
