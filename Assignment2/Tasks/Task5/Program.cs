using System;
using System.Linq;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = CountVowels("Hellow WOrld");
            Console.WriteLine(result);
        }

        public static int CountVowels(string aText)
        {
            var count = 0;
            for (var i = 0; i < aText.Length; i++)
            {
                if (
                    (aText[i].ToString().Equals("a", StringComparison.InvariantCultureIgnoreCase)) ||
                    (aText[i].ToString().Equals("e", StringComparison.InvariantCultureIgnoreCase)) ||
                    (aText[i].ToString().Equals("i", StringComparison.InvariantCultureIgnoreCase)) ||
                    (aText[i].ToString().Equals("o", StringComparison.InvariantCultureIgnoreCase)) ||
                    (aText[i].ToString().Equals("u", StringComparison.InvariantCultureIgnoreCase))

                    )
                {
                    count++;
                }

            }
            //if (aText.Contains("a",StringComparison.OrdinalIgnoreCase)) { count++; }
            //if (aText.Contains("e", StringComparison.OrdinalIgnoreCase)) { count++; }
            //if (aText.Contains("i", StringComparison.OrdinalIgnoreCase)) { count++; }
            //if (aText.Contains("o", StringComparison.OrdinalIgnoreCase)) { count++; }
            //if (aText.Contains("u", StringComparison.OrdinalIgnoreCase)) { count++; }
            return count;
        }
    }
}
