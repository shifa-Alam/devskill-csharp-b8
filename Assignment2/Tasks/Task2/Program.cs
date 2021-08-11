using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = StringValue("Hello World");
            Console.WriteLine(result);
        }

        public static int StringValue(string aText)
        {
            var sum = 0;
            foreach(var text in aText)
            {
                sum += (int)text;
            }
            
            return sum;
        }
    }
}
