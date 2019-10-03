using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a number.");
            int n = Convert.ToInt32(ReadLine());
            WriteLine("Please enter another number.");
            int d= Convert.ToInt32(ReadLine());
            int z = 1;
            for (int i=1;i<=d;i++)
            {
                z = z * 10;
            }            
            if((n%z)%2 ==0)
            {
                WriteLine("The number is divisable");
            }

        }
    }
}
