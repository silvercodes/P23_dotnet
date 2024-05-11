

#region Intro
//User a = new User();
//a.id = 101;
//a.email = "vasia@mail.com";

//a.Render();

//class User
//{
//    public int id;
//    public string email;

//    public void Render()
//    {
//        Console.WriteLine($"User info: {id} --> {email}");
//    }
//}



//using _01_class;

//User a = new User();
//a.Render();
//Role role = new Role();
//role.id = 1;
//role.title = "Admin";
//role.Show();

//class User
//{
//    public int id = 100;
//    public string email = "no_email";

//    public void Render()
//    {
//        Console.WriteLine($"User info: {id} --> {email}");
//    }
//} 
#endregion


#region Ctor


//User a = new User(102);

//class User
//{
//    public int id;
//    public string email;

//    public User(int id = 0, string email = "no_email")
//    {
//        this.id = id;
//        this.email = email;
//        Console.WriteLine("first");
//    }
//    public User(int id):
//        this(id, "no_email")                // делегирование
//    {
//        //this.id = id;
//        //email = "no_email";
//        Console.WriteLine("second");
//    }
//}



// FROM C# 12
// --- Первичный конструктор (primary ctor)

//Console.WriteLine();
//User a = new User(101);
//a.Show();

//class User(int id, string email)
//{
//    public User(int id) :
//        this(id, "no_email")
//    { }

//    public void Show()
//    {
//        Console.WriteLine($"{id} {email}");
//    }
//}


#endregion


#region Initializer

//Unit a = new Unit("warrior", 200)
//{
//    hp = 300,
//};

//a.Show();

//Logger logger = new Logger()
//{
//    filePath = "/usr/bin",
//    depth = 100,
//};


//class Unit
//{
//    public string title;
//    public int hp;

//    public Unit(string title, int hp)
//    {
//        this.title = title;
//        this.hp = hp;
//    }
//    public void Show() => Console.WriteLine($"{title} {hp}");
//}

//class Logger
//{
//    public string filePath;
//    public bool recursive = false;
//    public int depth = 500;
//    public string level = "warning";
//}

#endregion


#region Deconstructor


//User a = new User(101, "vasia@mail.com");


//a.Deconstruct(out int id0, out string email0);
//// equals
//(int id, string email) = a;


//(_, string email2) = a;


//class User
//{
//    private int id;
//    private string email;

//    public User(int id, string email)
//    {
//        this.id = id;
//        this.email = email;
//    }

//    public void Deconstruct(out int id, out string email)
//    {
//        id = this.id;
//        email = this.email;
//    }
//}

#endregion

