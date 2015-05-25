using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_DecimalToBinary
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
                    int InputNumber = Convert.ToInt32(line);
                    string NumberToBinary = Convert.ToString(InputNumber, 2);
                    Console.WriteLine(NumberToBinary);
                }

        }
    }
}
