
#region Intro

//interface IRenderable { }
//interface IMovable { }
//interface ILoggable { }
//interface ILogger { }
//interface IShape { }


// Интерфейс может содержать
// 1. Методы
// 2. Свойства
// 3. События
// 4. Индексаторы
// 5. Статика (константы)       // from C#8


//internal interface ILogger
//{
//    // private int val;                 // ERROR
//    public const double PI = 3.1415;
//    public static int count = 0;
//    public void Log(string message);
//    public string Path { get; set; }

//}




// Shape a = new Shape();
// a.Render();                 // ERROR

//IRenderable b = new Shape();
//b.Render();


//interface IRenderable
//{
//    private static int count = 0;
//    private const double PI = 3.14;
//    private void Info()
//    {
//        Console.WriteLine("private Info()");
//    }

//    public void Render()
//    {
//        Console.WriteLine("Render");
//        Console.WriteLine(count);
//        Info();
//    }

//    public int Ratio { get => 0; }
//    public double Factor => PI;
//    public int Count
//    {
//        get => IRenderable.count;
//        set => IRenderable.count = value < 0 ? 0 : value;
//    }
//}

//class Shape: IRenderable
//{

//}

#endregion


#region Practice

//Unit a = new Unit();
//a.Render();

//IRenderable b = new Unit();
//b.Render();


//IRenderable c = new Mesh();
//c.WriteLogs();

//IRenderable d = new Unit();
//d.WriteLogs();

//Mesh e = new Mesh();
//// e.WriteLogs();                   ERROR


//interface IRenderable
//{
//    public void Render();
//    public void WriteLogs()
//    {
//        Console.WriteLine("IRenderable.WriteLogs()");
//    }
//}

//class Unit : IRenderable
//{
//    public void Render()
//    {
//        Console.WriteLine("Unit.Render()");
//    }

//    public void WriteLogs()
//    {
//        Console.WriteLine("Unit.WriteLogs()");
//    }
//}

//class Mesh : IRenderable
//{
//    public void Render()
//    {
//        Console.WriteLine("Mesh.Render()o");
//    }
//}

#endregion


#region Multiple implementation

//Db db = new Db();

//IWritable a = new Db();
//a.Write();
//IComparable b = new Db();
//b.Compare(a);

//if (db is IWritable iw)
//    iw.Write();


//interface IWritable
//{
//    public void Write();
//}

//interface IComparable
//{
//    public bool Compare(object? obj);
//}

//class Db : IWritable, IComparable
//{
//    public bool Compare(object? obj)
//    {
//        return true;
//    }

//    public void Write()
//    {
//        Console.WriteLine("Write to db...");
//    }
//    public void Save()
//    {
//        Console.WriteLine("Db.Save()");
//    }
//}

#endregion


#region Explicit realization (явная реализация)

// неявная (классическая)
//  когда методы интерфейса не конфликтуют
//  может быть переопределена в классах-наследниках

// явная
//  когда есть явные конфликты и неоднозначности в именах / сигнатурах
//  НЕ может быть переопределена в классах-наследниках



// Db db = new Db();
// db.Write();             // ERROR


//IWritable a = new Db();
//a.Write();

//IWritable b = new FileManager();
//b.Write();
//FileManager c = new FileManager();
//c.Write();

//IWritable d = new Db();
//d.Write();
//ISaver e = new Db();
//e.Write();



//Db db = new Db();

//((IWritable)db).Write();        // :-(

//if (db is IWritable wdb)        // :-)
//    wdb.Write();

//IWritable w = db;               // :-)
//w.Write();


//interface IWritable
//{
//    public void Write();
//}

//interface ISaver
//{
//    public void Write();
//}

//class Db: IWritable, ISaver
//{
//    // 1. Явная реализация
//    // 2. Не является членом класса!!!
//    // 3. Нельзя сделать public
//    void IWritable.Write()
//    {
//        Console.WriteLine("Write from Db(IWritable)");
//    }

//    void ISaver.Write()
//    {
//        Console.WriteLine("Write from Db(ISaver)");
//    }

//    // === общая реализация (одна на все интерфесы)
//    public void Write()
//    {
//        Console.WriteLine("Common realization");
//    }
//}

