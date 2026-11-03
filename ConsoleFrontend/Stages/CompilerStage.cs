using CompilerBackend;

namespace ConsoleFrontend.Stages;

#pragma warning disable CA1515
public sealed class CompilerStage
{

    private readonly ICompiler _compiler;
    public CompilerStage( ICompiler compiler )
    {
        _compiler = compiler;
    }

    public string Run(string input)
    {
        return _compiler.Compile(input);
    }
}
