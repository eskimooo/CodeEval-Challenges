using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Challenge_ReadMore
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string text = reader.ReadLine();
                    if (null == text)
                        continue;

                    if (text.Length <= 55)
                    {
                        Console.WriteLine(text);
                    }

                    if (text.Length > 55)
                    {
                        string ShortText = text.Substring(0, 40);

                        // shortened text logic
                        int index1 = ShortText.LastIndexOf(" ", 40);
                        if (index1 != -1)
                        {
                            ShortText = ShortText.Substring(0, ShortText.LastIndexOf(" ", 40));
                            Console.WriteLine(ShortText + "... <Read More>");
                        }
                        else
                        {
                            ShortText = ShortText.Substring(0, 40);
                            Console.WriteLine(ShortText + "... <Read More>");
                        }

                    }

                }
            // exit with success 0
            Environment.Exit(0);
        }

    }
}