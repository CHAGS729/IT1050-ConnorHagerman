﻿using System;
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
            int product; // declare sum of number 1 and number 2 
           

            Console.Write("Enter first interger: "); // prompt user 
            //read first number from user 
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second interger: "); // prompt user 
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());


            product = number1 * number2; // multiply numbers 

            string str1 = "Hello ";
            string str2 = str1 + "Connor!"; // str2 will equal Hello Connor!

            Console.WriteLine("The product is " + product); // concatenation operator
            Console.WriteLine($"The product is {product}"); // string interpolation
            Console.WriteLine("The product is {0}", product, "100"); // formatted string

            Console.ReadLine();

            /*1. At the point of execution of C# console application starts at the main entry point*/
            /*2. Float data allows a variable to store only one character. Starage size of data type is 4. A double data type is also same as float data type which allows up to 10 digits after decimal*/
            /*3. creating a block of code for a setname method. the code is public void SetName(string accontName)
             * name = accountName; // store the account name*/
            /*4. inside, Outside */
            /*5. A class is a template for objects and an object is a memebr or an "instance" of a class. You can put in one instances for a class. */

            /*
            
                This is multi-line comment

             */

        } // end Main
    } // end class Mulitplication
}