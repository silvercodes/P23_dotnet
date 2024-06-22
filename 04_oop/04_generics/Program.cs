

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

//class Container<T>
//{
//    private T[] arr;
//}

#endregion


#region Generics methods constraints

////Archer a = new Archer(100);
////Renderer.Render<Unit>(a);
////Renderer.Render<Archer>(a);



//Archer a = new Archer(100);
//// Renderer.Render<int>(120);           // ERROR
//Renderer.Render(a);

//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp) => Hp = hp;
//}

//class Warrior : Unit
//{
//    public Warrior(int hp) 
//        : base(hp)
//    {}
//}

//class Archer : Unit
//{
//    public Archer(int hp)
//        : base(hp)
//    { }
//}


//// ==== via downcasting                 :-|
////class Renderer
////{
////    public static void Render<T>(T obj)
////    {
////        if (obj is Unit u)
////            Console.WriteLine($"Renderer: {u.Hp}");
////    }
////}


//// ==== via constraints                 :-)))
//class Renderer
//{
//    public static void Render<T>(T obj)
//        where T: Unit
//    {
//        Console.WriteLine($"Renderer: {obj.Hp}");
//    }
//}

#endregion


#region Genrics classes constraints

//Renderer<Unit>.Render(new Warrior(120));
//// Renderer<int>.Render(120);                  // ERROR

//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp) => Hp = hp;
//}

//class Warrior : Unit
//{
//    public Warrior(int hp)
//        : base(hp)
//    { }
//}

//class Archer : Unit
//{
//    public Archer(int hp)
//        : base(hp)
//    { }
//}


//class Renderer<T>
//    where T: Unit
//{
//    public static void Render(T obj)
//    {
//        Console.WriteLine($"Renderer: {obj.Hp}");
//    }
//}


#endregion


#region Generics constraints types

// where T: c1, c2, c3

// -- c1: --
// Конкретный класс
//      или
// class
//      или
// struct

// -- с2: --
// Конкретные интерфейсы

// -- с3: --
// new()            // Тип T должен иметь публичный конструктор по-умолчанию


//class Document
//{
//    public int Id { get; set; }
//    public Document(int id)
//    {
//        Id = id;
//    }
//}

//class Logger<T>
//    // where T: Document
//    // where T: class
//    // where T: struct
//    // where T: class, new()
//    where T: new()
//{
//    void Execute()
//    {
//        T obj = new T();
//    }
//}

//class Compressor<T, K>
//    where T: class
//    where K: Logger<int>
//{

//}

#endregion


#region Inheritance

class Identity
{
    public Identity()
    { }
}
class Unit<T>
    where T: new()
{
    public T Id { get; set; }
    public Unit(T id)
    {
        Id = id;
    }
}

// --- 1. Обобщенный наследник с тем же типом

//class Archer<K> : Unit<K>
//    where K : new()
//{
//    public Archer(K id) 
//        : base(id)
//    {}
//}

// Unit<int> a = new Unit<int>(101);
// Archer<int> b = new Archer<int>(102);
// Unit<int> c = new Archer<int>(103);


// --- 2. Обычный (необобщённый) наследник

//class Warrior : Unit<Identity>
//{
//    public Warrior(Identity id) 
//        : base(id)
//    {}
//}

//Warrior a = new Warrior(new Identity());
//Unit<int> b = new Unit<int>(101);


// --- 3. Обобщённый наследник с собственным типом
//class Archer<T> : Unit<int>
//{
//    public T? Value { get; set; }
//    public Archer(int id) 
//        : base(id)
//    {}
//}

//Archer<string> a = new Archer<string>(140);


// --- 4. Сочетание предыдущих вариантов

//class Archer<T, K>: Unit<K>
//    where K: new()
//{
//    public T? Value { get; set; }
//    public Archer(K id) 
//        : base(id)
//    {}
//}

//Archer<int, Identity> a = new Archer<int, Identity>(new Identity());

#endregion
