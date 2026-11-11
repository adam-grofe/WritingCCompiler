using System.Collections.Generic;

namespace CompilerBackend.Parser.AbstractSyntaxTree;

public interface IProgramASTNode
{
    public string Type { get; }
    public IList<IFunctionDefinition> FunctionDefinitions { get; }
}
