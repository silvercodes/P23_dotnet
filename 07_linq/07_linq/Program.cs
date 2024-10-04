
// === SOURCES
// collections      LINQ to objects
// XML              LINQ to XML
// DB               LINQ to DataSet
//                  Parallele LINQ 

using _07_linq;
using System.Collections;

string[] planets = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter" };
string[] planets2 = new string[] { "Mercury", "Venus", "Jupiter", "Neptun", "Pluton" };

int[] nums = { 2, 6, 9, -1, 4, -5, 8, 3, 0, -8 };

List<User> users = new List<User>()
{
    new User(98, "Vasia") { Roles = new List<string>() { "guest" } },
    new User(101, "Vasia") { Roles = new List<string>() { "admin" } },
    new User(121, "Vasia") { Roles = new List<string>() { "admin", "superAdmin" } },
    new User(1561, "Alexandr") { Roles = new List<string>() { "guest" } },
    new User(809, "Dima") { Roles = new List<string>() { "guest", "author" } },
    new User(2, "Petya") { Roles = new List<string>() { "guest", "author" } },
};

#region Extension methods
//string str = "Vasia";
//Console.WriteLine(str.CharCount('a'));

//public static class StringExtension
//{
//    public static int CharCount(this string s, char ch)
//    {
//        int count = 0;
//        for (int i = 0; i < s.Length; i++)
//        {
//            if (s[i] == ch)
//                count++;
//        }

//        return count;
//    }
//}
#endregion

#region Intro

// --- в лоб
//List<string> selected = new List<string>();
//foreach(string planet in planets)
//    if (planet.Length <= 5)
//        selected.Add(planet);
//selected.Sort();
//foreach (string planet in selected)
//    Console.WriteLine(planet);

// --- LINQ expression
//var selected = from p in planets
//               where p.Length <= 5
//               orderby p
//               select p;
//foreach (string planet in selected)
//    Console.WriteLine(planet);

// --- LINQ extension methods
//IEnumerable<string> selected = planets
//    .Where(p => p.Length <= 5)
//    .OrderBy(p => p);
//foreach (string planet in selected)
//    Console.WriteLine(planet);

#endregion

#region Возможности синтаксиса
// --- переменные
//var result = from p in planets
//             let fullTitle = $"planet {p}"
//             select fullTitle;
//Render(result);

// --- проекция (маппинг, отображение)
// var result = from u in users
//             select u.Name;

// var result = users.Select(u => u.Name);

//var result = from u in users
//             select new
//             {
//                 UserId = u.Id,
//                 UserName = u.Name,
//             };

//var result = users.Select(u => new
//{
//    UserId = u.Id,
//    UserName = u.Name,
//});

//Render(result);
#endregion

#region Выборка из нескольких источников
//var result = from p1 in planets
//             from p2 in planets2
//             select p2;

//var result = from p1 in planets
//             from p2 in planets2
//             select new
//             {
//                 a = p1,
//                 b = p2,
//             };

//Render(result);
#endregion

#region Выборка из сложных объектов
//var result = from u in users
//             from r in u.Roles
//             select r;
// equals cycle:
//foreach (User u in users)
//{
//    foreach(string r in u.Roles)
//    {
//        //
//    }
//}

// var result = users.SelectMany(u => u.Roles);

//var result = from u in users
//             from r in u.Roles
//             select new 
//             { 
//                 Name = u.Name,
//                 Role = r
//             };

//var result = users.SelectMany(
//    u => u.Roles, 
//    (u, r) => new
//        {
//            Name = u.Name,
//            Role = r
//        }
//);

//Render(result);
#endregion

#region Фильтрация
//var result = from n in nums
//             where n % 2 == 0 && n > 0
//             select n;

// var result = nums.Where(n => n % 2 == 0 && n > 0);

//var result = from u in users
//             where u.Id > 100
//             select new
//             {
//                 UserName = u.Name,
//             };

//var result = users
//    .Where(u => u.Id > 100)
//    .Select(u => new 
//    { 
//        UserName = u.Name 
//    });

//var result = from u in users
//             from r in u.Roles
//             where u.Id > 100
//             where r == "admin"
//             select u;

//var result = users
//    .SelectMany(
//        u => u.Roles,
//        (u, r) => new
//            {
//                User = u,
//                Role = r,
//            }
//        )
//    .Where(o => o.User.Id > 100 && o.Role == "admin")
//    .Select(o => o.User);

//Render(result);
#endregion

#region Сортировка
//var result = from n in nums
//             orderby n
//             select n;

// var result = nums.OrderBy<int, int>(n => n);

// var result = nums.OrderBy(n => n);

//var result = from u in users
//             orderby u.Id
//             select u;

// var result = users.OrderBy(u => u.Id);

//var result = from n in nums
//             orderby n descending
//             select n;

//var result = nums.OrderByDescending(n => n);

//var result = from u in users
//             orderby u.Name, u.Id descending
//             select u;

//var result = users
//    .OrderBy(u => u.Name)
//    .ThenByDescending(u => u.Id);

//var result = users.OrderBy(u => u, new UserComparer());

//Render(result);
#endregion



void Render<T>(IEnumerable<T> arr)
{
    foreach (var item in arr)
        Console.WriteLine(item);
}
