using System.IO;

namespace ConsoleFrontend.Stages;

#pragma warning disable CA1515
public sealed class AssemblyWriterStage
{
    private readonly string _filePath;

    public AssemblyWriterStage(string filePath)
    {
        _filePath = filePath;
    }

    public void Run(string assemblyCode)
    {
        File.WriteAllText(_filePath, assemblyCode);
    }
}
