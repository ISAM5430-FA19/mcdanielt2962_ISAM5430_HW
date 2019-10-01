using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._5a
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i='A';i<='H';i++)
            {
                for (char j='A';j<='H';j++)
                {
                    bool voweli = i == 'A' || i == 'E';
                    bool vowelj = j == 'A' || j == 'E';
                    int vowels2 = (voweli ? 1 : 0) + (vowelj ? 1 : 0);
                    if(vowels2>=1)
                    {
                        Write($"{i}{j}, ");
                    }
                    for (char z='A';z<='H';z++)
                    {
                        bool vowelz = z == 'A' || z == 'E';
                        int vowels3 = (voweli ? 1 : 0) + (vowelj ? 1 : 0) + (vowelz ? 1 : 0);
                        if(vowels3>=1)
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
