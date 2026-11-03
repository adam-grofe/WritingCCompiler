using ConsoleFrontend.Stages;
using CompilerBackend;

namespace ConsoleFrontend;

sealed class Program
{
    static void Main(string[] args)
    {
        StageRunner.Run(args[0], args[1], new AGCompiler());
    }
}
