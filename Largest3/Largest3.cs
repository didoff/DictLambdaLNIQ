using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3
{
    class Largest3
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            List<int> intNum = new List<int>();

            foreach (var num in input)
            {
                intNum.Add(Int32.Parse(num));
            }

            intNum = intNum.OrderByDescending(x => x)
                .Take(3)
                .ToList();

            foreach (var num in intNum)
            {
                Console.Write(num);
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}
