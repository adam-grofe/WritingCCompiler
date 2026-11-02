using CompilerBackend;

namespace ConsoleFrontend.Stages;

internal static class StageRunner
{
    static public void Run(string inputFilePath, string outputFilePath, ICompiler compiler)
    {
        var readerStage = new ReaderStage { FilePath = inputFilePath };
        var compilerStage = new CompilerStage(compiler);
        var assemblyWriterStage = new AssemblyWriterStage(outputFilePath);
        var inputCode = readerStage.Run();
        var assemblyCode = compilerStage.Run(inputCode);
        assemblyWriterStage.Run(assemblyCode);
    }
}
