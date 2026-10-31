using System;
using System.IO;

namespace CompilerTests.Utils;

public class TempDirectory : IDisposable
{
    private string _path;
    public TempDirectory()
    {
        _path = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_path);
    }
    public string TempPath => _path;
    public void Dispose() => Directory.Delete(_path, true);
}
