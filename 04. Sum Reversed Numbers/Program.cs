using System;
using System.Linq;

namespace _04.Sum_Reversed_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbers= Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                char[] number = numbers[i].ToArray();
                Array.Reverse(number);
                sum += int.Parse(string.Join("", number));
            }
            Console.WriteLine(sum);
        }
    }
}
