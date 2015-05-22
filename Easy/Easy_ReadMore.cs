using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Challenge_ReadMore
{
    static class Program
    {
        static void Main(string[] args)
        {
            // testing logic
            string[] TextValues = new string[] { "Tom exhibited.", "Amy Lawrence was proud and glad, and she tried to make Tom see it in her face - but he wouldn't look.", "Tom was tugging at a button-hole and looking sheepish.", "Two thousand verses is a great many - very, very great many.", "Tom's mouth watered for the apple, but he stuck to his work." };
            
            foreach (string text in TextValues)
            {
                TruncateAtWord(text, 55);
                Console.WriteLine(text);
            }   

            // pause to read output
            Console.ReadKey();
            Environment.Exit(0);
        }

        //static public string Ellipsis(string text, int length)
        //{
        //    if (text.Length <= 55)
        //    {
        //        Console.WriteLine(text);
        //    }
        //    int pos = text.IndexOf(" ", length);
        //    if (pos >= 0)
        //        return text.Substring(0, pos) + "...";
        //    return text;
        //}

        public static string TruncateAtWord(this string value, int length)
        {
            if (value == null || value.Length < length || value.IndexOf(" ", length) == -1)
                return value;

            return value.Substring(0, value.IndexOf(" ", length));
        }
    }
}
