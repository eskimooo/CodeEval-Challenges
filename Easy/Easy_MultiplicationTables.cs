using System;

namespace Challenge_MultTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codeeval.com/open_challenges/23/
            // Print out the grade school multiplication table up to 12*12

            int n = 1;
            int sum = 0;
            while (n <= 12)
            {
                for (int i = 1;  i <= 12; i++)
                {
                    sum = n * i;
                    Console.Write(Convert.ToString(sum).PadLeft(4));
                }
                Console.WriteLine();
                n++;
            }
            Environment.Exit(0);
        }
    }
}
