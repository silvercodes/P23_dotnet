﻿

#region Intro


//ExecuteDel del;

//del = f1;
//// del += f2;           // ERROR
//del += User.Show;



//del();

//del?.Invoke();




//ExecuteDel del1 = f1;
//ExecuteDel del2 = User.Show;

//ExecuteDel del3 = del1 + del2;
//del3?.Invoke();


//void f1()
//{
//    Console.WriteLine("f1");
//}

//void f2(int x = 10)
//{
//    Console.WriteLine($"x = {x}");
//}

//class User
//{
//    public static void Show()
//    {
//        Console.WriteLine("Show() from User class");
//    }
//}



// delegate void ExecuteDel();




#endregion

#region Base examples


//User u = new User();
//u.Process("Hello from Vasia");


//class User
//{
//    private delegate void NotifyHandler(string message);
//    public void Process(string message)
//    {
//        NotifyHandler handler;
//        handler = Notify;
//        handler += TelegramNotify;
//        // handler += EmailNotify;         // ERROR

//        handler?.Invoke(message);
//    }

//    private void Notify(string message)
//    {
//        Console.WriteLine($"Notify: {message}");
//    }

//    private void TelegramNotify(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"Telegram: {message}");
//        Console.ResetColor();
//    }

//    private void EmailNotify(string message, int level)
//    {

//    }
//}






//NotifyHandler? notifier = SendEmail;
//notifier += SendSms;
//notifier += SendTelegram;

//if (notifier is not null)
//    notifier("Vasia");

//Console.WriteLine("\n\n");

//notifier -= SendSms;

//if (notifier is not null)
//    notifier("Petya");



//void SendEmail(string content) => Console.WriteLine($"Email: content");
//void SendTelegram(string content) => Console.WriteLine($"Telegram: content");
//void SendSms(string content) => Console.WriteLine($"Sms: content");


//delegate void NotifyHandler(string content);

#endregion

#region Generic delegates

//Operation<string, int> op = Process;
//Console.WriteLine(op?.Invoke(3, 4));

//Operation<Operation<int, double>, int> op;

//string Process(int a, int b) => $"a = {a}, b = {b}";

//delegate T Operation<T, K>(K a, K b);







//int? Execute(int a, int b, Operation<int> op)
//{
//    return op?.Invoke(a, b);
//}


//Operation<int> GetOperation(OpType opType) => opType switch
//{
//    OpType.Add => Add,
//    OpType.Mult => Mult,
//    OpType.Sub => Sub,

//    _ => throw new NotSupportedException()
//};

//Operation<int> op = GetOperation(OpType.Add);
//int? result = op?.Invoke(4, 5);
//Console.WriteLine(result);

//Console.WriteLine(Execute(3, 4, Mult));
//Console.WriteLine(Execute(3, 4, new Operation<int>(Add)));




//int Add(int a, int b) => a + b;
//int Mult(int a, int b) => a * b;
//int Sub(int a, int b) => a - b;
//enum OpType
//{
//    Add,
//    Mult,
//    Sub,
//}


//delegate T Operation<T>(T a, T b);



#endregion

#region Practice0
// ============== Классическая реализация паттерна Observer ==============


//Account acc = new Account();
//acc.AddNotifier(new TelegramNotifier());
//acc.AddNotifier(new EmailNotifier());
//acc.AddNotifier(new SmsNotifier());

//acc.Add(1000);
//acc.Withdraw(10000);


//interface INotifier
//{
//    void Notify(string message);
//}

//class TelegramNotifier : INotifier
//{
//    public void Notify(string message)
//    {
//        Console.WriteLine($"Telegram: {message}");
//    }
//}
//class EmailNotifier : INotifier
//{
//    public void Notify(string message)
//    {
//        Console.WriteLine($"Email: {message}");
//    }
//}
//class SmsNotifier : INotifier
//{
//    public void Notify(string message)
//    {
//        Console.WriteLine($"Sms: {message}");
//    }
//}


//class Account
//{
//    private int sum;
//    private List<INotifier> notifiers = new List<INotifier>();

//    public void AddNotifier(INotifier notifier) => notifiers.Add(notifier);

//    public void Add(int val)
//    {
//        sum += val;

