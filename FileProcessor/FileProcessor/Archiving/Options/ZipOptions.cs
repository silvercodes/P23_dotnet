using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archiving.Options;

public class ZipOptions: IOptions
{
    public CompressionLevel CompressionLevel { get; set; } = CompressionLevel.SmallestSize;
    public bool IncludeParentDirectory { get; set; } = false;
}
