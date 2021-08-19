using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = ConvertTime("12:30 pm");
            Console.WriteLine(result);
        }

        public static string ConvertTime(string twelveHourFormat)
        {
            if (twelveHourFormat.Contains("am"))
            {
                twelveHourFormat = twelveHourFormat.Replace("am", "");

                var m = twelveHourFormat.Split(":");
                var x = Convert.ToInt32(m[0]);
                var n = 0;
                if (x == 12)
                {
                    n = x - 12;
                    twelveHourFormat = twelveHourFormat.Replace(x.ToString(), n.ToString());
                }


            }
            else if (twelveHourFormat.Contains("pm"))
            {
                twelveHourFormat = twelveHourFormat.Replace("pm", "");
                var m = twelveHourFormat.Split(":");
                var x = Convert.ToInt32(m[0]);
                var n = 0;
                if (x < 12)
                {
                    n = x + 12;
                    twelveHourFormat = twelveHourFormat.Replace(x.ToString(), n.ToString());
                }

            }
            else
            {
                twelveHourFormat = twelveHourFormat.Replace("pm", "");
                twelveHourFormat = twelveHourFormat.Replace("am", "");
            }

            return twelveHourFormat.Trim();
        }
    }
}
