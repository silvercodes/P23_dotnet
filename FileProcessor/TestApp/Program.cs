

using FileProcessor;
using FileProcessor.Renaming;

const string rootPath = @"C:\Users\silver\Desktop\data";
// const string rootPath = @"C:\Users\silver\Desktop\data_pro";

string[] fileMasks =
{
    "*.jpg",
    // "*.png",
};

string[] dirMasks =
{
    //".vs",
    //"bin",
    //"obj",
    "*_bin",
    "bin",
};

Scaner scaner = new Scaner();

scaner.FileMasks = fileMasks;
scaner.DirMasks = dirMasks;

scaner.FindFiles(rootPath);
// finder.FindDirectories(rootPath);
// scaner.FindAll(rootPath);


Renamer renamer = new Renamer(scaner.Container);
renamer.RenameFiles(@"img_vasia_<uuid>");







