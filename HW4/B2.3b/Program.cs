using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._3b
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char a='A';a<='H';a++)
            {
                for(char b='A';b<='H';b++)
                {
                    bool vowelA = a == 'A' || a == 'E';
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if(vowels==1)
                    {
                        Write($"{a}{b}; ");
                    }
                }
            }
            WriteLine();
        }
    }
}
