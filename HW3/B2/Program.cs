using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
                                    
            WriteLine("Please enter a number."); //get an initial number
            int userNum = Convert.ToInt32(ReadLine()); 
            int prevNum = userNum; //this will be the first comparison number
            int sum = userNum; //use the inital number to start the sum
            WriteLine("Please enter another number."); //ask for the next number
            int userNum2 = Convert.ToInt32(ReadLine()); 
            while (userNum2!=prevNum) //compare the intiial number to the next number
            {
                prevNum = userNum2; //overwrite the control number for each iteration until the numbers match (duplicated a number in a row)
                sum += userNum2; //add the number to the sum if it does not match
                WriteLine("Please enter another number."); //ask for the next number to repeat the loop
                userNum2 = Convert.ToInt32(ReadLine()); //overwrite the compar number and let hte loop start over.
            }
            sum += userNum2; //if there were two numbers matching in a row, the loop exits and adds the last number given to the sum.
            WriteLine($"The sum of your numbers is {sum}."); //return the sum of all numbers given.
        }
    }
}
