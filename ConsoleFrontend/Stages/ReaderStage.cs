using System.IO;

namespace ConsoleFrontend.Stages;

#pragma warning disable CA1515
public sealed class ReaderStage
{
    public required string FilePath { get; set; }

    public string Run()
    {
        var content = File.ReadAllText(FilePath);
        return content;
    }
}
