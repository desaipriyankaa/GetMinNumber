using System;
using System.Linq;

namespace GetMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 15, 18, -8, -9, -7, 20 };
            int min = numbers.Min();
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Minimum value in array : " + min);
        }
    }
}
