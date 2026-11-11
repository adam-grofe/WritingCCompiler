using System.Collections.Generic;

namespace CompilerBackend.Parser.AbstractSyntaxTree;

public interface IFunctionDefinition
{
    public string Type { get; }
    public string Identifier { get; }
    public IList<IStatementASTNode> StatementBody { get; }
}