//class FileManager : IWritable
//{
//    void IWritable.Write()
//    {
//        Console.WriteLine("Write from FileManager(IWritable)");
//    }

//    public void Write()
//    {
//        Console.WriteLine("Write from FileManager");
//    }
//}

#endregion


#region Access modificators

//IRenderable a = new Mesh();
//a.Show();                   // ERROR
//Mesh b = new Mesh();
//b.Show();

//interface IRenderable
//{
//    protected void Show();
//}

//class Mesh: IRenderable
//{
//    void IRenderable.Show()
//    {
//        Console.WriteLine("Mesh IRenderable.Show()");
//    }

//    public void Show()
//    {
//        Console.WriteLine("Mesh Show()");
//    }
//}



//IRenderable a = new Mesh();
//a.Show();
//Mesh b = new Mesh();
//b.Show();

//interface IRenderable
//{
//    protected internal void Show();
//}

//class Mesh : IRenderable
//{
//    void IRenderable.Show()
//    {
//        Console.WriteLine("Mesh IRenderable.Show()");
//    }

//    public void Show()
//    {
//        Console.WriteLine("Mesh Show()");
//    }
//}

#endregion


#region Interfaces with inheritance

//Rect a = new Rect();

//interface IRenderable
//{
//    public void Render();
//    public void Calc();
//    public void Update();
//}

//abstract class Shape : IRenderable
//{
//    public abstract void Render();
//    public virtual void Calc() => Console.WriteLine("Shape.Render()");
//    public void Update() => Console.WriteLine("Shape.Update()");
//}

//class Rect : Shape
//{
//    public override void Render() => Console.WriteLine("Rect.Render()");
//    public override void Calc() => Console.WriteLine("Rect.Calc()");
//    public new void Update() => Console.WriteLine("new Rect.Update()");
//}





//interface IRenderable
//{
//    public void Render();
//}

//class Shape : IRenderable
//{
//    public void Render() => Console.WriteLine("Shape.Render()");
//}

//class Rect : Shape, IRenderable
//{
//    public new void Render() => Console.WriteLine("Shape.Render()");
//}






//Rect a = new Rect();
//a.Render();                             // 2

//Shape b = new Rect();
//b.Render();                             // 1

//IRenderable c = new Rect();
//c.Render();                             // 3


//interface IRenderable
//{
//    public void Render();
//}

//class Shape : IRenderable
//{
//    public void Render() => Console.WriteLine("1. Shape.Render()");
//}

//class Rect : Shape, IRenderable
//{
//    public new void Render() => Console.WriteLine("2. new Rect.Render()");
//    void IRenderable.Render() => Console.WriteLine("3. Explicit IRenderable.Render() from Rect");
//}

#endregion


#region Interfaces inheritance


//IWritable a = new FileManager();
//a.Write();                          // 1


//IFileSaver b = new FileManager();
//b.Write();                          // 3
//b.Save();                           // 2


//IWritable a = new FileManager();
//a.Write();

//IFileSaver b = new FileManager();
//b.Write();


//interface IWritable
//{
//    //public void Write();
//    public void Write() => Console.WriteLine("1. default Write() from IWritable");

//}
//interface IFileSaver: IWritable
//{
//    //public void Save();
//    public void Save() => Console.WriteLine("2. default Save() from IFileSaver");
//    public new void Write() => Console.WriteLine("3. new Write() from IFileSaver");
//}

//class FileManager : IFileSaver
//{
//    //public void Save()
//    //{
//    //    throw new NotImplementedException();
//    //}

//    //public void Write()
//    //{
//    //    throw new NotImplementedException();
//    //}

//    void IWritable.Write() => Console.WriteLine("4. Explicit IWritable.Write() from FileManager");
//    void IFileSaver.Write() => Console.WriteLine("5. Explicit IFileSaver.Write() from FileManager");
//}

#endregion


#region Interfaces as generic constraints

//FileManager<File> manager = new FileManager<File>();
//manager.Save(new File("/usr/bin/logs.txt"));

//interface IWritable
//{
//    public void Write();
//}

//interface ISavable
//{
//    string? Path { get; }
//}

