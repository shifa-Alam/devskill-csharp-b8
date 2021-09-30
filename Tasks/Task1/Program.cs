using System;

namespace Task1
{
    public class Program
    {
        //public delegate string Converter(DateTime time);

        static void Main(string[] args)
        {
            //Func<DateTime, string> m;

            var result = Formatter((d) => $"%{d.Date.Day}%");
            Console.WriteLine(result);
        }

        public static string Formatter(Func<DateTime, string> m)
        {
            return m(DateTime.Now);
        }
    }
}
