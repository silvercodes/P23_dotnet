﻿
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

//// ===== upcasting (восходящее преобразование / упаковка объкта / обобщение) =====

//Warrior warrior = new Warrior(100, 300);

//Unit unit = warrior;                        // upcasting

//Console.WriteLine(unit.Hp);
//// Console.WriteLine(unit.Force);           // ERROR

//object obj = unit;


// ===== downcasting (нисходящее преобразование / распаковка объекта) =====

//Archer archer = new Archer(120, 30);
//Unit unit = archer;

//Archer archer2 = (Archer)unit;
//Console.WriteLine(archer2.ArrCount);


//Unit u = new Archer(120, 30);
//Archer a = (Archer)u;


//object obj = new Warrior(100, 200);
//Unit u = (Unit)obj;
//Warrior w = (Warrior)obj;

//Archer a = (Archer)obj;                 // FU FU FU ERROR



//Unit a = new Unit(100);
//object b = (object)a;
//// Archer c = (Archer)a;                // ERROR
//// Warrior d = (Warrior)b;                 // ERROR




// ===== as / is =====
//Unit u = new Archer(130, 20);

////Archer? a = u as Archer;                // NO EXCEPTION!!!!
////a?.Render();

//if (u is Archer)
//    u.Render();

//if (u is Archer archer)
//    archer.Render();


//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp)
//    {
//        Hp = hp;
//    }
//    public void Render()
//    {
//        Console.WriteLine($"hp: {Hp}");
//    }
//}
//class Archer: Unit
//{
//    public int ArrCount { get; set; }
//    public Archer(int hp, int arrCount):
//        base(hp)
//    { 
//        ArrCount = arrCount;
//    }

//}
//class Warrior : Unit
//{
//    public int Force { get; set; }
//    public Warrior(int hp, int force) :
//        base(hp)
//    {
//        Force = force;
//    }

//}

#endregion


#region virtual / override

////User u = new Student(101, 34);
////u.Show();

////User a = new User(101, 34);
////a.Age = 15;
////a.Show();

////User b = new Student(102, 23);
////b.Age = 15;
////b.Show();

//User a = new SuperStudent(103, 23);
//a.Show();

//class User
//{
//    public int Id { get; set; }
//    public virtual int Age { get; set; }
//    public User(int id, int age)
//    {
//        Id = id;
//        Age = age;
//    }
//    public virtual void Show()
//    {
//        Console.WriteLine($"id: {Id}, age: {Age}");
//    }

//    //public static virtual Method()                // не имеет смысла
//    //{

//    //}
//}

//class Student: User
//{
//    public override int Age
//    {
//        get => base.Age;
//        set
//        {
//            base.Age = value >= 18 ? value : 18;
//        }
//    }
//    public Student(int id, int age):
//        base(id, age)
//    { }

//    public override sealed void Show()
//    {
//        Console.Write("Student --> ");
//        base.Show();
//    }
//}

//class SuperStudent : Student
//{
//    public SuperStudent(int id, int age) 
//        : base(id, age)
//    {}

//    //public override void Show()                       // ERROR
//    //{
//    //    Console.Write("SuperStudent --> ");
//    //    base.Show();
//    //}
//}




//B b = new D();
//b.Show();

//class A
//{
//    public virtual void Show() => Console.WriteLine("A Show()");
//}

//class B : A
//{

//}

//class C : B
//{
//    public override void Show() => Console.WriteLine("C Show()");
//}

//class D : C
//{

//}

//class E : D
//{
//    public override void Show() => Console.WriteLine("E Show()");
//}


#endregion


#region Hiding (скрытие)

//Admin admin = new Admin(101, "admin@mail.com");
//admin.Show();

//User user = new Admin(102, "vasia@mail.com");
//user.Show();



//Admin admin = new Admin(101, "admin@mail.com");
//admin.Email = "brus@mail.com";
//admin.Show();

//User user = new Admin(102, "vasia@mail.com");
//user.Email = "chack@mail.com";
//user.Show();



//Console.WriteLine(User.maxAge);
//Console.WriteLine(Admin.maxAge);

//Console.WriteLine(User.Pi);
//Console.WriteLine(Admin.Pi);




//class User
//{
//    public readonly static int maxAge = 18;
//    public const double Pi = 3.14;
//    public int Id { get; set; }
//    public string Email { get; set; } = "no_email";
//    public User(int id, string email)
//    {
//        Id = id;
//        Email = email;
//    }
//    public void Show()
//    {
//        Console.WriteLine($"User: {Email}");
//    }
//}

//class Admin : User
//{
//    public new readonly static int maxAge = 30;
//    public new const double Pi = 3.1415;
//    public new string Email
//    {
//        get => $"admin: {base.Email}";
//        set => base.Email = value;
//    }
//    public Admin(int id, string email) 
//        : base(id, email)
//    {}

//    public new void Show()
//    {
//        base.Show();
//        Console.WriteLine($"Admin: {Email}");
//    }
//}


#endregion





