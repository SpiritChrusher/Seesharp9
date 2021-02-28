using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp9
{

    
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public string Wageband { get; set; }

        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
           // Wageband = wageband;
        }

        public double sinc(double x) => x != 0.0 || x != 1 ? Math.Sin(x) / x : 1;

        public override string ToString()
        {
            return $"{Name}'s id: ({Id})\nSalary: {Salary} and wageband: {Wageband}";
        }

        public static string Createname()
        {
            Random rand = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder myname = new StringBuilder();
            int length = rand.Next(4, 10);
            for (int i = 0; i < length; i++)
            {
                myname.Append(chars[rand.Next(0, chars.Length)]);
            }
            

            return myname.ToString();
        }

        public static int CreateSalary()
        {
            Random r = new Random();
            int salary = r.Next(500, 3001);

            return salary;
        }
    }
    public sealed class Demo
    {
        public int A { get; set; }
        public string B { get; set; }

        public Demo(int a, string b)
        {
            A = a;
            B = b;
        }
    }

    public record Rep(string Partyname, int Votercounts);

    #region Beer
    public record Beer(string Name, decimal Quality)
    {
        public override string ToString() => $"Name: {Name} and quality: {Quality}";
    }
    #endregion
    #region Craftbeer
    public record CraftBeer(string Name, decimal Quality, string Type, decimal Alcohol) :
        Beer(Name, Quality)
    {
        public void Drink() => Console.WriteLine($"{Name} has been drunk!");
    }
    #endregion

    #region Person region class
    public record Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age) { Name = name; Age = age; }

        public Person() { }

        public int GetOlder() { return Age += 1; }

        public virtual void WhatAmI()
        {
            Console.WriteLine("Hello there!");
        }
    }
    #endregion
    #region Elector
    public record Elector : Person
    {
        public int Salary { get; set; }
        public string Vote { get; set; }
        public Elector(string name, int age, int salary, string vote) :
            base(name, age)
        { Salary = salary; Vote = vote; }

        public void Raise() => Console.WriteLine("Yeyy, I got a raise!");

        public static void Swallowcopier(out Elector voter, ref Elector input)
        {
            //fejlesztés alatt
            voter = new Elector(input.Name, input.Age, input.Salary, input.Vote);
        }

        public static void DeepCopiyer(out Elector voter, ref Elector input)
        {
            voter = new Elector(input.Name, input.Age, input.Salary, input.Vote);
        }

        public override void WhatAmI()
        {
            base.WhatAmI();
        }
    }
    #endregion
    public class Mammal
    {
        public int Limbs { get; set; }
        public string Name { get; set; }

        public Mammal(int limbs, string name)
        {
            Limbs = limbs;
            Name = name;
        }

        public Mammal Wew()
        {
            return (Mammal)this.MemberwiseClone();
            //return (Mammal)this;
        }

        public Mammal DeepWew()
        {
            Mammal postnatal = new Mammal(Limbs, Name);
            return postnatal;
        }
    }
    public class Human
    {
        public int Age { get; set; }
        public string Country { get; set; }

        public Mammal Infos { get; set; }

        public Human(int age, string country, int limbs, string name)
        {
            Age = age;
            Country = country;
            Infos = new Mammal(limbs, name);
        }
        public Human Shallowcopy()
        {
            return (Human)this.MemberwiseClone();
        }
        public Human Deepcopy()
        {
            Human newborn = new Human(Age, Country, Infos.Limbs, Infos.Name);
            return newborn;
        }
    }
}
