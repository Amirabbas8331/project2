using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter first number: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter second number: ");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A < 2)
            {

                Console.WriteLine("please enter a number greater than 2 ");
                Console.ReadLine();
                return;

            }
            Console.WriteLine("The prime numbers between " + A + " and " + B + " are:");
            int primenumber;
            int i, j;
            for (i = A; i <= B; i++)
            {
                primenumber = 0;

                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        primenumber = 1;
                        break;
                    }
                }
                if (primenumber == 0)
                {

                    Console.Write("{0} ", i);
                }
            }
            Console.ReadLine();
        }
    }
}
