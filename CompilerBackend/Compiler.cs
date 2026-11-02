namespace CompilerBackend;

#pragma warning disable CA1515
public class Compiler: ICompiler
{

    public Compiler()
    {
    }

    public string Compile(string input)
    {
        // For demonstration purposes, let's just return the input in uppercase.
        return input.ToUpper();
    }

}
