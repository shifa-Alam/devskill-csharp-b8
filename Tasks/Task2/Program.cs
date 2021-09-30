using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            var result = x.IsOdd();
            Console.WriteLine(result);
        }

        public static bool IsOdd(int a)
        {
            return (a % 2 != 0);
        }
    }
}
