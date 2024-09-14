using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor;

internal class RegexAnalizer
{
    private Dictionary<string, string> map = new Dictionary<string, string>()
    {
        {"*", ".*" },
        {"?", "." },
        {".", @"\." },
        {"^", @"\^" },
        {"}", @"\}" },
        {"{", @"\{" },
        {"[", @"\[" },
        {"]", @"\]" },
        {"(", @"\(" },
        {")", @"\)" },
        {"+", @"\+" },
    };

    public List<FileInfo> FilterFiles(FileInfo[] files, string[] masks)
    {
        List<FileInfo> result = new List<FileInfo>();




        return result;
    }
}
