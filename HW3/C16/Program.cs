using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Enter a number.");
            int n = Convert.ToInt32(ReadLine());
            int iter, num, z; //where iter is the iteration, num is the number of numbers, and z is the number of zeros.
            for (iter = 1; iter <= n; iter++)
            {
                for (z = 1; z <= n - iter; z++)
                {
                    Write("0,");

                }

                for (num = iter; num >= 1; num--)
                {
                    Write(num+",");
                }
                WriteLine();
            }
                      
        }   
    }
}
