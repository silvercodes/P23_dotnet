
// Значимые типы
// 1. Все целочисленные
// 2. Все типы с плавающей запятой
// 3. bool
// 4. char
// 5. enum
// 6. struct

// Ссылочные типы
// 1. Классы
// 2.       string
// 3.       object
// 4. Интерфейсы
// 5. Делегаты



//object a = 45;
//object b = new Unit();

//class Unit
//{
//    public void Render()
//    { }
//}





#region example 1

//void Func()
//{
//    Point a = new Point() { x = 2, y = 3 };
//    Unit b = new Unit() { x = 20, y = 30 };

//    Point c = a;
//    Unit d = b;
//}

//Func();

//struct Point
//{
//    public int x;
//    public int y;
//}

//class Unit
//{
//    public int x;
//    public int y;
//}
#endregion



#region example 2

//void Func()
//{
//    Role a = new Role();
//    User b = new User();

//    Role c = a;
//    User d = b;
//}

//Func();

//struct Role
//{
//    public string title;
//    public string slug;
//}

//class User
//{
//    public int id;
//    Role role;
//}

#endregion


#region example 3

//void Func()
//{
//Role a = new Role();
//User b = new User();

//Role c = a;
//User d = b;
//}

//Func();

//class Role
//{
//    public string title;
//    public string slug;
//}

//struct User
//{
//    public int id;
//    Role role;
//}

#endregion



#region example 4

//void Func()
//{
//    Data data = new Data()
//    {
//        payload = new Payload()
//        {
//            protocol = new Protocol(),
//        }
//    };

//    Data copy = data;
//}

//Func();

//class Protocol
//{
//    public string title;
//}
//class Payload
//{
//    public Protocol protocol;
//}
//struct Data
//{
//    public Payload payload;
//}

#endregion


#region practice

void Func1(Role role)
{

}

void Func2(ref Role role)
{

}

void Func3(User user)
{

}

void Func4(ref User user)
{

}

Role role = new Role();
User user = new User();

Func1(role);
Func2(ref role);
Func3(user);
Func4(ref user);


class Role
{
    
}

struct User
{
    
}

#endregion