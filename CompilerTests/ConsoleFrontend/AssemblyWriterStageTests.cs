using System;
using System.IO;
using CompilerTests.Utils;
using ConsoleFrontend.Stages;

namespace CompilerTests.ConsoleFrontend;

public class AssemblyWriterStageTests : IDisposable
{
    private TempDirectory _tempDir;

    public AssemblyWriterStageTests()
    {
        _tempDir = new TempDirectory();
    }

    [Fact]
    public void Run_WritesAssemblyCodeToFilePath()
    {
        // Arrange
        var assemblyCode = "test assembly code";
        var filePath = Path.Combine(_tempDir.TempPath, "test.txt");
        var stage = new AssemblyWriterStage(filePath);

        // Act
        stage.Run(assemblyCode);

        // Assert
        var writtenCode = File.ReadAllText(filePath);
        Assert.Equal(assemblyCode, writtenCode);
    }

    public void Dispose()
    {
        _tempDir.Dispose();
    }
}
