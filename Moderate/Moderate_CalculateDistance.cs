using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Challenge_CalculateDistance
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

                    // variable declarations for regex matching
                    List<string> CoordinateSet = new List<string>();

                    // regex remove whitespace, looks like (25,4)(1,-6) now
                    string CleanSet = Regex.Replace(line, @"\s+", "");
                    // regex match first set of parentheses
                    Match CoordsMatch = Regex.Match(CleanSet, @"\((.*?)\)");
                    while (CoordsMatch.Success)
                    {
                        string Set = CoordsMatch.Groups[0].Value;
                        CoordinateSet.Add(Set);
                        CoordsMatch = CoordsMatch.NextMatch();
                    }

                    // add set to variables
                    string FCoord = CoordinateSet[0];
                    string SCoord = CoordinateSet[1];

                    string CleanFCoord = FCoord.Replace("(", "").Replace(")", "");
                    string CleanSCoord = SCoord.Replace("(", "").Replace(")", "");

                    List<string> FCoordSet = CleanFCoord.Split(',').ToList<string>();
                    List<string> SCoordSet = CleanSCoord.Split(',').ToList<string>();

                    // variables for distance formula 
                    // first coordinates
                    int x1 = Convert.ToInt32(FCoordSet[0]);
                    int y1 = Convert.ToInt32(FCoordSet[1]);
                    // second coordinates
                    int x2 = Convert.ToInt32(SCoordSet[0]);
                    int y2 = Convert.ToInt32(SCoordSet[1]);

                    // distance formula
                    // d = sqrt((x2 - x1)^2 + (y2-y1)^2)
                    // add first portion of distance formula, and raise to 2nd power
                    double add1 = Math.Pow((x2 - x1), 2);
                    // add second portion of distance formula, raise to 2nd power
                    double add2 = Math.Pow((y2 - y1), 2);
                    // square root of first portion and second portion of distance formula
                    double d = Math.Sqrt((add1 + add2));

                    Console.WriteLine(d);
                }

            // Exit with success code 0
            Environment.Exit(0);
        }
    }
}
