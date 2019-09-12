using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(ReadLine());
            WriteLine("Please enter a second number.");
            int num2 = Convert.ToInt32(ReadLine());

            if (num2 < num1)
            {
                WriteLine($"{num1} is larger.");
            }
            else if (num2 > num1)
            {
                WriteLine($"{num2} is larger.");
            }
            else
            {
                WriteLine("The numbers are the same.");
            }
        }
    }
}
