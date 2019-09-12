using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("C.2.8");
            int start = 1;
            while (start < 100)
            {
                WriteLine(start);
                start *= 2;
            }
            WriteLine("C.2.9");
            int start9 = 100;
            while (start9>=1)
            {
                WriteLine(start9);
                start9 /= 2;
            }
            WriteLine("0");

            WriteLine("C.2.10");
            double start10 = 100;
            while (start10>=1)
            {
                WriteLine(start10);
                start10 /= 2;
            }
        }
    }
}
