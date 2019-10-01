using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectEuler022
{
    class Program
    {
        static void Main(string[] args)
        {
            // create array and sort
            ArrayList lines = createArray("names.txt");
            lines.Sort();

            //solve
            Console.WriteLine(solve(lines));
        }

        public static ArrayList createArray(String fileName)
        {
            // create variable for line, lines, and location of file
            string line;
            ArrayList lines = new ArrayList();
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);

            // read lines
            while ((line = file.ReadLine()) != null)
            {
                // find all values that start and end with "
                var reg = new Regex("\".*?\"");
                var matches = reg.Matches(line);
                foreach (var item in matches)
                { 
                    // trim "
                    lines.Add(item.ToString().Trim('"'));
                }
            }

            return lines;
        }

        public static int solve(ArrayList names)
        {
            // total score
            int totalScore = 0;

            // get each name
            foreach(string name in names)
            {
                // get the value of characters in each name
                int nameValue = 0;
                foreach(char c in name)
                {
                    // gets character value (1-26)
                    nameValue+=char.ToUpper(c) - 64;
                }

                // adds character value to index value + 1
                totalScore += (nameValue * (names.IndexOf(name)+1));
            }

            return totalScore;
        }
    }
}