//        foreach(INotifier notifier in notifiers)
//        {
//            notifier.Notify($"ADDED: {val}");
//        }
//    }

//    public void Withdraw(int val)
//    {
//        if (sum >= val)
//        {
//            sum -= val;

//            foreach (INotifier notifier in notifiers)
//            {
//                notifier.Notify($"Withdrawen: {val}");
//            }
//        }
//        else
//        {
//            foreach (INotifier notifier in notifiers)
//            {
//                notifier.Notify($"ERROR: {val}");
//            }
//        }
//    }

//}




// ============== реализация паттерна Observer на делегатах ==============


//Account acc = new Account(1000);

//acc.RegisterSuccessHandler(TelegramNotifier.Notify);

//acc.RegisterErrorHandler(TelegramNotifier.Notify);
//acc.RegisterErrorHandler(EmailNotifier.Notify);
//acc.RegisterErrorHandler(SmsNotifier.Notify);

//acc.Add(500);
//acc.Withdraw(2000);


//class TelegramNotifier
//{
//    public static void Notify(string message)
//    {
//        Console.WriteLine($"Telegram: {message}");
//    }
//}
//class EmailNotifier
//{
//    public static void Notify(string message)
//    {
//        Console.WriteLine($"Email: {message}");
//    }
//}
//class SmsNotifier
//{
//    public static void Notify(string message)
//    {
//        Console.WriteLine($"Sms: {message}");
//    }
//}


//class Account
//{
//    public delegate void NotifyHandler(string message);

//    private int sum;

//    private NotifyHandler successHandlers;
//    private NotifyHandler errorHandlers;

//    public Account(int sum)
//    {
//        this.sum = sum;
//    }

//    public void RegisterSuccessHandler(NotifyHandler handler) => successHandlers += handler;
//    public void RegisterErrorHandler(NotifyHandler handler) => errorHandlers += handler;


//    public void Add(int val)
//    {
//        sum += val;

//        successHandlers?.Invoke($"Added: {val}");
//    }

//    public void Withdraw(int val)
//    {
//        if (sum >= val)
//        {
//            sum -= val;

//            successHandlers?.Invoke($"Withdrawen: {val}");
//        }
//        else
//        {
//            errorHandlers?.Invoke($"ERROR: {val}");
//        }
//    }

//}

#endregion

#region Anonymus methods


//NotifyHandler handler = delegate (string message)
//{
//    Console.WriteLine($"from anonymus method: {message}");
//};

//handler?.Invoke("Vasia");


//delegate void NotifyHandler(string message);







//void WindowsNotifier(string message)
//{
//    Console.WriteLine($"Windows: {message}");
//}
//Notify("First message", WindowsNotifier);


//Notify("Second message", delegate (string message)
//{
//    Console.WriteLine($"From anonymus function: {message}");
//});


//Notify("Third message", delegate
//{
//    Console.WriteLine($"Custom message: Vasia");
//});


//void Notify(string message, NotifyHandler handler)
//{
//    handler?.Invoke(message);
//}


//delegate void NotifyHandler(string message);






//int factor = 4;

//ResultGetter rg = delegate (int a, int b)
//{
//    return (a + b) * factor;
//};

//Console.WriteLine(rg(3, 4));


//delegate int ResultGetter(int a, int b);







//Executor GenerateExecutor(int factor)
//{
//    return delegate (int a, int b)
//    {
//        return (a + b) * factor;
//    };
//}


//Executor ex1 = GenerateExecutor(2);
//Console.WriteLine(ex1(2, 3));
//Console.WriteLine(ex1(1, 2));

//Executor ex2 = GenerateExecutor(3);
//Console.WriteLine(ex2(2, 3));
//Console.WriteLine(ex2(1, 2));


//delegate int Executor(int a, int b);






//Counter GenerateCounter(int initValue)
//{
//    int count = initValue;

//    return delegate ()
//    { 

//        Console.WriteLine($"Count = {count}");

//        count++;
//    };
//}

//Counter c1 = GenerateCounter(10);
//c1();
//c1();
//c1();
//c1();

//Counter c2 = GenerateCounter(100);
//c2();
//c2();
//c2();
//c2();


//delegate void Counter();

#endregion

#region Lambdas

// ==== intro ====


