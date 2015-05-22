using System;
using System.IO;

// https://www.codeeval.com/open_challenges/20

namespace Challenge_Lowercase
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
                Console.WriteLine(Convert.ToString(line).ToLower());
            }
        }
    }
}
