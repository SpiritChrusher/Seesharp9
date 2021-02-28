using System;
using System.Collections.Generic;
using SeeSharp9;
using System.Linq;
using System.Diagnostics;
using System.Text.Json;

var td = new DateTime().DayOfWeek;
Debug.WriteLine("oina");
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

Uri url = new Uri("https://raw.githubusercontent.com/SpiritChrusher/FavoriteBeer/master/src/main/Allbeers.json", UriKind.Absolute);

    System.Net.WebClient client = new System.Net.WebClient();

    string jsonString = await client.DownloadStringTaskAsync(url);

List<Beers> TestedBeers = JsonSerializer.Deserialize<List<Beers>>(jsonString);

TestedBeers.Where(x => x.quality >= 8).OrderBy(x => x.name).ToList().ForEach(x => Console.WriteLine($"  {x.name}"));


long szamom = Maturity.Parsenumber();

var dt = new DateTime(1610, 03, 13);
Demo d1 = new(10, "Nevem");
Demo d2 = d1;
Console.WriteLine(d2 == d1);
changename(d1, "sew");
Console.WriteLine(d1 == d2);

Console.WriteLine($"{d1.B}, {d2.B}");
Console.WriteLine($"d1 A: {d1.A}");

changeobj(d1);
Console.WriteLine($"valtozott-e? {d1.B == "sew"}, {d1.B} és {d1.A}");
changeobjref(ref d1);
Console.WriteLine($"valtozott-e? {d1.B == "sew"}, {d1.B} és {d1.A}");

List<Employee> emplist = new List<Employee>();

for (int i = 0; i < 12; i++)
{
    emplist.Add(new(i + 1, Employee.Createname(), Employee.CreateSalary()));
}

foreach (var emp in emplist)
{
    emp.Wageband = emp.Salary switch
    {
        500 or 3000 => "You're the worst or best.",
        <= 800 => "Well below average",
        > 800 and < 1400 => "slightly below average",
        > 2300 => "Really good",
        _ => "average"
    };
    // Console.WriteLine(emp.ToString());
}

var salaryorder = from p in emplist orderby p.Salary descending where p.Name.Length > 4 select p.Salary; 
var bestsalary = emplist.AsParallel().OrderByDescending(x => x.Salary).Select(x => x.Salary).First();
var bysalary = emplist.Where(x => x.Salary > 800).GroupBy(x => x.Wageband, x => x.Salary,(basegroup, groups) =>
new { Key = basegroup, Count = groups.Count()}
).OrderBy(x => x.Key);
Console.WriteLine($"legjobb: {bestsalary}");
foreach (var item in salaryorder)
{
    Console.WriteLine($"fizetések: {item}");
}

foreach (var item in bysalary)
{
    Console.WriteLine("{0},  {1} db",item.Key, item.Count);
}


var byName = from emp in emplist where emp.Salary > 800 
             group new { emp.Name, emp.Salary, emp.Wageband} by emp.Name[0] into empgroup 
             select empgroup;

foreach (var item in byName)
{
    Console.WriteLine("{0} és {1} db",item.Key, item.Count());
    foreach (var item2 in item)
    {
        Console.WriteLine($"{item2.Name} : {item2.Salary} and has {item2.Wageband}");
    }
}


string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

// Create the query.
var wordGroups =
    from w in words
    group w by w[^1];

foreach (var wordGroup in wordGroups)
{
    Console.WriteLine("Words that start with the letter '{0}':  ({1} db)", wordGroup.Key, wordGroup.Count());
    foreach (var word in wordGroup)
    {
        Console.WriteLine(word);
    }
}



List<int> values = new List<int> { 0, -1, -256, 10, 49, 50, 51, 54, 55, 56, 59, 60, 61, 100};
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

Console.WriteLine(Maturity.IsValidPercentage(10));

void changename(Demo d, string s)
{
    d.B = s;
}
void changeobj(Demo d)
{
    d.B = "kris";
    d.A = 104;
    Console.WriteLine($"Metodusban a neve: {d.B}");
    Console.WriteLine(d.B == "sew");
    var g = new Demo(42, "sanyi");
   // g = new Demo(230, "sanyi");
    d = g;
    Console.WriteLine($"sanyi-e? {d.B == "sanyi"}"); //true
    Console.WriteLine($"sew-e? {d.B == "sew"}"); //false
    d.B = "pista";
    Console.WriteLine($"uzoljara: {d.B}");
    Console.WriteLine("vege");
}
void changeobjref(ref Demo d)
{
    d.B = "kris";
    Console.WriteLine($"Metodusban a neve: {d.B}");
    Console.WriteLine(d.B == "sew");
    var g = new Demo(42, "sanyi");
    // g = new Demo(230, "sanyi");
    d = g;
    Console.WriteLine($"sanyi-e? {d.B == "sanyi"}"); //true
    Console.WriteLine($"sew-e? {d.B == "sew"}"); //false
    d.B = "pista";
    Console.WriteLine($"uzoljara: {d.B}");
    Console.WriteLine("vege");
}

bool iseven(int a)
{
    return a % 2 == 0;
}