//Handler h1 = new Handler(Method1);

//Handler h2 = Method1;

//Handler h3 = delegate ()
//{
//    Console.WriteLine("From anonymus method");
//};

//Handler h4 = () => { Console.WriteLine("from lambda"); };

//Handler h5 = () => Console.WriteLine("from lambda");

//var h6 = () => Console.WriteLine("from lambda");

//h5 += () => Console.WriteLine("from lambda 2");


//h5?.Invoke();


//void Method1()
//{
//    Console.WriteLine("Method1");
//}


// delegate void Handler();




// ==== lambda parameters / returns ====

//OperationHandler operation1 = (int a, int b) => { return a + b; };  // :-|
//// equals
//OperationHandler operation2 = (a, b) => a + b;                      // :-)

//int res = operation2(3, 4);


//RenderHandler rh1 = (string message) => { Console.WriteLine($"message: {message}"); };  //  :-|

//RenderHandler rh2 = m => Console.WriteLine($"message: {m}");                            //  :-)



//OperationHandler sumHandler = (a, b) => a + b;
//OperationHandler divHandler = (a, b) => a / b;
//OperationHandler mulHandler = (a, b) => a * b;

//Console.WriteLine(sumHandler(4, 5));
//Console.WriteLine(divHandler(4, 5));
//Console.WriteLine(mulHandler(4, 5));


//delegate int OperationHandler(int a, int b);
//delegate void RenderHandler(string message);




// ==== labdas and delegates ====


//Handler handler = Show;
//handler += () => Console.WriteLine("one");
//handler += delegate { Console.WriteLine("two"); };

//handler -= Show;

//handler();


//void Show()
//{
//    Console.WriteLine("Show()");
//}

//delegate void Handler();


#endregion

#region Practice1

// ==== Pracice ====

// Создать метод, который суммирует эоементы массива по условию, которое определяется вне метода

//int[] arr = { 4, 6, 7, 3, 2, 1, 7, 9 };

//int Sum(int[] arr, Predicate predicate)
//{
//    int sum = 0;

//    foreach (int n in arr)
//        if (predicate(n))
//            sum += n;

//    return sum;
//}

//Console.WriteLine(Sum(arr, n => n % 2 == 0));
//Console.WriteLine(Sum(arr, n => n > 0));


//delegate bool Predicate(int val);

#endregion

#region Practice2

// Написать метод для поиска пользователя(-ей) по разным критериям

// --- 1. Простой способ

//List<User> users = new List<User>()
//{
//    new User(110, "vasia@mail.com", 34),
//    new User(45, "petya@mail.com", 24),
//    new User(112, "kima@mail.com", 15),
//    new User(165, "kolya@mail.com", 21),
//    new User(110, "bogdan@mail.com", 23),
//};

//List<User> Find(List<User> users, Predicate predicate)
//{ 
//    List<User> result = new List<User>();

//    foreach(User user in users)
//        if (predicate(user))
//            result.Add(user);

//    return result;
//}


////List<User> res = Find(users, u => u.Id == 110);
////foreach(User user in res)
////    Console.WriteLine(user);

////List<User> res = Find(users, u => u.Age < 18);
////foreach (User user in res)
////    Console.WriteLine(user);

//List<User> res = Find(users, u => u.Email.StartsWith('k'));
//foreach (User user in res)
//    Console.WriteLine(user);


//class User
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }
//    public User(int id, string? email, int age)
//    {
//        Id = id;
//        Email = email;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"Id: {Id}, Email: {Email}, Age: {Age}";
//    }
//}

//delegate bool Predicate(User user);



// ---- 2. Generic method

//List<User> users = new List<User>()
//{
//    new User(110, "vasia@mail.com", 34),
//    new User(45, "petya@mail.com", 24),
//    new User(112, "kima@mail.com", 15),
//    new User(165, "kolya@mail.com", 21),
//    new User(110, "bogdan@mail.com", 23),
//};

//List<int> nums = new List<int>()
//{
//    4, 6, 7, 8, 9, 1, 2, 4, 4, 4, 6
//};

//List<T> Find<T>(List<T> items, Predicate<T> predicate)
//{
//    List<T> result = new List<T>();

