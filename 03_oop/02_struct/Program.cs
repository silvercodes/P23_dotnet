


//Point a = new Point(3, 4);
//a.Show();
//User b = new User(23);

//Point c = new Point();
//c.Show();

//Point d = new Point()
//{ 
//    y = -1000,
//};


Point a = new Point();
Point b;
b = a;

Point c = a with { y = 17 };




struct Point
{
    public int x = 1000;
    public int y = 1000;

    public Point()
    { }

    //public Point()
    //{
    //    x = 1;
    //    y = 1;
    //}

    //public Point(int x, int y)
    //{
    //    this.x = x;
    //    this.y = y;
    //}

    public void Show()
    {
        Console.WriteLine($"Point: {x};{y}");
    }
}

struct User(int id)
{ }