//class File : IWritable, ISavable
//{
//    public string? Path { get; }
//    public File(string? path) => Path = path;
//    public void Write()
//    {
//        Console.WriteLine($"File {Path} written");
//    }
//}

//class FileManager<T>
//    where T : IWritable, ISavable
//{
//    public void Save(T data)
//    {
//        data.Write();
//    }
//}

#endregion


#region Generic interfaces

//User<int> u = new User<int>(101);

//interface IAuthenticator<T>
//{
//    public T Id { get; }
//}

//class User<T> : IAuthenticator<T>
//{
//    public T Id { get; }
//    public User(T id) => Id = id;
//}

//class Admin : IAuthenticator<string>
//{
//    public string Id {  get; }
//    public Admin(string id) => Id = id;
//}

//class Author : User<string>
//{
//    public Author(string id) :
//        base(id)
//    { }
//}

#endregion


#region IComparable / IComparable<T>

//List<int> nums = new List<int>() { 4, 7, 8, 2, 4, 6, 7, 9, 0 };
//nums.Sort();
//foreach(int n in nums)
//    Console.Write($"{n} ");
//Console.WriteLine("\n\n");


//List<User> users = new List<User>()
//{ 
//    new User() { Id = 101, Email = "email1@mail.com", Age = 43},
//    new User() { Id = 102, Email = "email2@mail.com", Age = 21},
//    new User() { Id = 103, Email = "email3@mail.com", Age = 32},
//    new User() { Id = 104, Email = "email4@mail.com", Age = 20},
//};

//users.Sort();
//foreach(User u in users)
//    Console.WriteLine(u);

////class User : IComparable
////{
////    public int Id { get; set; }
////    public string? Email { get; set; }
////    public int Age { get; set; }

////    public int CompareTo(object? obj)
////    {
////        if (obj is null)
////            throw new NullReferenceException();

////        if (obj is User u)
////            return Age - u.Age;

////        throw new ArgumentException();
////    }

////    public override string ToString()
////    {
////        return $"id: {Id}, email: {Email}, age: {Age}";
////    }
////}


//class User : IComparable<User>
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; } = 0;

//    public int CompareTo(User? obj)
//    {
//        if (obj is null)
//            throw new NullReferenceException();

//        return Age - obj.Age;
//    }

//    public override string ToString()
//    {
//        return $"id: {Id}, email: {Email}, age: {Age}";
//    }
//}

#endregion


#region IComparer

//List<User> users = new List<User>()
//{
//    new User() { Id = 101, Email = "email1@mail.com", Age = 43},
//    new User() { Id = 102, Email = "email2@mail.com", Age = 21},
//    new User() { Id = 103, Email = "email3@mail.com", Age = 32},
//    new User() { Id = 104, Email = "email4@mail.com", Age = 20},
//};

////users.Sort(new UserAgeComparer());
//users.Sort(new UserIdComparer(Direction.Desc));

//foreach (User u in users)
//    Console.WriteLine(u);


//class User
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }
//    public override string ToString()
//    {
//        return $"id: {Id}, email: {Email}, age: {Age}";
//    }
//}
//class UserAgeComparer : IComparer<User>
//{
//    public int Compare(User? x, User? y)
//    {
//        if (x is null || y is null)
//            throw new NullReferenceException();

//        return x.Age - y.Age;
//    }
//}
//enum Direction
//{
//    Asc,
//    Desc,
//}
//class UserIdComparer : IComparer<User>
//{
//    public Direction Direction { get; init; } = Direction.Asc;
//    public UserIdComparer(Direction direction)
//    {
//        Direction = direction;
//    }

//    public int Compare(User? x, User? y)
//    {
//        if (x is null || y is null)
//            throw new NullReferenceException();

//        return Direction == Direction.Asc ? x.Id - y.Id : y.Id - x.Id;
//    }
//}

#endregion


#region ICloneable

// ----- копия ссылки
//User a = new User(101, "vasia@mail.com");
//User b = a;

//b.Id = 1001;
//Console.WriteLine(a.Id);


// ----- ручное создание нового объекта
//User a = new User(101, "vasia@mail.com");
//User b = new User(a.Id, a.Email, new Role(a.Role?.Title));




