
namespace ConsoleFrontend.Stages;

public class ReaderStage
{
    public required string FilePath { get; set; }

    public string Run()
    {
        var content = File.ReadAllText(FilePath);
        return content;
    }
}
