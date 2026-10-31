using System.IO;

namespace ConsoleFrontend.Stages;
public class AssemblyWriterStage
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
