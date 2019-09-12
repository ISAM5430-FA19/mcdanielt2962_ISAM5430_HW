using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("C.3.11");
            int num11 = 2;
            int prvnum11 = 1;
            int total11 = 1;
            int max = 0;
            
            while (max<1000)
            {                
                while(prvnum11>=2)
                {
                    
                    total11 = total11 * prvnum11;                    
                    prvnum11 -= 1;
                                        
                }
                if(total11<1000)
                {
                    WriteLine(total11);
                }
                
                max = total11;
                num11 += 1;
                total11 = num11;
                prvnum11 = num11 - 1;                
                
            }

            WriteLine("C.3.12");
            
            int sum12 = 0;
            int prvnum1 = 0;
            int prvnum2 = 1;
            int count12 = 0;
            WriteLine(prvnum1);
            WriteLine(prvnum2);
            count12 += 2;
            while (count12<25)
            {
                sum12 = prvnum1 + prvnum2;
                prvnum1 = prvnum2;
                prvnum2 = sum12;
                count12 += 1;
                WriteLine(sum12);
            }
            
        }
    }
}
