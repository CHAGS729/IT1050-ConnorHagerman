using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Connor Hagerman");

            int number1; // declare first number to multiply
            int number2; // declare first number to multiply 
            int sum; // declare sum of number 1 and number 2 

            Console.Write("Enter first interger: "); // prompt user 
            //read first number from user 
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second interger: "); // prompt user 
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(number1 * number2 ); // display sum

            sum = number1 * number2; // multiply numbers 

            Console.ReadLine();

        }
    }
}

            /* 1. one similarity between these two statements is that both of them work only if the given condition is true. if the condition is 
             * not true there is not alternate flow of execution. 
             2. the second similarity is that the syntax and structure of both of the statements is amost the same.
            3. the third similarity is the if single selection statement and while loop can be used interchangeably. 
            
             /*The differences between the if single selection and the while repetition can be tabulated. 
                The if single selection can be guarenteed to run only one time or never. Plus the behavior of the single selection statement can be determined in most of the cases. 
                Teh while repetition statement mignt run many times. It can soemtimes run forever if the given condition does not become false ever. 
                Plus the behavior of the while repetition cannot be determined until ruun times in many cases. */
