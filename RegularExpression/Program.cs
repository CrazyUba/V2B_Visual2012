using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string testString = "test9test";

            Match match = regex.Match(testString);

            Console.WriteLine(testString);
            Console.WriteLine($"pattern: {pattern}");
            Console.WriteLine();
            Console.WriteLine($"match.Success: {match.Success}");
            Console.WriteLine($"match.Value: {match.Value}");
            Console.WriteLine($"match.Index: {match.Index}");
            Console.WriteLine($"match.Length: {match.Length}");

        }
    }
}
