using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_LongestWord
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
                    // create a sentence list from each item in the sentence
                    string[] SentenceList = line.Split(null);
                    string LongestWord = SentenceList.OrderByDescending(s => s.Length).First();
                    Console.Write(LongestWord);

                    // new line after finishing each sentence in list
                    Console.Write("\n");
                }

            //string[] list = new string[] {"some line with text", "another line"};

            //// testing logic
            //foreach (string text in list)
            //{
            //    // create a sentence list from each item in the sentence
            //    string[] SentenceList = text.Split(null);
            //    string LongestWord = SentenceList.OrderByDescending(s => s.Length).First();
            //    Console.Write(LongestWord);

            //    // new line after finishing each sentence in list
            //    Console.Write("\n");
            //}

            // exit with success code
            //Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
