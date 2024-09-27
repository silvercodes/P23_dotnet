

using FileProcessor;
using FileProcessor.Renaming;
using FileProcessor.Renaming.Generation;
using FileProcessor.Reporting;

const string rootPath = @"C:\Users\silver\Desktop\data";
// const string rootPath = @"C:\Users\silver\Desktop\data_pro";

string[] fileMasks =
{
    // "*.jpg",
    // "*.png",
    "*.txt"
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
renamer.AddRuleHanndler("constant", new ConstantRuleHandler());

Report<FileInfo> report = renamer.RenameFiles(@"img_<increment(1,1)>_<constant(vasia)>_<old_name>");

Console.WriteLine();

class ConstantRuleHandler : IRuleHandler, IWithOptions
{
    private string cVal = string.Empty;
    public string OptionsString 
    { 
        get
        {
            return this.cVal;
        }
        set
        {
            this.cVal = value;
        }
    }

    public string GetValue(FileInfo? file = null)
    {
        return cVal;
    }
}







