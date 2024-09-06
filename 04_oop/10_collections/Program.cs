
#region List<T>

//List<int> a = new List<int>();

//List<int> b = new List<int>() { 3, 4, 5, 6 };

//List<string> planets = new List<string>()
//{
//    "Mercury",
//    "Venus",
//    "Earth",
//    "Mars",
//};

//List<string> planets2 = new List<string>(planets)
//{
//    "Jupiter",
//};

//foreach (string planet in planets2)
//    Console.WriteLine(planet);

//planets2.ForEach(p => Console.WriteLine($"Planet: {p}"));

//Console.WriteLine(planets.Count);

//Console.WriteLine(planets[2]);


//// -- insert --
//planets2.Add("Saturn");
//planets2.AddRange(planets);
//planets2.Insert(1, "Moon");
//planets2.InsertRange(2, planets);


//// -- delete --
//planets2.Remove("Earth");
//planets2.RemoveAt(2);
//planets2.RemoveRange(3, 3);
//planets2.RemoveAll(p => p.StartsWith('M'));


// -- finding / exists ... --

//List<string> planets = new List<string>()
//{
//    "Mercury",
//    "Venus",
//    "Earth",
//    "Mars",
//};

//Console.WriteLine(planets.Contains("Earth"));

//Console.WriteLine(planets.Exists(p => p.StartsWith("X")));

//Console.WriteLine(planets.Find(p => p.StartsWith("M")));

//List<string> result = planets.FindAll(p => p.StartsWith("M"));
//// result.ForEach(p => Console.WriteLine(p));
//result.ForEach(Console.WriteLine);

//planets.GetRange(1, 2).ForEach(Console.WriteLine);

//planets
//    .GetRange(planets.FindIndex(p => p.StartsWith("V")), 2)
//    .ForEach(Console.WriteLine);

//planets.FindIndex(Check);
//bool Check(string p)
//{
//    //
//    //
//    return p.StartsWith("M");
//}


// ------ lambda example ------







//using System.Diagnostics;

//void Process(Action<string> action, string str)
//{
//    action.Invoke(str);
//}
//void ShowBlue(string str)
//{
//    Console.ForegroundColor = ConsoleColor.Blue;
//    Console.WriteLine(str);
//    Console.ResetColor();
//}

//Process(s => Console.WriteLine(s), "Dima");

//Process(ShowBlue, "Petya");

//Process(str =>
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(str);
//    Console.ResetColor();
//}, "VASIA");

//Process(Renderer.Render, "Kolia");

//Process(Console.WriteLine, "Victor");

//// Process(Debug.WriteLine, "HOHOHOHOHOHOHOHOHOHO");            // ERROR

//// Debug.WriteLine("ononononononononon");
//// Console.ReadLine();

//class Renderer
//{
//    public static void Render(string str)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine(str);
//        Console.ResetColor();
//    }
//}





// ----- extra -----

//List<Unit> units = new()
//{
//    new Unit(101, 200),
//    new Unit(103, 400),
//    new Unit(105, 700),
//};

////units.ForEach(Console.WriteLine);

////units.Reverse();

////units.ForEach(Console.WriteLine);

//Unit? res = units.Find(u => u.Id == 103);
//Console.WriteLine(res);

//class Unit
//{
//    public int Id { get; set; }
//    public int Hp { get; set; }
//    public Unit(int id, int hp)
//    {
//        Id = id;
//        Hp = hp;
//    }
//    public override string ToString()
//    {
//        return $"id: {Id}, hp: {Hp}";
//    }
//}

#endregion


#region LinkedList<T>

//List<string> list = new List<string>()
//{
//    "Mercury",
//    "Venus",
//    "Earth",
//    "Mars",
//};

//LinkedList<string> planets = new LinkedList<string>(list);

//Console.WriteLine(planets.Count);
//Console.WriteLine(planets.First?.Value);

//planets.AddAfter(planets.First, "Jupiter");

//foreach (var item in planets)
//    Console.WriteLine(item);


#endregion


