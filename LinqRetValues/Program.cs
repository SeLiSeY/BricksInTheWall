using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with LINQ Transformations *****\n");
            IEnumerable<string> subset = GetStringSubset();
            foreach (string item in subset) { Console.WriteLine(item);  }

            Console.WriteLine();
            foreach (string item in GetStrinfSubsetAsArray()) { Console.WriteLine(item); }

            Console.ReadLine();
        }

        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Rurple" };

            // Обратите внимание, что subset представляет собой объект, совместимый с IEnumerable<string>
            IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
            return theRedColors;
        }

        static string[] GetStrinfSubsetAsArray()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Rurple" };

            var theRedColors = from c in colors where c.Contains("Red") select c;
            return theRedColors.ToArray();
        }
    }
}
