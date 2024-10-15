using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs101
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            for(int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Fatorial " + fact);
        }
    }
}
