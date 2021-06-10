using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp9
{
    public class Dictionary_ShallowDeep
    {

        public static void Show_ShallowDeep()
        {
            Dictionary<int, string> mydict = new() { { 1, "egy" }, { 2, "ketto" }, { 3, "harom" }, { 4, "negy" } };

            var dictquery = mydict.First().Value;

            Console.WriteLine(dictquery);

            Dictionary<int, List<string>> mydict2 = new()
            {
                { 1, new() { "egyegy", "egyketto" } },
                { 2, new() { "kettoegyegy", "kettoketto" } },
                { 3, new() { "haromegy", "haromketto" } },
                { 4, new() { "negyegy", "negyketto" } }
            };
            var mydict3 = mydict2.Reverse();
            var dicttwoquery = mydict3.First().Value;
            var dicttwoquery2 = mydict2.Where(x => x.Value.Contains("haromegy"));

            string dictstring = "negyegy";
            foreach (var item in dicttwoquery)
            {
                Console.WriteLine(item);
                if (dictstring == item)
                { Console.WriteLine($"egyenlő: {item}"); }
                if (dictstring.Equals(item))
                { Console.WriteLine($"equals: {item}"); }
            }

            Console.WriteLine("------------------");

            var firstquery = mydict2.Last().Value;
            List<string> secondlist = new();// { };


            firstquery.RemoveAt(1);
            firstquery.Add("sokadik");

            foreach (var item in firstquery)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("..............");
            int counter = 0;
            foreach (var item in mydict2)
            {
                Console.WriteLine(item.Key);
                counter++;
                foreach (var item2 in item.Value)
                {
                    if (counter == 1)
                    {
                        string a = item2;//new String(item2);
                        secondlist.Add(a);
                    }
                    Console.WriteLine(item2);
                }
            }

            secondlist.RemoveAt(1);
            secondlist.Add("elsoszo");

            Console.WriteLine(".,,,.,.,.,..,.,.,.,.,.");

            foreach (var item in secondlist)
            {
                Console.WriteLine($"seclist: {item}");
            }

            Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-..");

            foreach (var item in mydict2)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item.Value)
                    Console.WriteLine(item2);

            }
        }
    }
}
