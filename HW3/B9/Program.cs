using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9
{
    class Program
    {
        static void Main(string[] args)
        {
            int bina = 0;
            int reverse = 0;
            WriteLine("Enter a number.");
            int num = Convert.ToInt32(ReadLine());
            while (num != 0)
            {
                bina = bina * 10;
                bina = bina + num % 2;
                num = num / 2;
                
            }
            while (bina!=0)
                {
                reverse = reverse * 10;
                reverse = reverse + bina % 10;
                bina = bina / 10;
               
            }
        
            WriteLine($"The binary for your number is {reverse}.");
        }
    }
}
