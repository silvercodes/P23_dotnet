using FileProcessor.Archiving.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archiving;

public interface ICompressor
{
    public IOptions Options { get; set; }
    public string CompressDir(string target, string receiveDir, string archiveFileName);

    public void DecompressDir();
}
