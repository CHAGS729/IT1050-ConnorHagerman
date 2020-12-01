using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * p[0]
             * p[1]
             * p[2]
             * p[3]
             */

            string[] months = { "Janurary", "Feburary", "March","April", "May", "June", "July", "August", "September", "October", "november", "December"};
            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(months[i]);
                Console.ReadLine();
            }

            string[] seasons = { "Winter", "Spring", "Summer", "fall" };
            foreach (string i in seasons)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

            Random random = new Random();
            int[] randomNumber = { 1, 16, 77, 10, 88, 25, 56, 76, 90, 99, 1000 };
            foreach (int randomnumber in randomNumber)
            {
                Console.WriteLine(randomNumber);
                Console.ReadLine();
            }



            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int n= 0;
            while (n < names.Length)
            {
                Console.WriteLine(names[n]);
                n++;
                Console.ReadLine();
            }

            string[] name = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int p = 0;
            foreach (var character in names) ;
            Console.WriteLine(name);
            Console.WriteLine(p);
            Console.ReadLine();

           


        }
    }
}
