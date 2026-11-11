using System.Collections.Generic;

namespace CompilerBackend.Parser.AbstractSyntaxTree;

public class FunctionDefinitionASTNode : IFunctionDefinition
{
    public string Type => "Function";
    public string Identifier { get; }
    public IList<IStatementASTNode> StatementBody { get; }

    public FunctionDefinitionASTNode(string identifier, IList<IStatementASTNode> statementBody)
    {
        Identifier = identifier;
        StatementBody = statementBody;
    }
}
