using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // logic
            using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                string[] SentenceParts = line.Split(null);
                Array.Reverse(SentenceParts);
                Console.WriteLine(CombineString(SentenceParts));
            }

            // exit with success code
            Environment.Exit(0);
        }

        static string CombineString(string[] arr)
        {
            return String.Join(" ", arr);
        }
    }
}
