﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_HexToDecimal
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

                    int decValue = Convert.ToInt32(line, 16);
                    Console.WriteLine(decValue);
                }
        }
    }
}
