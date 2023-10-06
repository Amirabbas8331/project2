using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pn, rev = 0; int rem;
            Console.Write("please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            pn = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            if (rev == pn)
            {
                Console.WriteLine($"{pn} is polindrome ");
            }
            else
            {
                Console.WriteLine($"{pn} is not polindrome ");
            }
            Console.ReadKey();
        }
    }
}
