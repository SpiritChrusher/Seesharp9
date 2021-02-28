using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp9
{
    class Maturity
    {
       public static bool IsValidPercentage(object x) => x is
    >= 0 and <= 100 or    // integer tests
    >= 0F and <= 100F or  // float tests
    >= 0D and <= 100D;

        public static long Parsenumber()
        {
            string t = Console.ReadLine();
            bool success = long.TryParse(t, out long result);

            if (success)
            {
                Console.WriteLine("siker");
                return result;
            }
            else
            {
                Console.WriteLine("Hiba, nem számot írtál be!");
                return Parsenumber();
            }
        }
    }
}