//User a = new User(101, "vasia@mail.com", new Role("admin"));
//User? b = a.Clone() as User;
//b.Role.Title = "guest";
//Console.WriteLine(a.Role.Title);


//class Role
//{
//    public string Title { get; set; }
//    public Role(string title) => Title = title;
//}

//class User: ICloneable
//{
//    public int Id { get; set; }
//    public string Email { get; set; } = string.Empty;
//    public Role? Role { get; set; }
//    public User(int id, string email, Role? role = null)
//    {
//        Id = id;
//        Email = email;
//        Role = role;
//    }

//    public object Clone()
//    {
//        // return new User(Id, Email, Role);

//        // return MemberwiseClone();

//        return new User(Id, new string(Email), Role != null ? new Role(Role.Title) : null);
//    }
//}

#endregion


#region invariance (as it is) / covariance (up to types, out T) / contrvariance (down to types, in T)

// ------------------- обобщённый интерфейс с инвариантным универсальным параметром -------------------

//MySqlManager manager = new MySqlManager();

//IConnectionManager<MySqlConnection> manager_0 = manager;

//IConnectionManager<MySqlConnection> manager_1 = new MySqlManager();

//// IConnectionManager<Connection> manager_2 = new MySqlManager();              // ERROR


////List<IConnectionManager<Connection>> list = new List<IConnectionManager<Connection>>()
////{
////    new MySqlManager();
////};



//class Connection
//{
//    public string? Config { get; set; }
//    public Connection(string? config)
//    {
//        Config = config;
//    }
//}
//class MySqlConnection : Connection
//{
//    public MySqlConnection(string? config) : base(config)
//    { }
//}


//interface IConnectionManager<T>
//    where T : Connection
//{
//    T CreateConnection(string connfig);
//}
//class MySqlManager : IConnectionManager<MySqlConnection>
//{
//    public MySqlConnection CreateConnection(string config)
//    {
//        return new MySqlConnection(config);
//    }
//}





// ------------------- обобщённый интерфейс с ковариантным универсальным параметром -------------------

// ===== example 1
//MySqlManager manager_0 = new MySqlManager();

//IConnectionManager<MySqlConnection> manager_1 = new MySqlManager();

//IConnectionManager<Connection> manager_2 = new MySqlManager();
//Connection conn1 = manager_2.CreateConnection("config 1 string");
//Console.WriteLine(conn1.Config);

//IConnectionManager<Connection> manager_3 = new SqlServManager();
//Connection conn2 = manager_2.CreateConnection("config 2 string");
//Console.WriteLine(conn2.Config);


//List<IConnectionManager<Connection>> list = new List<IConnectionManager<Connection>>()
//{
//    new MySqlManager(),
//    new SqlServManager(),
//};

//foreach (IConnectionManager<Connection> manager in list)
//    Console.WriteLine(manager.CreateConnection("main config").Config);



//class Connection
//{
//    public string? Config { get; set; }
//    public Connection(string? config)
//    {
//        Config = config;
//    }
//}
//class MySqlConnection : Connection
//{
//    public MySqlConnection(string? config) : base(config)
//    { }
//}
//class SqlServConnection : Connection
//{
//    public SqlServConnection(string? config) : base(config)
//    { }
//}



//interface IConnectionManager<out T>
//    where T : Connection
//{
//    T CreateConnection(string connfig);
//}
//class MySqlManager : IConnectionManager<MySqlConnection>
//{
//    public MySqlConnection CreateConnection(string config)
//    {
//        return new MySqlConnection(config);
//    }
//}
//class SqlServManager : IConnectionManager<SqlServConnection>
//{
//    public SqlServConnection CreateConnection(string config)
//    {
//        return new SqlServConnection(config);
//    }
//}





// ===== example 2



//IUnitBuilder builder = new WarriorBuilder();
//List<IUnitBuilder> builders = new List<IUnitBuilder>()
//{
//    new ArcherBuilder(),
//    new WarriorBuilder(),
//};

//class Unit
//{
//    public string Title { get; set; }
//    public int Hp { get; set; }
//    public Unit(string title, int hp)
//    {
//        Title = title;
//        Hp = hp;
//    }
//}

