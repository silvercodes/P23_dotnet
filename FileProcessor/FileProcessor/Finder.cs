using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor;

public class Finder
{
    private RegexAnalizer regexAnalizer;
    public string[] DirMasks { get; set; } = { };
    public string[] FileMasks { get; set; } = { };

    public Finder()
    {
        regexAnalizer = new RegexAnalizer();
    }


    public void FindDirectories()
    {

    }

    public void FindFiles()
    {

    }

    public void FindAll()
    {

    }
}
