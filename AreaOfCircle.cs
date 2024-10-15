using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs101
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle : ");
            double radius = double.Parse(Console.ReadLine());

            double area = 3.14 * radius * radius;

            Console.WriteLine("Area of circle is : " + area);
        }
    }
}
