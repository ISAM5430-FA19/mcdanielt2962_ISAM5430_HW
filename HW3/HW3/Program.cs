using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            decimal maxscore = 0;
            int iteration = 0;
            WriteLine("Please enter a score between 0 and 100.");
            decimal score = Convert.ToDecimal(ReadLine());

            while (score>=0 && score <=100)
            {
                if (score>maxscore)
                {
                    maxscore = score;
                    sum += score;
                    iteration += 1;
                }
                else
                {
                    sum += score;
                    iteration += 1;
                }
                WriteLine("Please enter another score between 0 and 100.");
                score = Convert.ToDecimal(ReadLine());
            }
            if(iteration>0)
            {
                decimal avg = sum / iteration;
                WriteLine("The last score was not valid.");
                WriteLine($"The average of valid scores was {avg}.");
                WriteLine($"The best valid score recorded was {maxscore}.");
            }
            else
            {
                WriteLine("The input was not a valid score and you did not enter any valid scores.");
            }
        }
    }
}
