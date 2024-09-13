

// === File / FileInfo


// FileInfo file = new FileInfo(@"test.txt");
// file.Create();


//FileInfo file = new FileInfo(@"test.txt");
//if (file.Exists)
//{
//    Console.WriteLine($"name: {file.Name} creation date: {file.CreationTime} size: {file.Length} bytes");
//}



//string path = @"logs.txt";

// File.WriteAllText(path, "Hello Vasia", System.Text.Encoding.UTF8);

// File.AppendAllText(path, "\nHello Petya", System.Text.Encoding.UTF8);

//string content = File.ReadAllText(path);
//Console.WriteLine(content);




// === Directory / DirectoryInfo


// string path = @"C:\Users\silver\Desktop\images";

//if (Directory.Exists(path))
//{
//    string[] files =  Directory.GetFiles(path);

//    Console.WriteLine("Files:");
//    foreach(string file in files)
//    {
//        Console.WriteLine(file);
//    }
//    Console.WriteLine("\n\n");


//    string[] dirs =  Directory.GetDirectories(path);
//    Console.WriteLine("Directories:");
//    foreach (string dir in dirs)
//    {
//        Console.WriteLine(dir);
//    }

//}


// Directory.CreateDirectory(Path.Combine(path, "newDIR"));

// Directory.Delete(Path.Combine(path, "newDIR"), true);



// === Discs

//foreach(DriveInfo di in DriveInfo.GetDrives())
//{
//    Console.WriteLine(di.Name);
//    Console.WriteLine(di.TotalSize);
//    Console.WriteLine(di.DriveType);
//}






// === FileStream



// FileStream fs = new FileStream()

// FileStream fs =  File.Open()


//string path = @"test.txt";

//FileStream fs = File.Open(path, FileMode.CreateNew);
////
////
//fs.Close();





using System.Text;

string path = @"test.txt";
string content = "Vasia hello";



// === WRITING
// using FileStream fs = new FileStream(path, FileMode.Append);

//byte[] bytes = Encoding.UTF8.GetBytes(content);

//fs.Write(bytes, 0, bytes.Length);

// fs.WriteByte(99);






// ==== READING
//using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

//byte[] buffer = new byte[fs.Length];
//fs.Read(buffer, 0, buffer.Length);

//string str = Encoding.UTF8.GetString(buffer);
//Console.WriteLine(str);




//using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

//fs.Seek(3, SeekOrigin.Begin);

//byte[] buffer = new byte[fs.Length];
//fs.Read(buffer, 0, buffer.Length);

//string str = Encoding.UTF8.GetString(buffer);
//Console.WriteLine(str);







