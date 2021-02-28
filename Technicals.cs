using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp9
{
    public interface ITechnical
    {
        public void GetManuals(string s);
        public string Moredetails()
        {
            return "more suff from interface";
        }
    }

    public abstract class Basetechnician
    {
        protected Basetechnician(int id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        int Id { get; init; }
        string Name { get; init; }

        public abstract void Work();
        public void DoStuff()
        {
            Console.WriteLine("I'm doing some things.");
        }
        public virtual string Greetings(string s)
        {
            return $"{s} is done in the abstract class!";
        }
    }

    public class Technicals : ITechnical
    {
        public void GetManuals(string s)
        {
            Console.WriteLine("{0} is from the class", s);
        }
    }

    public class Moretechnical : Basetechnician ,ITechnical
    {
        ITechnical technician { get; init; }
        public Moretechnical(int id, string name) : base(id, name)
        {
        }
        public void GetManuals(string s)
        {
        
        }
        public string Moredeatails()
        {
            return "more stuff from the class";
        }

        public override void Work()
        {
            Console.WriteLine("I'm doing my work");
        }
        public override string Greetings(string s)
        {
            return $"{s} is done in the normal class!";
        }
    }
}
