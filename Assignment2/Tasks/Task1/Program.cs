using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = IsPrime(27);
            Console.WriteLine(result);
        }

        public static bool IsPrime(int number)
        {
            if (number == 2)
            {
                return true;
            }
            else if (number > 2)
            {
                if (number % 2 == 0) return false;
                var count = 0;
                for (var i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                        break;
                    }

                }
                return (count > 0) ? false : true;
            }

            return false;

        }
    }
}
