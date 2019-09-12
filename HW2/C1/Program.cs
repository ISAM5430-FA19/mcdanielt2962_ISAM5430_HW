using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("C.1.1");
            int num = 20;
            while (num > 0)
            {
                WriteLine(num);
                num -= 1;
            }
            WriteLine("C.1.2");
            int num2 = 1;
            while (num2 < 11)
            {
                if (num2 % 2 == 0)
                {
                    WriteLine(num2);
                }
                num2 += 1;
            }
            WriteLine("C.1.3");
            int num3 = 1;
            while (num3 < 100)
            {
                if (num3 % 10 == 0)
                {
                    WriteLine(num3);
                }
                num3 += 1;
            }
            WriteLine("C.1.4");
            int num4 = 1;
            while (num4 < 21)
            {
                if (num4 % 2 != 0 && num4 % 3 != 0)
                {
                    WriteLine(num4);
                }
                num4 += 1;
            }
            WriteLine("C.1.5");
            int num5 = 1;

            while (num5 * num5 < 100)
            {
                if ((int)(num5 * num5) > 9)
                {
                    WriteLine(num5 * num5);
                }
                num5 += 1;
            }
            WriteLine("C.1.6");
            int num6 = 1;

            while (num6 < 100)
            {
                if (num6 % 3 != 0 && num6 % 5 != 0 || (num6 % 3 == 0 && num6 == 0))
                {
                    WriteLine(num6);
                }
                num6 += 1;
            }
            WriteLine("C.1.7");
            //char letter = 'a';
            int num7 = 97;

            while (num7 < 123)
            //while (letter<letter+27)
            {
                //WriteLine(((char)letter).ToString());
                WriteLine(((char)num7).ToString());
                //letter=+1
                num7 += 1;
            }
        }
    }
}
