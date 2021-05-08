using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp9
{
    public class Higher_stuff
    {
        Func<int> getOne = () => 1;
        Func<int, int> addOne = (a) => a + 1;
        Func<int, int> addOneAndPrint = (a) =>
        {
            var returnValue = a + 1;
            Console.WriteLine(returnValue);
            return returnValue;
        };

        public int num { get; init; }
        public int num2 { get; init; }
        public int addedNumber { get; init; }

        public Higher_stuff()
        {
            this.num = getOne();
            this.num2 = addOne(3);
            this.addedNumber = addOneAndPrint(6);
        }

        private delegate int IntegerCalculation(int a, int b);

        public static void Calculate()
        {
            IntegerCalculation adder = delegate (int a, int b) { return a + b; };
            IntegerCalculation adder2 = (int a, int b) => a + b;
            Console.WriteLine("Thre adder result: " + adder(2, 4)); //Will return 6
            Console.WriteLine("Thre adder2 result: " + adder2(5, 4));
        }

        public delegate void TestDelegate(string s);
        public static void M(string s)
        {
            Console.WriteLine(s);
        }



    }
}
