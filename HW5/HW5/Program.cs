using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.B
{
    class WithdrawlTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
            Console.WriteLine("Deposit or Withdrawl?");
            string decision=Console.ReadLine();
            if(decision=="Deposit")
            {
                Console.Write("\nEnter deposit amount for account1: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
                account1.Deposit(depositAmount);
                Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
                Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
                Console.Write("\nEnter deposit amount for account2: ");
                depositAmount = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
                account2.Deposit(depositAmount);
                Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
                Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
            }
            if(decision=="Withdrawl")
            {
                Console.Write("\nEnter withdrawl amount for account 1: ");
                decimal withdrawlAmount = decimal.Parse(Console.ReadLine());
                Console.WriteLine($" subtracting {withdrawlAmount:C} from account1 balance\n");
                account1.Withdrawl(withdrawlAmount);
                Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
                Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
                Console.Write("\nEnter withdrawl amount for account 2: ");
                withdrawlAmount = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
                Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
            }
            else
            {
                Console.WriteLine("The selection was invalid.");
            }
            
        }
    }
}
