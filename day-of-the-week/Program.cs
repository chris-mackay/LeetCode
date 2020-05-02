using System;

namespace day_of_the_week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayOftheWeek(31, 8, 2019));
        }

        public static string DayOftheWeek(int day, int month, int year)
        {
            DateTime d = new DateTime(year, month, day);
            return d.DayOfWeek.ToString();
        }
    }
}
