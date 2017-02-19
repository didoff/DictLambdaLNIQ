using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount_Example
{
    class WordCount
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

            foreach (var entry in counts)
            {
                if(entry.Value % 2 != 0)
                {
                    Console.WriteLine(entry.Key);
                }
            }

        }
    }
}
