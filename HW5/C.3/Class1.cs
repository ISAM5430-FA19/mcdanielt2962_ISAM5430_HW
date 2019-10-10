using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._3
{
    class Money
    {
        private decimal _amount;
        private int _dollars;
        private int _cents;
        public void SetAmount(decimal amountAmount)
        {
            _amount = amountAmount;
        }
        public decimal GetAmount()
        {
            return _amount;
        }
        public void SetDollars(int dollarAmount)
        {
            _dollars=dollarAmount;
        }
        public void SetCents(int centsAmount)
        {
            _cents = centsAmount;
        }
        public int GetDollars()
        {
            return _dollars;
        }
        public int GetCents()
        {
            return _cents;
        }
        public string GetCurrency()
        {
            int centCurrency = _cents;
            int quarterCount = 0;
            int dimeCount = 0;
            int nickleCount = 0;
            int pennyCount = 0;
            while (centCurrency>=25)
            {
                quarterCount += 1;
                centCurrency -= 25;
            }
            while (centCurrency>=10 && centCurrency<25)
            {
                dimeCount += 1;
                centCurrency -= 10;
            }
            while (centCurrency>=5 && centCurrency<10)
            {
                nickleCount += 1;
                centCurrency -= 5;
            }
            while (centCurrency>=1 && centCurrency<5)
            {
                pennyCount += 1;
                centCurrency -= 1;
            }
            return ($"Dollars = {_dollars}. Quarters = {quarterCount}. Dimes = {dimeCount}. Nickles = {nickleCount}. Pennys = {pennyCount}.");
        }
        string addApprove = "Yes";
        string subApprove = "Yes";
        public void AddAmount (decimal addAmount)
        {
            if(addAmount>0.00m)
            {
                _amount = _amount + addAmount;
                
                
            }
            else
            {
                addApprove = "No";
            }
        }
        public void AddDollars (int addDollars)
        {
            if(addApprove=="Yes")
            {
                _dollars = _dollars + addDollars;
            }
        }
        public void SubDollars(int subDollars)
        {
            if(subApprove=="Yes")
            {
                _dollars = _dollars - subDollars;
            }
            
        }
        public void AddCents(int addCents)
        {
            if(addApprove=="Yes")
            {
                _cents = _cents + addCents;
            }
        }
        public void SubAmount(decimal subAmount)
        {
            if(subAmount>_amount)
            {
                Console.WriteLine("The amount is greater than the balance.");
                subApprove = "No";
            }
            else
            {
                _amount = _amount - subAmount;
            }
        }
        public void SubCents(int subCents)
        {
            if(subApprove=="Yes")
            {
                _cents = _cents - subCents;
            }
            
        }
        public override string ToString()
        {
            return ($"The amount is {_amount.ToString("C")}");
        }
    }
}
