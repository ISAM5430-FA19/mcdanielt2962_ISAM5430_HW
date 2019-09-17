using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            int reverse = 0;
            WriteLine("Enter the first number.");
            int num1 = Convert.ToInt32(ReadLine());
            WriteLine("Enter the second number.");
            int num2 = Convert.ToInt32(ReadLine());
            int sum = num1 + num2;
            while(sum!=0)
            {
                reverse = reverse * 10;
                reverse = reverse + sum % 10;
                sum = sum / 10;
            }
            WriteLine($"The reverse sum is {reverse}.");
        }

        
    }
}
