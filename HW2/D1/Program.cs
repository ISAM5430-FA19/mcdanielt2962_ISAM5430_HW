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
            int iter = 0;
            int countpos = 0;//problem D1
            int countzero = 0;//problem D2
            int counteven = 0;//problem D3
            int order = 0;//probelm D4
            bool tf=true;//problem D4
            int max = 0;//problem D5
            int min = 0;//problem D6
            int sum = 0;
            WriteLine(count1 % 2);
            while (iter<count1)
            {
                WriteLine("Please enter a number.");
                int num1 = Convert.ToInt32(ReadLine());


                if (iter==0)//problem D4
                {
                    order = num1;
                    
                    
                }
                else
                {
                    if (num1>order)
                    {
                        order = num1;
                    }
                    else
                    {
                        tf = false;
                    }
                }
                if (iter==0)//problem D5
                {
                    max = num1;
                }
                else
                {
                    if(num1>max)
                    {
                        max = num1;
                    }
                }
                if (iter == 0)//problem D5
                {
                    min = num1;
                }
                else
                {
                    if (num1 < min)
                    {
                        min = num1;
                    }
                }

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

                if (count1 % 2 == 0)
                {
                    if (iter + 1 <= count1 / 2)
                    {
                        sum += num1;

                    }
                    else if (iter + 1 > count1 / 2)
                    {
                        sum -= num1;

                    }
                }
                else
                {
                    if (iter + 1 <= count1 / 2)
                    {
                        sum += num1;
                        WriteLine(sum);
                    }
                    else if (iter + 1 > count1 / 2 + 1)
                    {
                        sum -= num1;
                        WriteLine(sum);
                    }
                }
            
                
                iter += 1;
                
                
            }
            WriteLine($"There were {countpos} positive numbers");//problem D1
            WriteLine($"There were {countzero} zeros.");//problem D2
            WriteLine($"There were {counteven} even numbers.");//problem D3
            WriteLine($"The max number is {max}.");//problem D5
            WriteLine($"The min number is {min}.");//problem D6
            WriteLine(sum);
            if (tf==true)
            {
                WriteLine("The numbers were in increasing order.");//problem D4
            }
            else
            {
                WriteLine("The numbers were not in increasing order.");//problem D4
            }
            if(sum>0)
            {
                WriteLine("The first half of the numbers was greater than the second half.");
            }
            else
            {
                WriteLine("The first half of the numbers was not greater than the second half.");
            }

        }
    }
}
