using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            WriteLine("Please enter a number.");
            int input=Convert.ToInt32(ReadLine());
            int smallest = input;
            while(input>0)
            {
                if(input>=smallest*smallest)
                {
                    count += 1;
                    WriteLine("Please enter a number.");
                    input = Convert.ToInt32(ReadLine());
                    smallest = input;
                }
                else if (input<smallest)
                {
                    smallest = input;
                    WriteLine("Please enter a number.");
                    input = Convert.ToInt32(ReadLine());
                }
                else
                {
                    WriteLine("Please enter a number.");
                    input = Convert.ToInt32(ReadLine());
                }

            }
            WriteLine($"There were {count} sets.");
            
        }

    }
}
