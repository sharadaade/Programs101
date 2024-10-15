using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programs101
{
    internal class StrongNumber
    {
        
        public static int Factorial(int num)
        {
            int fact = 1;

            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;

            int strong = 0;
            
            while(number > 0)
            {
                int rem = number % 10;
                strong += Factorial(rem);
                number /= 10;
            }

            if(originalNumber == strong)
            {
                Console.WriteLine("strong number");
            }
            else
            {
                Console.WriteLine("not strong number");
            }   
        }
    }
}
