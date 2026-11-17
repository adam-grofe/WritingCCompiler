using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;

public class SemicolonToken : TokenBase
{
    private static readonly Regex _semicolonRegex = new Regex(@"^;");

    public SemicolonToken(string input, int lineNumber)
    : base(_semicolonRegex, input, lineNumber)
    {
    }
}
