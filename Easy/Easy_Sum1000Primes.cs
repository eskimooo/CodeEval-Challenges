using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Sum1000Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codeeval.com/open_challenges/4/
            // Challenge: Write a program which determines the sum of the first 1000 prime numbers

            int sum = 0;
            int count = 0;
            int num = 2;

            while (count < 1000)
            {
                if (PrimeTool.IsPrime(num))
                {
                    sum += num;
                    count++;
                }
                num++;
            }

            if (sum == 3682913)
            {
                Console.Write(sum);
                Environment.Exit(0);
            }

        }
    }

    public static class PrimeTool
    {
        public static bool IsPrime(int possible)
        {
            if ((possible & 1) == 0)
            {
                if (possible == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= possible; i += 2)
            { 
                if ((possible % i) == 0)
                {
                    return false;
                }
            }
            return possible != 1;
        }
    }
}
