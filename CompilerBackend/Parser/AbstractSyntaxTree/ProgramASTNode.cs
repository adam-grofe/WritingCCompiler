using System.Collections.Generic;

namespace CompilerBackend.Parser.AbstractSyntaxTree;

public class ProgramASTNode : IProgramASTNode
{
    public string Type => "Program";
    public IList<IFunctionDefinition> FunctionDefinitions { get; }

    public ProgramASTNode(IList<IFunctionDefinition> functionDefinitions)
    {
        FunctionDefinitions = functionDefinitions;
    }
}
