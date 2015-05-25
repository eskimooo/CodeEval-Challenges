using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                int n = Convert.ToInt32(line);

                // is even
                if (n % 2 == 0)
                {
                    Console.WriteLine(1);
                }
                // is odd
                else if (n % 2 != 0)
                {
                    Console.WriteLine(0);
                }
            }
        Environment.Exit(0);

    }
}