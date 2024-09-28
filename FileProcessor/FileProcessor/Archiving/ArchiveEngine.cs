using FileProcessor.Archiving.Exceptions;
using FileProcessor.Archiving.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryNotFoundException = FileProcessor.Archiving.Exceptions.DirectoryNotFoundException;

namespace FileProcessor.Archiving;

public class ArchiveEngine
{
    private ICompressor compressor = null!;

    private IOptions? Options { get; set; } = null;

    public void SetOptions<T>(T options)
        where T : IOptions
    {
        Options = options;

        compressor.Options = Options;
    }
    private void SetCompressor(ArchiveEngineMode mode)
    {
        compressor = mode switch
        {
            ArchiveEngineMode.Zip => new ZipComprressor(),

            _ => throw new ArchiveEngineException(ArchiveEngineException.UNSUPPORTED_MODE),
        };

        if (Options is not null)
            compressor.Options = Options;
    }

    public ArchiveEngine(ArchiveEngineMode mode = ArchiveEngineMode.Zip)
    {
        SetCompressor(mode);
    }

    public void SetMode(ArchiveEngineMode mode = ArchiveEngineMode.Zip)
    {
        SetCompressor(mode);
    }


    public string CompressDirectory(string path, string? receiveDir = "", string archiveFileName = "")
    {
        if (!Directory.Exists(path))
            throw new DirectoryNotFoundException($"Directory {path} not found");

        path = Path.TrimEndingDirectorySeparator(path);

        if (string.IsNullOrEmpty(receiveDir))
        {
            receiveDir = Directory.GetParent(path)?.FullName;

            if (receiveDir is null)
                throw new ReceiveDirectoryNotAvailableException($"Directory {receiveDir} is not available");
        }

        archiveFileName = string.IsNullOrEmpty(archiveFileName) ? Path.GetFileName(path) : archiveFileName;

        return compressor.CompressDir(path, receiveDir, archiveFileName);
    }
}
