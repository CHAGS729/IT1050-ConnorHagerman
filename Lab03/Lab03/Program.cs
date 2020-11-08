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

            int speedLimit = 35;
            int speed = 45;

            if (speed == speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }
            else if (speed <= 35)
            {
                Console.WriteLine("True");
            }
            else if (speed >= 35)
            {
                Console.WriteLine("False");
            }
           
        }
    }
}


