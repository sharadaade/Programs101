using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs101
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number <= 1)
            {
                Console.WriteLine("Not prime number");
            }


        }
    }
}