//    foreach (T item in items)
//        if (predicate(item))
//            result.Add(item);

//    return result;
//}



//List<User> res = Find<User>(users, u => u.Age < 18);
//foreach (User user in res)
//    Console.WriteLine(user);

//List<int> res2 = Find<int>(nums, n => n % 2 == 0);
//foreach(int item in res2)
//    Console.WriteLine(item);



//class User
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }
//    public User(int id, string? email, int age)
//    {
//        Id = id;
//        Email = email;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"Id: {Id}, Email: {Email}, Age: {Age}";
//    }
//}

//delegate bool Predicate<T>(T item);


#endregion

#region Practice3

// Написать метод, который проверяет валидность email'а
// Метод должен использовать 2 колбэка (1 - на случай успеха, 2 - на случай провала валидации)
// Метод таккже должен принимать делегат, содержащий логику валидации
// Оформить в виде класса EmailValidator


//EmailValidator validator = new EmailValidator();
//validator.Validate(
//    "vasiamail.com",
//    e => Console.WriteLine($"{e} is valid"),
//    e => Console.WriteLine($"{e} is invalid"),
//    e => e.Contains('@')
//);


//class EmailValidator
//{
//    public delegate void Callback(string email);

//    public void Validate(string email, Callback fullfill, Callback reject, Predicate<string> validationPredicate)
//    {
//        if (validationPredicate(email))
//            fullfill(email);
//        else
//            reject(email);
//    }
//}

//delegate bool Predicate<T>(T item);

#endregion

#region Imbeded delgates

// 1. ==== Action / Action<T...> ====

//RenderMessage("Hello Vasia", m => Console.WriteLine($"Message: {m}"));
//CastToString(12, 7, (a, b) => Console.WriteLine($"{a} -- {b}"));

//void RenderMessage(string message, Action<string> handler)
//{
//    handler(message);
//}

//void CastToString(int a, int b, Action<int, int> handler)
//{
//    handler(a, b);
//}


// 2. ==== Predicate<T> ====

//int[] arr = { 4, 6, 7, 3, 2, 1, 7, 9 };

//int Sum(int[] arr, Predicate<int> predicate)
//{
//    int sum = 0;

//    foreach (int n in arr)
//        if (predicate(n))
//            sum += n;

//    return sum;
//}

//Console.WriteLine(Sum(arr, n => n % 2 == 0));
//Console.WriteLine(Sum(arr, n => n > 0));

// 3. ==== Func<T..., TResult> ====

//Func<int> f1 = () => 5;

//Func<int, string> f2 = n => "string";

//Func<int, int, string> f3 = (a, b) => "string";

//// Func<int, bool> f4 = n => true;                 // Like a Predicate<T>

#endregion

#region Practice4

//Func<int, int, int> GenerateOperation(Operation op) => op switch
//{ 
//    Operation.Sum => (a, b) => a + b,
//    Operation.Mult => (a, b) => a * b,
//    Operation.Div => (a, b) => a / b,
//};

//Func<int, int, int> res = GenerateOperation(Operation.Div);
//res?.Invoke(3, 4);

//enum Operation
//{
//    Sum,
//    Mult,
//    Div,
//}

#endregion

#region HW

//Ping ping = new Ping();
//Pong pong = new Pong();

//ping.ReceiveHandler += () =>
//{
//    pong.DoPong();
//};

//pong.ReceiveHandler += () =>
//{
//    ping.DoPing();
//};

//ping.DoPing();


//class Ping
//{
//    private int count = 0;
//    public Action? ReceiveHandler;
//    public void DoPing()
//    {
//        if(count < 3)
//        {
//            ++count;
//            Console.WriteLine("PING");
//            Thread.Sleep(1000);
//            ReceiveHandler?.Invoke();
//        }
//    }

//}

//class Pong
//{
//    private int count = 0;
//    public Action? ReceiveHandler;
//    public void DoPong()
//    {
//        if(count < 3)
//        {
//            ++count;
//            Console.WriteLine("PONG");
//            Thread.Sleep(1000);
//            ReceiveHandler?.Invoke();
//        }

//    }
//}

#endregion

#region Covariance / contrvariance

// ==== ковариантность

//ConnectionHandler handler = ConnectToPg;                // ковариантность

