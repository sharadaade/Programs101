using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs101
{
    internal class Fibbonacci
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            int a = 0, b = 1, next = a + b;

            Console.WriteLine($"{a} {b}");
            for(int i = 0; i < num; i++)
            {
                next = a + b;
                a = b;
                b = next;
                Console.WriteLine($"{next}");
            }
        }
    }
}
