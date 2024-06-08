
//      C++                                     C#
//  чистая виртуальная ф-ция                абстрактный метод (является виртуальным)
//  абстрактный класс                       абстрактный класс
//  интерфейсный класс                      интерфейс

// Абстрактными в C# могут быть:
// 1. Методы
// 2. Свойства
// 3. События
// 4. Индексаторы


//Console.WriteLine();
//abstract class Unit
//{
//    public int Hp { get; protected set; }           // автосвойство
//    public abstract int Force { get; set; }         // НЕ АВТОСВОЙСТВО !!!
//    public abstract int Points { get; set; }        // НЕ АВТОСВОЙСТВО !!!
//    public abstract void Defence();
//    public virtual void Move()
//    {
//        Console.WriteLine("Unit Move()");
//    }
//    public void Attack()
//    {
//        Console.WriteLine("Unit Attack()");
//    }
//}

//class Warrior: Unit
//{
//    public override int Force { get; set; }

//    private int points = 0;
//    public override int Points 
//    {
//        get => points;
//        set => points = value; 
//    }
//    public override void Defence()
//    {
//        Console.WriteLine("Warrior Defence()");
//    }
//    public override void Move()
//    {
//        Console.WriteLine("Warrior Move()");
//    }
//}

//class SuperWarrior : Warrior
//{
//    public override void Defence()
//    {
//        Console.WriteLine("SuperWarrior Defence()");
//    }
//}

////class Archer : Unit             // Требуется реализация абстратных членов ббазового класса
////{

////}






// ======= Object class virtual methods ========

//Product a = new()
//{
//    Id = 101,
//    Title = "Apple"
//};

//Console.WriteLine(a);


//class Product
//{
//    public int Id { get; set; }
//    public string Title { get; set; } = "no_title";

//    public override string ToString()
//    {
//        return $"id: {Id}\ttitle: {Title}";
//    }
//    public override int GetHashCode()
//    {
//        return Id.GetHashCode();
//    }
//    public override bool Equals(object? obj)
//    {
//        if (obj is Product p)
//        {
//            return Id == p.Id;
//        }

//        return false;
//    }
//}

