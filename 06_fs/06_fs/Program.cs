
#region manipulations

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



#endregion


#region read/write
//using System.Text;

//string path = @"test.txt";
//string content = "Vasia hello";



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
#endregion


#region MyTextWriter

//using System.Text;


//string data = "vasia@mail.com";
//string path = "data.mtw";

//MyTextWriter writer = new MyTextWriter(path);
//writer.Write(data);

//class MyTextWriter
//{
//    public string Path { get; set; }
//    public FileMode FileMode { get; set; } = FileMode.OpenOrCreate;
//    private FileAccess FileAccess { get; set; } = FileAccess.Write;
//    public MyTextWriter(string path)
//    {
//        Path = path;
//    }

//    public void Write(string content)
//    {        
//        using FileStream fs = new FileStream(Path, FileMode, FileAccess);

//        byte[] bytes = Encoding.UTF8.GetBytes(content);

//        fs.Write(bytes, 0, bytes.Length);
//    }
//}

#endregion


#region StreamReader / StreamWriter (для работы с текстом)

//const string path = @"sw.txt";
//string content = "Content from Application";

////using StreamWriter sw = new StreamWriter(path);
////sw.WriteLine(content);

//using StreamReader sr = new StreamReader(path);
//string data = sr.ReadToEnd();
//Console.WriteLine(data);

#endregion


#region BinaryReader / BinaryWriter

//string path = "bw.dat";
//using BinaryWriter bw = new BinaryWriter(File.OpenWrite(path));
//bw.Write("Petya hello");
//bw.Write(99);


//List<Unit> units = new List<Unit>()
//{
//    new Unit() {Id = 101, Title = "Archer"},
//    new Unit() {Id = 102, Title = "Warrior"},
//    new Unit() {Id = 107, Title = "Dragon"},
//};

//string path = "units.bin";
//using BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
//foreach (Unit u in units)
//{
//    bw.Write(u.Id);
//    bw.Write(u.Title);
//}



//string path = "units.bin";
//using BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
//List<Unit> units = new List<Unit>();
//while(br.PeekChar() > -1)
//{
//    Unit u = new Unit()
//    {
//        Id = br.ReadInt32(),
//        Title = br.ReadString(),
//    };

//    units.Add(u);
//}

//foreach(Unit u in units)
//    Console.WriteLine(u);


//class Unit
//{
//    public int Id { get; set; }
//    public string Title { get; set; }
//    public override string ToString()
//    {
//        return $"id: {Id}, title: {Title}";
//    }
//}


#endregion


#region JSON

//using System.Text.Json;

//Unit unit = new Unit() { Id = 150, Title = "Warrior" };

//string json = JsonSerializer.Serialize<Unit>(unit);
//Console.WriteLine(json);

//Unit? desUnit = JsonSerializer.Deserialize<Unit>(json);
//if (desUnit is not null)
//    Console.WriteLine(desUnit);


//using FileStream fs = new FileStream("unit.json", FileMode.OpenOrCreate);
//JsonSerializer.Serialize<Unit>(fs, unit, new JsonSerializerOptions()
//{
//    WriteIndented = true,
//});

////Unit? u = JsonSerializer.Deserialize<Unit>(fs);
////Console.WriteLine(u);



//class Unit
//{
//    public int Id { get; set; }
//    public string Title { get; set; }
//    public override string ToString()
//    {
//        return $"id: {Id}, title: {Title}";
//    }
//}








using System.Text.Json;

//List<User> users = new List<User>() 
//{ 
//    new User() { Id = 101, Name = "Vasia", Role = new Role() {Id = 1, Title = "admin"}},
//    new User() { Id = 102, Name = "Petya", Role = new Role() {Id = 2, Title = "guest"}},
//    new User() { Id = 103, Name = "Dima", Role = new Role() {Id = 2, Title = "guest"}},
//    new User() { Id = 104, Name = "Vasia", Role = new Role() {Id = 3, Title = "author"}},
//};

//using FileStream fs = new FileStream("users.json", FileMode.OpenOrCreate);
//JsonSerializer.Serialize(fs, users, new JsonSerializerOptions()
//{
//    WriteIndented = true
//});


//using FileStream fs = new FileStream("users.json", FileMode.Open);
//List<User>? users = JsonSerializer.Deserialize<List<User>>(fs);
//users?.ForEach(u => Console.WriteLine(u));

//class Role
//{
//    public int Id { get; set; }
//    public string Title { get; set; }
//}

//class User
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public Role Role { get; set; }
//    public override string ToString()
//    {
//        return $"{Id} {Name} {Role.Title}";
//    }
//}

#endregion


