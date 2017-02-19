using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount_Example
{
    class OddOccurances
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if(counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            var outP = new List<string>();

            
            foreach (var entry in counts)
            {
                if(entry.Value % 2 != 0)
                {
                    outP.Add(entry.Key);
                }
            }

            Console.WriteLine(string.Join(", ", outP));

        }
    }
}
