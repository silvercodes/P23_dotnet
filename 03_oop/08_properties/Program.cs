
#region Intro
//User a = new User();
//a.Id = 101;
//Console.WriteLine(a.Id);

//a.Age = -5;

//a.Show();

//class User
//{
//    private int id;
//    private int age;

//    public int Id
//    {
//        get
//        {
//            return id;
//        }
//        set
//        {
//            id = value;
//        }
//    }

//    public int Age
//    {
//        get
//        {
//            return age;
//        }
//        set
//        {
//            age = value < 0 ? 18 : value;
//        }
//    }

//    public void Show()
//    {
//        Console.WriteLine($"{Id}\t{Age}");
//    }


//}

#endregion


#region "partial" properties


//User user = new();

//Console.WriteLine(user.Email);
//// user.Email = "vasia@mail.com";           // ERROR

//user.Age = 45;
//// Console.WriteLine(user.Age);             // ERROR

//Console.WriteLine(user.Info);

//class User
//{
//    private string email = "no_email";
//    private int age;

//    public string Email
//    {
//        get
//        {
//            return email;
//        }
//    }

//    public int Age
//    {
//        set
//        {
//            age = value;
//        }
//    }

//    public string Info
//    {
//        get
//        {
//            return $"Age: {age}\t{Email}";
//        }
//    }
//}

#endregion


#region modificators

//class User
//{
//    private string email = "no_email";
//    private int age = 0;

//    public string Email
//    {
//        get
//        { 
//            return email;
//        }
//        protected set
//        {
//            email = value;
//        }
//    }

//    //public int Age            // ERROR (модификатор блока только у полного св-ва)
//    //{
//    //    private get
//    //    {
//    //        return age;
//    //    }
//    //}
//}

#endregion


#region auto properties

//Console.WriteLine();
//class User
//{
//    public string Email { get; set; }
//    public int Age { get; } = 18;
//    public string Name { get; private set; }
//    public string Password { get; set; } = "no_password";

//    public User(int age)
//    {
//        Age = age;
//    }

//    public void Render()
//    {
//        // Age = 12;           // ERROR
//    }
//}

#endregion


#region init block

//User user1 = new();
//User user2 = new("vasia@mail.com");
//User user3 = new() { Email = "petya@mail.com" };
//User user6 = new() { Username = "chack_norris" };

//User user4 = new();
//User user5 = new("vasia@mail.com");
//// User user6 = new() { Password = "123123123" };       // ERROR


//class User
//{
//    private string username;
//    public string Email { get; init; } = "no_email";
//    public string Username
//    {
//        get
//        {
//            return username;
//        }
//        init
//        {
//            username = value;
//            Email = $"{username}@mail.com";
//        }
//    }

//    public string Password { get; } = "no_pass";

//    public User()
//    { }

//    public User(string email)
//    {

//    }
//}


#endregion


#region Practice

//User user = new()
//{
//    //Email = "Vasia@mail.com",     // ERROR
//};
//class User
//{
//    private int Id { get; }
//    public string Email { get; private set; }
//    public string Password { private get; init; }


//}

#endregion


#region buns :)

//class User
//{
//    private string email;
//    private string password;

//    public string Email
//    {
//        get => email;
//        set => email = value;
//    }


//    //public string Password
//    //{
//    //    get => password;
//    //}
//    // --> equals -->
//    public string Password => password;
//}

#endregion


#region required

// User a = new User();                     // ERROR

// User a = new User("vasia@mail.com");     // ERROR

//User a = new("petya@mail.com")            // ERROR
//{
//    Age = 23,
//};

//User a = new()
//{
//    Age = 23,
//    Email = "petya@mail.com",
//};

//class User
//{
//    public required int Age { get; set; }
//    public required string Email { get; set; }
//    public User()
//    {}
//    public User(string email)
//    {
//        Email = email;
//    }
//}

#endregion
