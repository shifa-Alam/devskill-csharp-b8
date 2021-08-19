using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = Rotate("aaabbcc", 2);
            Console.WriteLine(result);
        }

        public static string Rotate(string original, int count)
        {

            for (var i = 0; i < count; i++)
            {
              
                original = string.Concat(original.Substring(original.Length - 1), original);
                original = original.Remove(original.Length-1);
            }
            return original;
        }
    }
}
