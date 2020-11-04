using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Multiplication 
    {
        static void Main(string[] args)
        {
            int number1; // declare first number to multiply
            int number2; // declare first number to multiply 
            int sum; // declare sum of number 1 and number 2 

            Console.Write("Enter first interger: "); // prompt user 
            //read first number from user 
            number1 = Convert.ToInt32(Console.ReadLine() );

            Console.Write("Enter second interger: "); // prompt user 
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine()); 

            sum = number1 * number2; // multiply numbers 

            Console.WriteLine("Sum is {0}", sum ); // display sum

        } // end Main
    } // end class Mulitplication 

}