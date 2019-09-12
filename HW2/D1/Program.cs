using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a count.");
            int count1 = Convert.ToInt32(ReadLine());
            int countpos = 0;
            int countzero = 0;//problem D2
            int counteven = 0;//problem D3
            
            while (count1>0)
            {
                WriteLine("Please enter a number.");
                int num1 = Convert.ToInt32(ReadLine());
                
           

                if (num1 > 0)
                {
                    countpos += 1;
                }
                if (num1 == 0)//problem D2
                {
                    countzero += 1;
                }
                if(num1!=0 && num1%2==0)
                {
                    counteven += 1;
                }
                
                count1 -= 1;
                
                
            }
            WriteLine($"There were {countpos} positive numbers");
            WriteLine($"There were {countzero} zeros.");//problem D2
            WriteLine($"There were {counteven} even numbers.");//problem D3
            

        }
    }
}
