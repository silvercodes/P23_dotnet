

#region Intro
////[modifier] return_type Title([parameters])
////{

////}

//// Полная форма
//int Add(int a, int b)
//{
//    return a + b;
//}

//// Сокращенная форма (для 1 стейтмента)
//int Add2(int a, int b) => a + b;

//// Полная форма
//void ShowMessage(string message)
//{
//    Console.WriteLine($"message: {message}");
//}

//// Сокращенная форма (для 1 стейтмента)
//void ShowMessage2(string message) => Console.WriteLine($"message: {message}");


//int result = Add(34, 56);
//ShowMessage("Vasia");
//ShowMessage2("Petya"); 
#endregion


#region Parameters

//// Обязательные параметры
//void Render(string message, int count)
//{
//    for (int i = 0; i < count; i++)
//        Console.WriteLine(message);
//}

//// Render(12, "Vasia");        // ERROR
//Render("Vasia", 5);


//// Необязательные параметры
//void Render2(string message, int count = 5)
//{
//    for (int i = 0; i < count; i++)
//        Console.WriteLine(message);
//}

//Render2("Petya");


//// Именованные параметры
//void Render3(string message = "no_message", int count = 5, ConsoleColor color = ConsoleColor.Red)
//{
//    Console.ForegroundColor = color;
//    for (int i = 0; i < count; i++)
//        Console.WriteLine(message);
//    Console.ResetColor();
//}

//// Render3("no_message", 5, ConsoleColor.Blue);
//Render3("vasia@mail.com", color: ConsoleColor.Green);



// ======== по-значению / по-ссылке

// ---- 1. по-значению
//void RenderDouble1(int n)            // int n = 10;
//{
//    n = n * 2;
//    Console.WriteLine($"Result: {n}");
//}

//int val = 10;
//RenderDouble1(val);
//Console.WriteLine($"After call: {val}");


// ---- 2. по-ссылке (ref)
//void RenderDouble2(ref int n)            
//{
//    n = n * 2;
//    Console.WriteLine($"Result: {n}");
//}

//int val = 10;
//RenderDouble2(ref val);
//Console.WriteLine($"After call: {val}");


// ---- 2.1 выходной параметр (out)
//void CalcArea(int w, int h, out int area)
//{
//    area = w * h;
//}

//int area;
//CalcArea(12, 9, out area);
//Console.WriteLine(area);



// ---- 2.2 входной параметр (in)
//void RenderArea(in int w, in int h)
//{
//    // w = 1;       // ERROR

//    int area = w * h;

//    Console.WriteLine($"Area: {area}");
//}


// ---- Общий пример
//bool calcRectangle(in int w, in int h, out int area, out int perimieter)
//{
//    // w = 45;      // ERROR
//    // h = 12;      // ERROR

//    area = w * h;
//    perimieter = 2 * (w + h);

//    return true;
//}

//// классический вызов
////int w = 10;
////int h = 12;
////int area;
////int perimeter;

////bool result = calcRectangle(in w, in h, out area, out perimeter);


//// новый синтаксис
//int w = 10;
//int h = 12;

//bool result = calcRectangle(w, h, out int area, out int perimeter);
//Console.WriteLine($"{w} {h} {area} {perimeter}");


// ---- 2.3 readonly ref (FROM C#12)
void renderDouble(ref readonly int n)
{
    // n = 56;  // ERROR

    Console.WriteLine(n * 2);
}

int val = 12;
renderDouble(ref val);


#endregion









