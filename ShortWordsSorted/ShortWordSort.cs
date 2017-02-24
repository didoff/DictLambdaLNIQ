using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class ShortWordSort
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .ToLower()
                .Split('.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '/', '!', '?', ' ', '\'', ' ')
                .ToList();

            List<string> result = input
                .Where(l => l.Length < 5)
                .Where(l => l != "")
                .OrderBy(a => a)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
