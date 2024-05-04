#include <iostream>

#pragma region Contructor

//class Point
//{
//private:
//	int x;
//	int y;
//
//public:
//	Point()		// конструктор по-умолчанию (без параметров)
//	{
//		std::cout << "call Point()\n";
//		x = 1;
//		y = -1;
//	}
//	void setInitialState(int newX, int newY)
//	{
//		x = newX;
//		y = newY;
//	}
//	void show()
//	{
//		std::cout << "x:" << x << " y:" << y << '\n';
//	}
//};
//
//int main()
//{
//	/*Point p;
//	p.setInitialState(3, 4);
//
//	int a;
//	int b{ 4 };*/
//
//	Point p;
//	p.show();
//}



//class Point
//{
//private:
//	int x;
//	int y;
//
//public:
//	Point(int initX, int initY)
//	{
//		x = initX;
//		y = initY;
//	}
//	void setInitialState(int newX, int newY)
//	{
//		x = newX;
//		y = newY;
//	}
//	void show()
//	{
//		std::cout << "x:" << x << " y:" << y << '\n';
//	}
//};
//
//int main()
//{
//	Point a(12, 13);		// :-(
//	Point b{ 7, 4 };		// :-)
//
//	b.show();
//
//}




//class Point
//{
//private:
//	int x;
//	int y;
//
//public:
//	Point(int initX, int initY)
//	{
//		x = initX < 0 ? 0 : initX;
//		y = initY < 0 ? 0 : initY;
//	}
//	void setInitialState(int newX, int newY)
//	{
//		x = newX;
//		y = newY;
//	}
//	void show()
//	{
//		std::cout << "x:" << x << " y:" << y << '\n';
//	}
//};
//
//int main()
//{
//	Point a(12, 13);		// :-(
//	Point b{ 7, 4 };		// :-)
//
//	b.show();
//
//	Point c{ -3, 5 };
//	c.show();
//
//	Point* ptr = new Point{ 4, 5 };
//
//}
#pragma endregion


#pragma region Class in class  !!!***!!!

//class Group
//{
//private:
//	std::string title;							// <10> (инициализация)
//
//public:
//	Group()										// <9> (находим соответствующий конструктор)
//	{
//		std::cout << "ctor Group()\n";					// <11> (выполнение тела конструктора)
//	}
//};
//
//class Role
//{
//private:
//	std::string title;		// <5> (инициализация)
//
//public:
//	Role()					// <4> (находим соответствующий конструктор)
//	{
//		std::cout << "ctor Role()\n";	// <6> (выполнение тела конструктора)
//	}
//};
//
//class User
//{
//private:
//	Role role;				// <3> (попытка инициализации)
//	int age;							// <7> (попытка инициализации ==> оставить без инициализации)
//	Group group;								// <8> (попытка инициализации)
//
//public:
//	User()					// <2> (находим соответствующий конструктор)
//	{
//		std::cout << "ctor User()\n";						// <12> (выполнение тела конструктора)
//	}
//};
//
//int main()
//{
//	User a;					// <1> (объявляем переменную (создаем объект))
//}

#pragma endregion


#pragma region Task_1
// Создать класс Circle
// Поля: координаты центра, радиус, цвет
// Методы: show();
// Оптимизируйте кол-во конструкторов
// Создать массив указателей на окружности со случайными значениями и вывести на экран каждую окружность (show())

enum Color
{
	RED,
	GREEN,
	WHITE,
};

class Point
{
private:
	int x;
	int y;

public:
	Point(int newX = 0, int newY = 0)
	{
		x = newX;
		y = newY;
	}
	// TODO:...
};

class Circle
{
private:
	Point position;			// Point{0, 0} после создания
	int radius;				// мусор после создания
	Color color;			// мусор после создания

public:
	Circle(const Point& p = {1, 1}, int r = 1, Color c = Color::RED)
	{
		position = p;
		radius = r;
		color = c;
	}
};


int main()
{
	Point p{ 1, 2 };

	Circle a{};
	Circle b{ p };
	Circle c{ p, 12 };
	Circle d{ p, 12, Color::WHITE };



}




#pragma endregion









