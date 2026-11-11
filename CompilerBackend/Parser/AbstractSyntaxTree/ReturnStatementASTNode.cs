
namespace CompilerBackend.Parser.AbstractSyntaxTree;

public class ReturnStatementASTNode : IStatementASTNode
{
    public string Type => "Return";
    public IExpressionASTNode Expression { get; }

    ReturnStatementASTNode(IExpressionASTNode expression)
    {
        Expression = expression;
    }
}
