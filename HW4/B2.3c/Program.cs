using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._3c
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char a='A';a<='H';a++)
            {
                for(char b='A';b<='H';b++)
                {
                    bool vowelA = a == 'A' || a == 'E';
                    bool vowelB = b == 'A' || b == 'E';
                    int vowa = (vowelA ? 1 : 0);
                    int vowb = (vowelB ? 1 : 0);
                    if(vowa==0 &&vowb==1)
                    {
                        Write($"{a}{b}; ");
                    }

                }
            }
            WriteLine();
        }
    }
}
