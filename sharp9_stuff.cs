using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp9
{
    class sharp9_stuff
    {
        public static void Switch_exp()
            {
            List<int> values = new List<int> { 0, -1, -256, 10, 49, 50, 51, 54, 55, 56, 59, 60, 61, 100 };
            foreach (var item in values)
            {

                var fine = item switch
                {
                    > 0 and <= 50 => "good",
                    > 50 and <= 55 => "warn",
                    > 55 and <= 60 => "fined",
                    > 60 => "suspended",
                    _ => "impossible"
                };
                Console.WriteLine($"{item} km/h => {fine}");
            }

            values ??= new List<int>() { 10, 41, 1, 53 };
            Console.WriteLine($"db: {values.Count}");
        }

        public static void Switch_func()
        {
            var td = new DateTime().DayOfWeek;

            Console.WriteLine(td.ToString());
            switch (td)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("SAjt.");
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("SAjt.");
                    break;
                default:
                    break;
            }
        }
    }
}
