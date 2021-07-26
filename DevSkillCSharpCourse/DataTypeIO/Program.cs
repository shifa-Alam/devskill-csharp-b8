using System;

namespace DataTypeIO
{
    class Program
    {
        static void Main(string[] args)
        {


            //IOArray("Enter 5 integer Value : ", typeof(int), "Your Integer values are : ");
            //IOArray("Enter 5 Double Value : ", typeof(double), "Your Double values are : ");
            //IOArray("Enter 5 Float Value : ", typeof(float), "Your Float values are : ");
            //IOArray("Enter 5 String Value : ", typeof(string), "Your String values are : ");
            //IOArray("Enter 5 DateTime Value : ", typeof(DateTime), "Your DateTime values are : ");
            //IOArray("Enter 5 Decimal Value : ", typeof(decimal), "Your Decimal values are : ");
            //IOArray("Enter 5 Long Value : ", typeof(long), "Your Long values are : ");
            //IOArray("Enter 5 Boolean Value : ", typeof(bool), "Your Boolean values are : ");

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

        //private static void IOArray(string inputMessage, Type dataType, string outputMessage)
        //{
        //    var arrayLength = 5;
            
        //    if (dataType == typeof(int))
        //    {
        //        int[] arrayValue = new int[arrayLength];
        //        Console.WriteLine(inputMessage);
        //        for (var i = 0; i < 5; i++)
        //        {
        //            arrayValue[i] = Convert.ToInt32(Console.ReadLine());
        //        }
        //        PrintValue<int>(outputMessage, arrayValue);

        //    }
        //    else if (dataType == typeof(double))
        //    {
        //        double[] arrayValue = new double[arrayLength];
        //        Console.WriteLine(inputMessage);
        //        for (var i = 0; i < 5; i++)
        //        {
        //            arrayValue[i] = Convert.ToDouble(Console.ReadLine());
        //        }
        //        PrintValue<double>(outputMessage, arrayValue);
        //    }
        //    else if (dataType == typeof(float))
        //    {

        //        float[] arrayValue = new float[arrayLength];
        //        Console.WriteLine(inputMessage);
        //        for (var i = 0; i < 5; i++)
        //        {
        //            arrayValue[i] = Single.Parse(Console.ReadLine());
        //        }
        //        PrintValue<float>(outputMessage, arrayValue);
        //    }
        //    else if (dataType == typeof(string))
        //    {
        //        string[] arrayValue = new string[arrayLength];
        //        Console.WriteLine(inputMessage);
        //        for (var i = 0; i < 5; i++)
        //        {
        //            arrayValue[i] = Console.ReadLine();
        //        }
        //        PrintValue<string>(outputMessage, arrayValue);
        //    }
        //    else if (dataType == typeof(DateTime))
        //    {
        //        DateTime[] arrayValue = new DateTime[arrayLength];
        //        Console.WriteLine(inputMessage);
        //        for (var i = 0; i < 5; i++)
        //        {
        //            arrayValue[i] = DateTime.Parse(Console.ReadLine());
        //        }
        //        PrintValue<DateTime>(outputMessage, arrayValue);
        //    }
        //    else if (dataType == typeof(decimal))
        //    {
        //        decimal[] arrayValue = new decimal[arrayLength];
        //        Console.WriteLine(inputMessage);
        //        for (var i = 0; i < 5; i++)
        //        {
        //            arrayValue[i] = Convert.ToDecimal(Console.ReadLine());
        //        }
        //        PrintValue<decimal>(outputMessage, arrayValue);
        //    }
        //    else if (dataType == typeof(long))
        //    {
        //        long[] arrayValue = new long[arrayLength];
        //        Console.WriteLine(inputMessage);
        //        for (var i = 0; i < 5; i++)
        //        {
        //            arrayValue[i] = Convert.ToInt64(Console.ReadLine());
        //        }
        //        PrintValue<long>(outputMessage, arrayValue);
        //    }
        //    else if (dataType == typeof(bool))
        //    {
        //        bool[] arrayValue = new bool[arrayLength];
        //        Console.WriteLine(inputMessage);
        //        for (var i = 0; i < 5; i++)
        //        {
        //            arrayValue[i] = Convert.ToBoolean(Console.ReadLine());
        //        }
        //        PrintValue<bool>(outputMessage, arrayValue);
        //    }


           
        //}

        //private static void PrintValue<T>(string outputMessage, T[] arrayValue)
        //{

        //    Console.WriteLine(outputMessage);
        //    for (var i = 0; i < arrayValue.Length; i++)
        //    {
        //        Console.WriteLine(arrayValue[i]);
        //    }
        //    PrintUnderLine();
        //}

        private static void PrintUnderLine()
        {
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");
        }
    }
}
