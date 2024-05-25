
// ==== Модификаторы доступа членов класса ====

// 1. private

// 2. protected                 (наследник)

// 3. public                    (все)

// 4. private protected         (наследник в текущей сборке)

//using _07_extra;

//class DbLogger: Logger
//{
//    public void Render() => Console.WriteLine(path);        // ERROR
//}

// 5. internal                 (всем внутри сборки, закрыто для внешних сборок) 
//                             понимать как private public

//using _07_extra;

//Logger logger = new Logger();
//Console.WriteLine(logger.level);        // ERROR

// 6. protected internal    (всем внутри сборки, наследник в другой сборке)

// 7. file




// ==== Модификаторы доступа для типа в целом ====
// 1. public
// 2. internal
// 3. file


