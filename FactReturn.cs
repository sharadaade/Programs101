using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs101
{
    internal class FactReturn
    {
        public static int Fact(int n)
        {
            int Result_fact = 1;
            for(int i = 1; i <= n; i++)
            {
                Result_fact *= i;
            }
            return Result_fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = Fact(num);

            Console.WriteLine($"Factorial is {result}");
        }
    }
}
