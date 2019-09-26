using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int iter = 0;
            bool check = false;
            bool check2 = false;
            bool check3 = false;
            while(iter<5)
            {
                WriteLine("Enter a number.");
                int num = Convert.ToInt32(ReadLine());
                if(num==2&&check==false)
                {
                    check = true;
                }
                
                else if(num!=2&&check==true)
                {
                    check2 = true;
                }
                else if(num==2&&check2==true)
                {
                    check3 = true;
                }
                iter += 1;
            }
            if (check3==true)
            {
                WriteLine("The 2s are not next to each other.");
            }
            else
            {
                WriteLine("The 2s are next to each other.");
            }
        }
    }
}
