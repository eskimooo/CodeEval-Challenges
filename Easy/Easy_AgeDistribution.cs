using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_AgeDistribution
{
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

                    // start logic
                    decimal test = Convert.ToDecimal(line);
                    if (test < 0M)
                    {
                        Console.WriteLine("This program is for humans");
                    }
                    if (test >= 0M && test < 3M)
                    {
                        Console.WriteLine("Still in Mama's arms");
                    }
                    if (test >= 3M && test < 5M)
                    {
                        Console.WriteLine("Preschool Maniac");
                    }
                    if (test >= 5M && test < 12M)
                    {
                        Console.WriteLine("Elementary school");
                    }
                    if (test >= 12M && test < 14M)
                    {
                        Console.WriteLine("Middle school");
                    }
                    if (test >= 14M && test < 19M)
                    {
                        Console.WriteLine("High school");
                    }
                    if (test >= 19M && test < 23M)
                    {
                        Console.WriteLine("College");
                    }
                    if (test >= 23M && test < 66M)
                    {
                        Console.WriteLine("Working for the man");
                    }
                    if (test >= 66M && test <= 100M)
                    {
                        Console.WriteLine("The Golden Years");
                    }
                    if (test > 100M)
                    {
                        Console.WriteLine("This program is for humans");
                    }
                }

            Environment.Exit(0);
        }
    }
}
