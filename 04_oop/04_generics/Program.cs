

#region Generic classes

//User a = new User() { Id = 101, Email = "vasia@mail.com" };
//User b = new User() { Id = "ow894roo", Email = "petya@mail.com" };


//if (a.Id is not null)
//{
//    int aId = (int)a.Id;
//}

//if (b.Id is not null && b.Id is string)
//{
//    string bId = (string)b.Id;
//}

//class User
//{
//    public object? Id { get; set; }
//    public string? Email { get; set; } = null;
//}





// === static ===
//User<int> a = new User<int>() { Id = 12, Email = "vasia@mail.com" };
//User<string> b = new User<string>() { Id = "102", Email = "petya@mail.com" };

//User<int>.maxId = 100;
//User<double>.maxId = 1.0;
//User<string>.maxId = "first";

//class User<T>
//{
//    public static T maxId;
//    public T Id { get; set; }
//    public string Email { get; set; }
//}




// ==== generic in other generic


// User<int, string> a = new User<int, string>();


//User<int, Role<string>> a = new User<int, Role<string>>(101, "vasia@mail.com")
//{
//    Role = new Role<string>()
//    {
//        Id = "1",
//        Title = "admin",

//    }
//};


//class Role<T>
//{
//    public T Id { get; set; }
//    public string Title { get; set; }
//}
//class User<K, T>
//{
//    public K Id { get; set; }
//    public string? Email { get; set; }
//    public required T Role { get; set; }
//    public User(K id, string email)
//    {
//        Id = id;
//        Email = email;
//    }
//}

#endregion


#region Generic methods


//Logger logger = new Logger();

//Logger.Analyze<int>(32);
//Logger.Analyze<Entry>(new Entry() { Data = "JSON data" });

//class Entry
//{
//    public string Data { get; set; }
//    public override string ToString()
//    {
//        return $"Data: {Data}";
//    }
//}
//class Logger
//{
//    //
//    //

//    public static void Analyze<T>(T val)
//    {
//        Console.WriteLine(val);
//    }
//}


#endregion


#region Task
// Написать обобщенный класс Container
// Функционал:
//  Хранить значения в массиве
// Методы:
//  добавление
//  удаление
//  получение по индексу
//  Render()
// Свойства:
//  Длина хранилища

class Container<T>
{
    private T[] arr;
}








#endregion