//class Archer : Unit
//{
//    public Archer(string title, int hp) : base(title, hp)
//    { }
//}
//class Assasin : Archer
//{
//    public Assasin(string title, int hp) : base(title, hp)
//    { }
//}

//class Warrior : Unit
//{
//    public Warrior(string title, int hp) : base(title, hp)
//    { }
//}

//interface IUnitBuilder
//{
//    public Unit BuildUnit(string title, int hp);
//}

//class ArcherBuilder : IUnitBuilder
//{
//    public Unit BuildUnit(string title, int hp)
//    {
//        return new Archer(title, hp);
//    }
//}

//class WarriorBuilder : IUnitBuilder
//{
//    public Unit BuildUnit(string title, int hp)
//    {
//        return new Warrior(title, hp);
//    }
//}







//IUnitBuilder<Unit> u1 = new ArcherBuilder();
//IUnitBuilder<Unit> u2 = new WarriorBuilder();
//IUnitBuilder<Unit> u3 = new AssasinBuilder();



//class Unit
//{
//    public string Title { get; set; }
//    public int Hp { get; set; }
//    public Unit(string title, int hp)
//    {
//        Title = title;
//        Hp = hp;
//    }
//}


//class Archer : Unit
//{
//    public Archer(string title, int hp) : base(title, hp)
//    { }
//}
//class Assasin : Archer
//{
//    public Assasin(string title, int hp) : base(title, hp)
//    { }
//}

//class Warrior : Unit
//{
//    public Warrior(string title, int hp) : base(title, hp)
//    { }
//}



//interface IUnitBuilder<out T>
//{
//    public T BuildUnit(string title, int hp);
//}

//class ArcherBuilder : IUnitBuilder<Archer>
//{
//    public Archer BuildUnit(string title, int hp)
//    {
//        return new Archer(title, hp);
//    }
//}

//class AssasinBuilder : IUnitBuilder<Assasin>
//{
//    public Assasin BuildUnit(string title, int hp)
//    {
//        return new Assasin(title, hp);
//    }
//}

//class WarriorBuilder : IUnitBuilder<Warrior>
//{
//    public Warrior BuildUnit(string title, int hp)
//    {
//        return new Warrior(title, hp);
//    }
//}






// ------------------- обобщённый интерфейс с конрвариантным универсальным параметром -------------------



//object m0 = new MySqlManager();

//MySqlManager m1 = new MySqlManager();

//IConnectionManager<Connection> m2 = new MySqlManager();

//IConnectionManager<MySqlConnection> m3 = new MySqlManager();
//m3.SetConnection(new MySqlConnection("config string"));
//// m3.SetConnection(new Connection("config string"));           // ERROR

//IConnectionManager<SqlServConnection> m4 = new SqlServManager();
//m4.SetConnection(new SqlServConnection("config"));
//m4.SetConnection(new DefaultSqlServConnection("config"));




//class Connection
//{
//    public string? Config { get; set; }
//    public Connection(string? config)
//    {
//        Config = config;
//    }
//}
//class MySqlConnection : Connection
//{
//    public MySqlConnection(string? config) : base(config)
//    { }
//}
//class SqlServConnection : Connection
//{
//    public SqlServConnection(string? config) : base(config)
//    { }
//}

//class DefaultSqlServConnection : SqlServConnection
//{
//    public DefaultSqlServConnection(string? config) : base(config)
//    {}
//}



//interface IConnectionManager<in T>
//    where T : Connection
//{
//    public void SetConnection(T conn);
//}
//class MySqlManager : IConnectionManager<Connection>
//{
//    public void SetConnection(Connection conn)
//    {
//        Console.WriteLine($"MySqlManager: {conn.Config}");
//    }
//}
//class SqlServManager : IConnectionManager<Connection>
//{
//    public void SetConnection(Connection conn)
//    {
//        Console.WriteLine($"SqlServManager: {conn.Config}");
//    }
//}









// ------------------- обобщённый интерфейс с разными универсальными параметроми -------------------



ILogger<int, A, C> logger = new Logger();

interface ILogger<T, out K, in V>
{

}

class A {}

class B: A {}

class C: B { }


class Logger: ILogger<int, C, A>
{

}


#endregion