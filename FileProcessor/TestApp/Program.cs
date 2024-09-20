

using FileProcessor;

const string rootPath = @"C:\Users\silver\Desktop\data";
// const string rootPath = @"C:\Users\silver\Desktop\data_pro";

string[] fileMasks =
{
    // "*.jpg",
    "*.png",
};

string[] dirMasks =
{
    //".vs",
    //"bin",
    //"obj",
    "*_bin",
    "bin",
};

Finder finder = new Finder();

finder.FileMasks = fileMasks;
finder.DirMasks = dirMasks;

// finder.FindFiles(rootPath);
//finder.FindDirectories(rootPath);
finder.FindAll(rootPath);


Console.WriteLine();