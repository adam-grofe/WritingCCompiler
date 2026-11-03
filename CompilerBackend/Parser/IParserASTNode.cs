using System.Collections.Generic;

namespace CompilerBackend.Parser;

public interface IParserASTNode
{
    public string Type { get; }
    public IParserASTNode? Parent { get; }
    public IList<IParserASTNode> Children { get; }
}
