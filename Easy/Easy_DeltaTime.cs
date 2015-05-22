using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_DeltaTime
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
                    string[] TimeSetVal = line.Split(null);
                    DateTime FirstSet = DateTime.Parse(TimeSetVal[0]);
                    DateTime SecondSet = DateTime.Parse(TimeSetVal[1]);
                    if (FirstSet > SecondSet)
                    {
                        TimeSpan ts = FirstSet - SecondSet;
                        Console.WriteLine(ts.ToString());
                    }
                    if (SecondSet > FirstSet)
                    {
                        TimeSpan ts = SecondSet - FirstSet;
                        Console.WriteLine(ts.ToString());
                    }
                    if (FirstSet == SecondSet)
                    {
                        TimeSpan ts = SecondSet - FirstSet;
                        Console.WriteLine(ts.ToString());
                    }
                }

            // exit success code 0
            Environment.Exit(0);

        }
    }
}
