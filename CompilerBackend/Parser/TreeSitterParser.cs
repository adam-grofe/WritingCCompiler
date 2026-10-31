using TreeSitter;

namespace CompilerBackend.Parser;

public class TreeSitterParser
{
    private readonly TreeSitter.Parser _parser;

    TreeSitterParser()
    {
        var language = new Language("C");
        _parser = new TreeSitter.Parser(language);
    }

    public Node Parse(string sourceCode)
    {
        var tree = _parser.Parse(sourceCode);
        return tree.RootNode;
    }
}
