using System;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = BinaryToDecimal("11110101010101010101011");
            Console.WriteLine(result);
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            var decimalNumber = 0;
            for (var i = 0; i < binaryNumber.Length; i++)
            {
                var mainNumber = int.Parse(binaryNumber[i].ToString());
                var power = binaryNumber.Length - (i+1);
                var powvalue = ((int)Math.Pow(2, power));
               
             
                decimalNumber += mainNumber * powvalue;
            }
            return decimalNumber;
        }
    }
}
