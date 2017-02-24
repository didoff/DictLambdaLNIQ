using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;

            // 5 2 3 6

            // 5  6  +
            // 2  3

            // 1 2 3 4 5 6 7 8

            // 2  1  8  7 +
            // 3  4  5  6 =
            // 5  5 13 13

            int[] row1left = input.Take(k).Reverse().ToArray();
            int[] row1right = input.Reverse().Take(k).ToArray();
            int[] row1 = row1left.Concat(row1right).ToArray();
            int[] row2 = input.Skip(k).Take(2 * k).ToArray();

            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
