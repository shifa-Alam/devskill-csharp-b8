using System;

namespace DataTypeIO
{
    class Program
    {
        static void Main(string[] args)
        {
            IOIntegerArray();
            IODoubleArray();
            IOFloatArray();
            IOStringArray();
            IODateTimeArray();
            IODecimalArray();
            IOLongArray();
            IOBooleanArray();

        }

        private static void IOBooleanArray()
        {
            bool[] arrayValue = new bool[5];
            Console.WriteLine("Enter 5 Boolean : ");
            for (var i = 0; i < 5; i++)
            {
                arrayValue[i] = Convert.ToBoolean(Console.ReadLine());
            }
            Console.WriteLine("Your Boolean's are : ");
            for (var i = 0; i < arrayValue.Length; i++)
            {
                Console.WriteLine(arrayValue[i]);
            }
            PrintUnderLine();
        }

        private static void IOLongArray()
        {
            long[] arrayValue = new long[5];
            Console.WriteLine("Enter 5 Long number : ");
            for (var i = 0; i < 5; i++)
            {
                arrayValue[i] = Convert.ToInt64(Console.ReadLine());
            }
            Console.WriteLine("Your Long number's are : ");
            for (var i = 0; i < arrayValue.Length; i++)
            {
                Console.WriteLine(arrayValue[i]);
            }
            PrintUnderLine();
        }

        private static void IODecimalArray()
        {
            decimal[] arrayValue = new decimal[5];
            Console.WriteLine("Enter 5 decimal number : ");
            for (var i = 0; i < 5; i++)
            {
                arrayValue[i] = Convert.ToDecimal(Console.ReadLine());
            }
            Console.WriteLine("Your decimal number's are : ");
            for (var i = 0; i < arrayValue.Length; i++)
            {
                Console.WriteLine(arrayValue[i]);
            }
            PrintUnderLine();
        }

        private static void IODateTimeArray()
        {
            DateTime[] arrayValue = new DateTime[5];
            Console.WriteLine("Enter 5 date (m-d-y) : ");
            for (var i = 0; i < 5; i++)
            {
                arrayValue[i] = DateTime.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your date's are : ");
            for (var i = 0; i < arrayValue.Length; i++)
            {
                Console.WriteLine(arrayValue[i]);
            }
            PrintUnderLine();
        }

        private static void IOStringArray()
        {
            string[] arrayValue = new string[5];
            Console.WriteLine("Enter 5 String : ");
            for (var i = 0; i < 5; i++)
            {
                arrayValue[i] = Console.ReadLine();
            }
            Console.WriteLine("Your Strings are : ");
            for (var i = 0; i < arrayValue.Length; i++)
            {
                Console.WriteLine(arrayValue[i]);
            }
            PrintUnderLine();
        }

        private static void IOFloatArray()
        {
            float[] arrayValue = new float[5];
            Console.WriteLine("Enter 5 Float Value : ");
            for (var i = 0; i < 5; i++)
            {
                arrayValue[i] = Single.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your Float values are : ");
            for (var i = 0; i < arrayValue.Length; i++)
            {
                Console.WriteLine(arrayValue[i]);
            }
            PrintUnderLine();
        }

        private static void IODoubleArray()
        {
            double[] arrayValue = new double[5];
            Console.WriteLine("Enter 5 Double Value : ");
            for (var i = 0; i < 5; i++)
            {
                arrayValue[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Your Double values are : ");
            for (var i = 0; i < arrayValue.Length; i++)
            {
                Console.WriteLine(arrayValue[i]);
            }
            PrintUnderLine();
        }

        private static void IOIntegerArray()
        {
            int[] arrayValue = new int[5];
           
            Console.WriteLine("Enter 5 integer Value : ");
            for (var i = 0; i < 5; i++)
            {
                arrayValue[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your Integer values are : ");
            for (var i = 0; i < arrayValue.Length; i++)
            {
                Console.WriteLine(arrayValue[i]);
            }
            PrintUnderLine();
        }

        private static void PrintUnderLine()
        {
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");
        }
    }
}
