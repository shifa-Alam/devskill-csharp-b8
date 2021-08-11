using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var result = LargeSubtraction("987654321987654321987654321", "123456789123456789123456789");
            //Console.WriteLine(result);
            var result = LargeSubtraction("98765432198509285902023894023028743983282480924589024024802840272835209328741396349823087654321987654321", "123456789130929048732590435894308490450985039823456789123456789");
            Console.WriteLine(result);
        }

        public static string LargeSubtraction(string a, string b)
        {
            a = a.Trim();
            b = b.Trim();

            b = (a.Length > b.Length) ? ApplyUpdatebBl(a, b) : b;

            return SubTractResult(a, b);


        }

        private static string SubTractResult(string a, string b)
        {
            var result = string.Empty;
            var borrower = 0;
            for (var i = a.Length - 1; i >= 0; i--)
            {
                var val = 0;
                var firstNumber = int.Parse(a[i].ToString());
                var secondNumber = int.Parse(b[i].ToString()) + borrower;

                if (firstNumber > secondNumber)
                {
                    val = firstNumber - secondNumber;
                    result = val.ToString() + result;
                    borrower = 0;
                }
                else if (firstNumber < secondNumber)
                {
                    val = firstNumber + 10 - secondNumber;
                    result = val.ToString() + result;
                    borrower = 1;
                }
                else
                {
                    result = val.ToString() + result;
                    borrower = 0;
                }
            }

            return result;
        }

        private static string ApplyUpdatebBl(string a, string b)
        {
            var diff = a.Length - b.Length;

            for (var i = 0; i < diff; i++)
            {
                b = "0" + b;
            }
            return b;
        }
    }
}
