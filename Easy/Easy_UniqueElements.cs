using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_UniqueElements
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

                    List<string> NumberList = line.Split(',').ToList<string>();
                    var numbers = (from n in NumberList select n).Distinct().ToList();
                    Console.Write(string.Join(",", numbers));
                }

            Environment.Exit(0);
        }
    }
}
