

//Console.Write("Enter first number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second number: ");
//int b = Convert.ToInt32(Console.ReadLine());

//int result = a / b;
//Console.WriteLine($"Result: {result}");

////if (b == 0)
////    Console.WriteLine("Invalid value b");
////else
////{
////    int result = a / b;
////    Console.WriteLine($"Result: {result}");
////}




// =========== try / catch / finally

//Console.Write("Enter first number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second number: ");
//int b = Convert.ToInt32(Console.ReadLine());

//try                 // блок, в котором потенциально возможно появление исключения
//{
//	int result = a / b;
//	Console.WriteLine($"Result: {result}");
//}
//catch (Exception ex)        // блок обработки исключения
//{

//    Console.WriteLine($"ERROR: {ex.Message}");
//}
//finally             // блок, который выполняется всегда
//{
//    Console.WriteLine("finally block");
//}

//Console.WriteLine("End of Main()");







// DivideByZeroException

// IndexOutOfRangeException

// NullReferenceException

// ArgumentException

// InvalidCastException





//int a = 4;
//int b = 0;
//int c = 0;


//try
//{
//	c = a / b;
//    Console.WriteLine($"Result: {c}");
//}
////catch (Exception ex)
////{
////    Console.WriteLine("HOHOHO Exception");

////}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Message: {ex.Message}");
//    Console.WriteLine($"StackTrace:\n {ex.StackTrace}");
//    Console.WriteLine($"Source: {ex.Source}");
//    Console.WriteLine($"TargetSite: {ex.TargetSite}");
//    Console.WriteLine($"InnerException: {ex.InnerException}");
//    Console.WriteLine($"Help link: {ex.HelpLink}");
//}

//Console.WriteLine("End of Main()");






//void F4()
//{
//    int a = 0;
//    int result = 4 / a;
//    Console.WriteLine("End of F4()");
//}

//void F3()
//{
//    F4();
//    Console.WriteLine("End of F3()");
//}
//void F2()
//{
//    F3();
//    Console.WriteLine("End of F2()");
//}
//void F1()
//{
//    F2();
//    Console.WriteLine("End of F1()");
//}


//try
//{
//    F1();
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Message: {ex.Message}");
//    Console.WriteLine($"StackTrace:\n {ex.StackTrace}");
//    Console.WriteLine($"Source: {ex.Source}");
//    Console.WriteLine($"TargetSite: {ex.TargetSite}");
//    Console.WriteLine($"InnerException: {ex.InnerException}");
//    Console.WriteLine($"Help link: {ex.HelpLink}");
//}


//Console.WriteLine("End of Main()");









//try
//{
//    Console.Write("Enter your nickname: ");
//    string? nickname = Console.ReadLine();

//    if (nickname is null || nickname.Length < 5)
//    {
//        throw new Exception("Invalid nickname length")
//        {
//            HelpLink = @"https://google.com",
//        };
//    }


//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Message: {ex.Message}");
//    Console.WriteLine($"StackTrace:\n {ex.StackTrace}");
//    Console.WriteLine($"Source: {ex.Source}");
//    Console.WriteLine($"TargetSite: {ex.TargetSite}");
//    Console.WriteLine($"InnerException: {ex.InnerException}");
//    Console.WriteLine($"Help link: {ex.HelpLink}");

//}









//Account acc = new Account(1000);
////
////
//try
//{
//    acc.Withdraw(2000);
//}
//catch (AccountException ex)
//{
//    Console.WriteLine($"System error: {ex.Message}, your sum is {ex.Sum}");
//}
//catch (AppException ex)
//{
//    Console.WriteLine($"ERROR: {ex.Message}");
//}
//catch (Exception)
//{
//    Console.WriteLine("Internal server error");
//}





//class AppException: Exception
//{
//    public AppException(string? message) :
//        base(message)
//    { }
//}

//class AccountException : AppException
//{
//    public int Sum { get; set; }
//    public AccountException(string? message, int sum) : base(message)
//    {
//        Sum = sum;
//    }
//}


//class Account
//{
//    public int Balance { get; set; }
//    public Account(int sum) => Balance = sum;
//    public void Withdraw(int sum)
//    {
//        if (Balance < sum)
//            throw new AccountException("Sum is unvailable!", sum);

//        Balance -= sum;

//        Console.WriteLine("All OK!");

//    }



//}







// ====== example with lib ======



using DbDriver;
using DbDriver.Exceptions;

try
{
	ConnectionManager manager = new ConnectionManager();
	manager.Connect();
}
catch (DbDriverException ex)
{
    Console.WriteLine($"CATCH IN MAIN(): {ex.Message}");
}

