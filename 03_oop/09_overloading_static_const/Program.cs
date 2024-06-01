
#region Overloading

// 1. Имя должно совпадать
// 2. Другое кол-во параметров
// 3. Тип (порядок) параметров
// 4. Модификаторы параметров

//class Container
//{
//    public void Method(int a, int b)
//    {

//    }

//    public void Method(int a, int b, int c)
//    {

//    }

//    public void Method(int a, string b)
//    {

//    }

//    public void Method(string a, int b)
//    {

//    }

//    public void Method(ref string a, ref readonly int b)
//    {

//    }
//}


#endregion


#region Static


//Console.WriteLine(User.MaxId);
//User a = new User();

//// Console.WriteLine(a.maxId);      // ERROR
//class User
//{
//    // статическое поле (НЕ является частью состояния объекта)
//    private static int maxId;

//    // обычное поле (является частью состояния объекта)
//    public int id;

//    // статический конструктор (инициализирует статические поля и св-ва)
//    // 1. Нельзя использовать модификатор доступа
//    // 2. Нет this
//    // 3. Нельзя вызывать явно (вызывается автоматически)
//    static User()
//    {
//        MaxId = 0;
//    }

//    // статический метод
//    // 1. Нет this
//    // 2. Можно использовать только статические поля / св-ва
//    public static void ResetMaxId() => User.MaxId = 101;
//    // статическое св-во
//    public static int MaxId
//    {
//        get => User.maxId;
//        set => User.maxId = value;
//    }
//    // статическое автосв-во
//    public static int InstanceCount { get; set; } = 0;

//    // обычный конструктор
//    public User()
//    {
//        id = ++User.maxId;
//    }
//}

#endregion


#region const

//Console.WriteLine(User.DEFAULT_ROLE);

//User a = new User("Petya");
//User b = new User("Vasia");

//// a.DEFAULT_NAME = "no_name";      // ERROR
//// User.DEFAULT_ROLE = "admin";        // ERROR

//class User
//{
//    // Не является частью состояния объекта
//    // 1. Инициализация: при объявлении
//    public const string DEFAULT_ROLE = "guest";

//    // Является частью состояния объекта
//    // 1. Инициализация: при объявлении, в конструкторе
//    public readonly string DEFAULT_NAME = "no_name";

//    public static readonly int DEFAULT_LEVEL = 1;

//    public User(string defName)
//    {
//        DEFAULT_NAME = defName;
//    }
//}

//readonly struct Shape
//{
//    public readonly string DEFAULT_NAME;
//    public int Size { get; }
//    public string Title { get; init; }
//    public Shape(int size, string title)
//    {
//        Size = size;
//        Title = title;
//    }
//}

#endregion

