using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Money myMoney = new Money();
            Console.WriteLine($"Initial amount is: {myMoney.GetAmount()}");
            Console.WriteLine($"Inital dollars is: {myMoney.GetDollars()}");
            Console.WriteLine($"Initial cents is: {myMoney.GetCents()}");
            Console.Write("Please enter a full amount dollars and cents. $ ");
            decimal theAmount = Convert.ToDecimal(Console.ReadLine());
            myMoney.SetAmount(theAmount);
            int theDollars = Convert.ToInt32(theAmount);
            myMoney.SetDollars(theDollars);            
            int theCents = (int)((theAmount - (int)theAmount) * 100);
            myMoney.SetCents(theCents);
            Console.WriteLine($"Updated amount is: {myMoney.GetAmount()}");
            Console.WriteLine($"Updated dollars is: {myMoney.GetDollars()}");
            Console.WriteLine($"Updated cents is: {myMoney.GetCents()}");
            Console.WriteLine($"The currency breakdown is: {myMoney.GetCurrency()}");
            Console.Write("Would you like to add or subtract from the amount? Y or N ");
            string decision = Console.ReadLine();
            if(decision == "Y")
            {
                Console.Write("Would you like to add or subtract? ");
                string addSubtract = Console.ReadLine();
                if(addSubtract=="add")
                {
                    Console.Write("Please input the amount to add. ");
                    decimal addAmount = Convert.ToDecimal(Console.ReadLine());
                    myMoney.AddAmount(addAmount);
                    theDollars= Convert.ToInt32(addAmount);
                    myMoney.AddDollars(theDollars);
                    theCents = (int)((addAmount - (int)addAmount) * 100);
                    myMoney.AddCents(theCents);
                }
                else
                {
                    Console.Write("Please input the amount to subtract. ");
                    decimal subAmount = Convert.ToDecimal(Console.ReadLine());
                    myMoney.SubAmount(subAmount);
                    theDollars = Convert.ToInt32(subAmount);
                    myMoney.SubDollars(theDollars);
                    theCents = (int)((subAmount - (int)subAmount) * 100);
                    myMoney.SubCents(theCents);
                }

            }
            Console.WriteLine($"Updated amount is: {myMoney.GetAmount()}");
            Console.WriteLine($"Updated dollars is: {myMoney.GetDollars()}");
            Console.WriteLine($"Updated cents is: {myMoney.GetCents()}");
            Console.WriteLine($"The currency breakdown is: {myMoney.GetCurrency()}");
            Console.WriteLine(myMoney.ToString());
        }
    }
}
