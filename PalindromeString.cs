using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs101
{
    internal class PalindromeString
    {

        public static bool Palindrome(string s)
        {
            s.ToLower();
            char[] c = s.ToCharArray();

            int start = 0;
            int end = s.Length - 1;



            while (start < end)
            {
                if (c[start] != c[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string st = Console.ReadLine();

            bool result = Palindrome(st);

            if(result)
            {
                Console.WriteLine("palinrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
}
