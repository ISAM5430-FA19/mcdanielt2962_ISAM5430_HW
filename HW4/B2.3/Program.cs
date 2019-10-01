using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char a='A';a<='H';a++)
            {
                for(char b='A';b<='H';b++)
                {
                    Write(a + "" + b+"; ");
                }
            }
            WriteLine();
        }
    }
}
