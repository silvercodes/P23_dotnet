
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



Db db = new Db();

((IWritable)db).Write();        // :-(

if (db is IWritable wdb)        // :-)
    wdb.Write();

IWritable w = db;               // :-)
w.Write();


interface IWritable
{
    public void Write();
}

interface ISaver
{
    public void Write();
}

class Db: IWritable, ISaver
{
    // 1. Явная реализация
    // 2. Не является членом класса!!!
    // 3. Нельзя сделать public
    void IWritable.Write()
    {
        Console.WriteLine("Write from Db(IWritable)");
    }

    void ISaver.Write()
    {
        Console.WriteLine("Write from Db(ISaver)");
    }

    // === общая реализация (одна на все интерфесы)
    public void Write()
    {
        Console.WriteLine("Common realization");
    }
}

class FileManager : IWritable
{
    void IWritable.Write()
    {
        Console.WriteLine("Write from FileManager(IWritable)");
    }

    public void Write()
    {
        Console.WriteLine("Write from FileManager");
    }
}







#endregion
