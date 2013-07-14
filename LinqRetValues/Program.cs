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
            Console.ReadLine();
        }

        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Rurple" };

            // Обратитк внимание, что subset представляет собой объект, совместимый с IEnumerable<string>
            IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
            return theRedColors;
        }
    }
}
