using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Program3
    {
        public static void PrimeNumbers()
        {
            int n, i,temp = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            for (i = 2; i <=n; i++)
            {
                if (n % i == 0)
                {
                    temp = temp + 1;
                }
            }
            if (temp == 1)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
        }
    }
}
