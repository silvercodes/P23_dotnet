


// string? a = null;


// string? input = Console.ReadLine();


//void Render(string? str)
//{
//    if (str == null)
//        Console.WriteLine("null !!!!");
//    else
//        Console.WriteLine(str);
//}

//string? input = null;
//Render(input);





//void Render(string? str)
//{
//    //if (str == null)
//    //    Console.WriteLine("null !!!!");
//    //else
//    //    Console.WriteLine(str.ToLower());

//    Console.WriteLine(str.ToLower());
//}

//string? input = null;

//Render(input);






//int t = 34;


//int? a = null;      // --> Nullable<int> aa = null;


//string? b = null;




//User user = new()
//{ 
//    Id = 101,
//    Name = "Vasia",
//    Email = "vasia@mail.com",
//    Password = "123",
//    Age = null
//};
//class User
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public string Password { get; set; }
//    public int? Age { get; set; }
//}





// ===== null guard =====

//void Render(string? message)
//{
//    //if (message == null)
//    //    return;
//    //Console.WriteLine(message);




//    //if (message is null)
//    //    return;
//    //Console.WriteLine(message);

//    //if (message is not null)
//    //    Console.WriteLine(message);

//    //if (message is string)
//    //    Console.WriteLine(message);
//}




// ===== null union =====

//Console.Write("Enter your name: ");

//// 1.
////string? input = Console.ReadLine();
////string value = input ?? "no_name";

//// 2.
//// string value = Console.ReadLine() ?? "no_name";

//// 3.
//string? input = Console.ReadLine();
//input ??= "no_name";                    // input = input ?? "no_name"



//Console.WriteLine($"Your name is {value}");





// ====== Условный null ======

//void Process(User? user)
//{
//    //if (user is not null && user.Role is not null && user.Role.Title is not null)
//    //    user.Role.Show();

//    user?.Role?.Show();
//}

//class Role
//{
//    public string? Title { get; set; }
//    public void Show()
//    {
//        Console.WriteLine($"Title = {Title}");
//    }
//}
//class User
//{
//    public Role? Role { get; set; }
//}

