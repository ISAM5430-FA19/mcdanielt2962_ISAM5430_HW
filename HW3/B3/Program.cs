using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a number.");
            int num = Convert.ToInt32(ReadLine());
            int maxnum = num;
            int prvnum = num;
            WriteLine("Please enter another number that is greater.");
            int num2 = Convert.ToInt32(ReadLine());
            while (num2>prvnum)
            {
                prvnum = num2;
                maxnum = num2;
                WriteLine("Please enter another number that is greater.");
                num2 = Convert.ToInt32(ReadLine());
            }
            WriteLine($"The last number was lower so your highest number was {maxnum}.");
        }
    }
}
