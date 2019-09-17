using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {//This takes into account absolute value difference. If the original number is 10, 11 is as close to 10 as 9.
            WriteLine("Please enter an initial number.");
            int item = Convert.ToInt32(ReadLine());
            WriteLine("Please enter another number.");
            int input = Convert.ToInt32(ReadLine());
            int closest = input;
            int closestdif = 0;
            if (item-input>0)
            {
                closestdif = item-input;
            }
            else
            {
                closestdif = input - item;
            }                       

            while (input != item)
            {
                if (item - input > 0)
                {
                    if (item - input < closestdif)
                    {
                        closest = input;
                        closestdif = item - input;
                        WriteLine($"{closest} is the closest number so far.");
                        WriteLine("Please enter another number.");
                        input = Convert.ToInt32(ReadLine());
                    }
                    else
                    {
                        WriteLine($"{closest} is the closest number so far.");
                        WriteLine("Please enter another number.");
                        input = Convert.ToInt32(ReadLine());
                    }
                }
                else
                {
                    if (input - item < closestdif)
                    {
                        closest = input;
                        closestdif = input - item;
                        WriteLine($"{closest} is the closest number so far.");
                        WriteLine("Please enter another number.");
                        input = Convert.ToInt32(ReadLine());
                    }
                    else
                    {
                        WriteLine($"{closest} is the closest number so far.");
                        WriteLine("Please enter another number.");
                        input = Convert.ToInt32(ReadLine());
                    }
                }
            }
            WriteLine("You picked the original number.");
        }
    }
}
