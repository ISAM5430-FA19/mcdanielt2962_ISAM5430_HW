using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(ReadLine());
            WriteLine("Please enter a second unique number.");
            int num2 = Convert.ToInt32(ReadLine());
            WriteLine("Please enter a third unique number.");
            int num3 = Convert.ToInt32(ReadLine());

            if (num1 > num2 && num1 < num3)
            {
                WriteLine($"{num1} is the middle number");
            }
            else if (num2 > num1 && num2 < num3)
            {
                WriteLine($"{num2} is the middle number");
            }
            else
            {
                WriteLine($"{num3} is the middle number");
            }
            //there is a fourth option where there are dulicate numbers given. In this case, another line would have to address
            //this situation, returning that there is no middle number.

        }
    }
}
