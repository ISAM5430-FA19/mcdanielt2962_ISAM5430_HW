using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._4a
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='H';i++)
            {
                for(char j='A';j<='H';j++)
                {
                    for(char z='A';z<='H';z++)
                    {
                        bool voweli = i == 'A' || i == 'E';
                        bool vowelj = j == 'A' || j == 'E';
                        bool vowelz = z == 'A' || z == 'E';
                        int vowels = (voweli ? 1 : 0) + (vowelj ? 1 : 0) + (vowelz ? 1 : 0);
                        if(vowels>=1)
                        {
                            Write($"{i}{j}{z}, ");
                        }
                    }
                }
                    
            }
            WriteLine();
        }
    }
}
