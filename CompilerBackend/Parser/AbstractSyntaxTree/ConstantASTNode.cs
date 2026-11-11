
namespace CompilerBackend.Parser.AbstractSyntaxTree;

public class ConstantASTNode : IExpressionASTNode
{
    public int Value { get; }
    public string Type => "Constant";
}