//Connection conn_1 = handler("connfig 1 string");
//conn_1.Connect();

//PgConnection? conn_2 = handler("config 2 string") as PgConnection;
//conn_2?.Connect();

//PgConnection ConnectToPg(string config)
//{
//    return new PgConnection(config);
//}

//delegate Connection ConnectionHandler(string config);



// ==== контрвариантность

//ConnectionHandler handler = RunConnection;              // контрвариантность
//handler(new PgConnection("config string"));

//void RunConnection(Connection conn) => conn.Connect();

//delegate void ConnectionHandler(PgConnection conn);



// ==== ковариантность в обобщённых делегатах

//// -- инвариантность
//ConnectionHandler<MySqlConnection> mySqlHandler = (string config) => new MySqlConnection(config);
//// -- ковариантность
//ConnectionHandler<Connection> handler = new ConnectionHandler<MySqlConnection>((string config) => new MySqlConnection(config));
//Connection conn = handler("config string");
//conn.Connect();

//delegate T ConnectionHandler<out T>(string config);




// ==== контрвариантность в обобщённых делегатах

//// -- инвариантность
//ConnectionHandler<Connection> handler = (Connection conn) => conn.Connect();
//// -- контрвариантность
//ConnectionHandler<MySqlConnection> mySqlHandler = new ConnectionHandler<Connection>((Connection conn) => conn.Connect());
//mySqlHandler(new MySqlConnection("config"));


//handler(new Connection("aaa"));
//handler(new MySqlConnection("bbb"));
//handler(new PgConnection("ccc"));


//delegate void ConnectionHandler<in T>(T conn);



//class Connection
//{
//    public string Config { get; set; }
//    public Connection(string config)
//    {
//        Config = config;
//    }
//    public virtual void Connect()
//    {
//        Console.WriteLine($"Connection.Connect()");
//    }
//}

//class MySqlConnection : Connection
//{
//    public MySqlConnection(string config) : base(config)
//    {}

//    public override void Connect()
//    {
//        Console.WriteLine($"MySqlConnection.Connect()");
//    }
//}

//class PgConnection : Connection
//{
//    public PgConnection(string config) : base(config)
//    { }

//    public override void Connect()
//    {
//        Console.WriteLine($"PgConnection.Connect()");
//    }
//}


#endregion

#region Events

// ---------------------------------------------------
//Server server = new Server();
//server.Connected += s => Console.WriteLine(s);

//server.Disconnected += s => Console.WriteLine(s);
//server.Disconnected += RenderMessage;
//server.Disconnected -= RenderMessage;


//server.EmulateConnection();
//server.EmulateDisconnection();


//// server.Disconnected?.Invoke();                       // ERROR


//void RenderMessage(string message)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(message);
//    Console.ResetColor();
//}

//class Server
//{
//    //private Action<string> clientConnected;

//    //public void AddClientConnectedHandler(Action<string> handler)
//    //{
//    //    clientConnected += handler;
//    //}

//    //public void EmulateConnection()
//    //{
//    //    //
//    //    //
//    //    clientConnected?.Invoke("connected");
//    //}



//    private Action<string>? disconnected;

//    public event Action<string>? Connected;

//    public event Action<string>? Disconnected
//    {
//        add
//        {
//            disconnected += value;
//            Console.WriteLine($"{value?.Method.Name} added...");
//        }
//        remove
//        {
//            disconnected -= value;
//            Console.WriteLine($"{value?.Method.Name} removed...");
//        }
//    }

//    public void EmulateConnection()
//    {
//        //
//        //
//        Connected?.Invoke("connected");
//    }

//    public void EmulateDisconnection()
//    {
//        //
//        //
//        disconnected?.Invoke("disconnected");

//    }
//}







//// ---------------------------------------------------

//Server server = new Server();
//server.UserConnected += u => 
//{
//    Console.WriteLine($"User connected: {u.Id} {u.Email}");
//};


//User a = new User() { Id = 1, Email = "vasia@mail.com" };
//User b = new User() { Id = 2, Email = "petya@mail.com" };

//server.EmulateConnect(a);
//server.EmulateConnect(b);


//class User
//{
//    public int Id { get; set; }
//    public string Email { get; set; } = string.Empty;
//}

