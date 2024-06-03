
#region Inhertance
// Ограничения
// == 1. Только одиночное наследование (interfaces :-))
// == 2. Модификатор наследования - public (в терминах C++)
// == 3. Модификатор класса-наследника --> такой же или более строгий
//internal class A
//{ }
////public class B: A       // ERROR
////{ }
//file class C: A
//{ }
// == 4. Класс можно сделать запечатанным (финализированным в терминах C++)
//sealed class A
//{ }
////class B: A                  // ERROR
////{ }
// == 5. Наследование от статического класса запрещено


//Admin admin = new Admin("admin@mail.com", 34, "read");
//admin.Render();
//internal class User
//{
//    private string email = string.Empty;
//    public string Email { get => email; set => email = value; }
//    public int Age { get; set; }
//    public User()
//    {

//    }
//    public User(int age)
//    {
//        Age = age;
//        Console.WriteLine("User(int age)");
//    }
//    public User(string email, int age):
//        this(age)
//    {
//        Email = email;
//        Console.WriteLine("User(string email, int age)");
//    }
//    public void Show()
//    {
//        Console.WriteLine($"Email: {Email}");
//    }
//}

//internal class Admin: User
//{
//    public string Permission { get; set; }
//    public Admin(string email, int age, string permission):
//        base(email, age)
//    {
//        Permission = permission;
//        Console.WriteLine("Admin(string email, int age, string permission)");
//    }
//    public Admin(string permission)
//    {
//        Permission = permission;
//    }
//    public void Render()
//    {
//        Console.WriteLine($"Email: {Email}");
//    }
//}

#endregion


#region Type casting







#endregion

