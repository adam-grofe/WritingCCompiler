using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;

public class IdentifierToken : TokenBase
{
    private static readonly Regex _returnRegex = new Regex(@"^[a-zA-Z_]\w*\b");

    public IdentifierToken(string input, int lineNumber)
    : base(_returnRegex, input, lineNumber)
    {
    }
}
