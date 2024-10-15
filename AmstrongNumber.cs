using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs101
{
    internal class AmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            int result = 0;
            while(number > 0)
            {
                int rem = number % 10;
                result += (rem * rem * rem);
                number /= 10;
            }

            if(originalNumber == result)
            {
                Console.WriteLine("Amstrong number");
            }
            else
            {
                Console.WriteLine("Not Amstrong number");
            }

        }
    }
}
