using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++; // i = i + 1;
            }

            int p = 5;
            while (p < 20)
            {
                Console.WriteLine(i);
                p--; // i = i + 5;
            }

            Console.WriteLine("Program complete");
            /*
             * For Loop: https://www.youtube.com/watch?v=lvbVZ1C1rrk
             * If statement: https://www.youtube.com/watch?v=z_B7oVDs-tA
             * While Loop: https://www.youtube.com/watch?v=7JX2XH4zeNM
             */

            int intPi = 22 / 7;
            float floatPi = 22f / 7f;
            double doublePi = 22d / 7d;
            decimal decimalPi = 22m / 7m;

            Console.WriteLine($"int: {intPi}");
            Console.WriteLine($"float: {floatPi}");
            Console.WriteLine($"double: {doublePi}");
            Console.WriteLine($"decimal: {decimalPi}");

            int speedLimit = 35;
            int speed = 35;

            if (speed == speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }
            else if (speed <= 35)
            {
                Console.WriteLine("Your speed is little slow, True");
            }
            else if (speed >= 35)
            {
                Console.WriteLine("You're going a little fast, False");
            }

            /*
             * 	1.	if statement - Write a program that converts a Fahrenheit temperature to Celsius.  The user should be able to input the temperature at the Command prompt and it should output the temperature.  In addition, you should output “It is cold” if the Fahrenheit value is less that 40 or it should output “It is hot” if the temperature is over 90. 
             */
            double fahrenheit;
            Console.Write("Enter a temperature: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32d) * 5d / 9d;

            if (fahrenheit >= celsius)
            {
                Console.WriteLine("It is hot"); 
            }
            if (celsius == fahrenheit)   
            {
                Console.WriteLine("It is cold");
            }

            Console.WriteLine("Program is done");
        }
    }
}
