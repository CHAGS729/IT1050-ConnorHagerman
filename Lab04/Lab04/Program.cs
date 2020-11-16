using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. A control variable (or loop counter)
             * 2. the control variable's initial vaule 
             * 3. the control variable's increment that's applied during each iteration of the loop,
             * 4. the loop-continuation conditon that determines if loopign should continue. 
             */

            /* The "while" loop can be used to implement any counter-controlled loop. The "for" loop which specifies
             * the elements of counter-controlled iteration i a sinlge line of code.  
             * However, while and for loop can each be used for either iteration type. 
             */

            /* The do while statement is similar to the while statement. In the while the app test the loop continuation condition at the beginning of the loop. The do while statement test the loop continuation condtion after executing the loop body. Therefore, the body always executes at least once. 
             * 
             */

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine(i); 
            }

            Console.WriteLine("Program complete");
        }
    }
}