//class Server
//{
//    public event Action<User> UserConnected;

//    public List<User> Users { get; set; } = new List<User>();



//    public void EmulateConnect(User user)
//    {
//        Users.Add(user);
//        //
//        //

//        UserConnected?.Invoke(user);
//    }
//}









// ---------------------------------------------------

//Server server = new Server();

//server.UserConnected += (server, args) =>
//{
//    Console.WriteLine($"Connected: {args.User.Email}, Date: {args.Date.ToShortTimeString()}");
//};


//User a = new User() { Id = 1, Email = "vasia@mail.com" };
//User b = new User() { Id = 2, Email = "petya@mail.com" };

//server.EmulateConnect(a);
//server.EmulateConnect(b);


//class User
//{
//    public int Id { get; set; }
//    public string Email { get; set; } = string.Empty;
//}

//class ServerEventArgs
//{
//    public User User { get; set; }
//    public DateTime Date { get; set; }

//    public ServerEventArgs(User user, DateTime date)
//    {
//        User = user;
//        Date = date;
//    }
//}

//class Server
//{
//    public event Action<Server, ServerEventArgs> UserConnected;

//    public List<User> Users { get; set; } = new List<User>();



//    public void EmulateConnect(User user)
//    {
//        Users.Add(user);
//        //
//        //

//        UserConnected?.Invoke(this, new ServerEventArgs(user, DateTime.Now));
//    }
//}






// ---------------------------------------------------
// Создать класс Account
// Предусмотреть 2 события OnAdded, OnWithdrawen
// Предусмотреть передачу в обработчик данных о дате, пользователе и сумме операции




User a = new User() { Id = 1, Email = "vasia@mail.com" };
User b = new User() { Id = 2, Email = "petya@mail.com" };

Account accA = new Account(a, 1000);
accA.OnAdded += (acc, args) => 
{
    Console.WriteLine($"added --> {args.Date.ToLongTimeString()}: {args.User.Email}, acc: {acc.Id}, sum: {args.Sum}");
};
accA.OnAdded += SendEmail;
accA.OnWithdrawen += (acc, args) =>
{
    Console.WriteLine($"withdrawen --> {args.Date.ToLongTimeString()}: {args.User.Email}, acc: {acc.Id}, sum: {args.Sum}");
};
accA.OnError += SendSms;

void SendEmail(Account acc, AccountEventArgs args)
{
    Console.WriteLine($"EMAIL: added --> {args.Date.ToLongTimeString()}: {args.User.Email}, acc: {acc.Id}, sum: {args.Sum}");
}
void SendSms(Account acc, AccountEventArgs args)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"SMS: error --> sum = {args.Sum}");
    Console.ResetColor();
}



try
{
    accA.Add(300);
    accA.Withdraw(1000);
    accA.Withdraw(500);

}
catch (AccountException ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");

}



class AccountException : Exception
{
    public AccountException(string message) 
        : base(message)
    { }
}
class User
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
}

class AccountEventArgs
{
    public DateTime Date { get; set; }
    public User User { get; set; }
    public int Sum { get; set; }
    public AccountEventArgs(DateTime date, User user, int sum)
    {
        Date = date;
        User = user;
        Sum = sum;
    }
}

class Account
{
    public event Action<Account, AccountEventArgs>? OnAdded;
    public event Action<Account, AccountEventArgs>? OnWithdrawen;
    public event Action<Account, AccountEventArgs>? OnError;
    public string Id { get; set; }
    public User User { get; set; }
    public int Sum { get; set; }

    public Account(User user, int sum)
    {
        Id = Guid.NewGuid().ToString();
        User = user;
        Sum = sum;
    }

    public void Add(int sum)
    {
        Sum += sum;

        OnAdded?.Invoke(this, new AccountEventArgs(DateTime.Now, User, sum));
    }

    public void Withdraw(int sum)
    {
        if (sum > Sum)
        {
            OnError?.Invoke(this, new AccountEventArgs(DateTime.Now, User, sum));

            throw new AccountException($"Invalid requested sum: {sum}");
        }
            

        Sum -= sum;

        OnWithdrawen?.Invoke(this, new AccountEventArgs(DateTime.Now, User, sum));
    }
}





#endregion








