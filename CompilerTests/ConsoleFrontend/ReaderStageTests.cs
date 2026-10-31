using System;
using System.IO;
using CompilerTests.Utils;
using ConsoleFrontend.Stages;

namespace CompilerTests.ConsoleFrontend;

public class ReaderStageTests : IDisposable
{
    private TempDirectory _tempDir;

    public ReaderStageTests()
    {
        _tempDir = new TempDirectory();
    }
    
    public void Dispose()
    {
        _tempDir?.Dispose();
    }

    [Fact]
    public void Run_Returns_File_Contents()
    {
        // Arrange
        var filePath = Path.Combine(_tempDir.TempPath, "test.txt");
        File.WriteAllText(filePath, "FileContents");
        ReaderStage reader = new() { FilePath = filePath };
        Console.WriteLine($"FilePath: {filePath}");

        // Act
        var result = reader.Run();

        // Assert
        Assert.Equal("FileContents", result);

    }
}
