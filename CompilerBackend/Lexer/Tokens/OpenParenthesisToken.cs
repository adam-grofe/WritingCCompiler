using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;

public class OpenParenthesisToken : TokenBase
{
    private static readonly Regex _openParenthesisRegex = new Regex(@"^\(");

    public OpenParenthesisToken(string input, int lineNumber)
    : base(_openParenthesisRegex, input, lineNumber)
    {
    }
}
