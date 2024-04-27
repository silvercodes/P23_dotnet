


#region vars
//int a;

//int _b;

//// int 3c;     // ERROR

//int d = 45;
//d = 34;


// const int a = 23;
// a = 45;             // ERROR 
#endregion

#region Types

//// ======= значимые типы =========
//// bool 
//bool a = true;

//// byte (0 - 255)
//byte b = 45;

//// sbyte (-128 - 127)
//sbyte c = -45;

//// short (-32768 - 32767)
//short d = -10000;

//// ushort (0 - 65535)
//ushort e = 32000;

//// int
//int f = -100000;

//// uint
//uint g = 200000;

//// long
//long h = -98763746;

//// ulong
//ulong i = 98763746;

//// float
//float j = 45.87f;

//// double
//double k = 45.87;

//// decimal
//decimal l = 34.98734874982364987m;

//// char (Unicode)
//char m = 'B';
//char n = 'ต';
//char o = '\u0E18';


//// ======= ссылочные типы =========

//// string
//string p = "Hello, Vasia! Привет! ต";
//Console.WriteLine(p);

//// object
//object q = 45;
//object r = "Petya";
//object s = true;


//// ======= неявная (оттложенная) типизация =========

//var x = 56;
//var y = "Vasia";
//var z = true;

//// var t;          // ERROR
//// var w = null;   // ERROR



#endregion

#region Literals

bool a = true; // false

int b = 5;
int c = 0b0101001001;
int d = 0xFF;

double e = 4.5;
double f = -0.00001;
double g = 2.1e3;           // 2.1 * 10^3
double h = 3.2e-28;

char j = 'x';
// char k = 45; // ERROR
char l = '\n'; // \t\b\0...
char m = '\x90';

// string n = "hello Vasia";
string n = "hello \"Vasia\"";
string o = "hello \"Vasia\"";

string email = "vasia@mail.com";
int age = 34;
string p = $"email: {email} age: {age}";
Console.WriteLine(p);






#endregion








