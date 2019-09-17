using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            int reverse = 0;
            WriteLine("Enter a number.");
            int num = Convert.ToInt32(ReadLine());
            while (num!=0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
                
            }
            WriteLine($"Reverse of the number is {reverse}.");
        }
    }
}
