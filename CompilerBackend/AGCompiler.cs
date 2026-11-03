using System;

namespace CompilerBackend;

#pragma warning disable CA1515
public class AGCompiler: ICompiler
{

    public AGCompiler()
    {
    }

    public string Compile(string input)
    {
        ArgumentException.ThrowIfNullOrEmpty(input, nameof(input));

        // For demonstration purposes, let's just return the input in uppercase.
        return input;
    }

}
