using System;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sequance = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var count = 1;
            var maxCount = 1;
            var maxNumber = 0;
            var pos = 0;

            while (pos < sequance.Count - 1)
            {
                if (sequance[pos] == sequance[pos + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxNumber = sequance[pos];
                    }

                }
                else
                {
                    count = 1;
                }
                pos++;

                if (maxCount == 1)
                {
                    maxNumber = sequance[0];
                }


            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{maxNumber} ");

            }
            Console.WriteLine();

        }
    }
}

