using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;

public class ReturnToken : TokenBase
{
    private static readonly Regex _returnRegex = new Regex(@"^return\b");

    public ReturnToken(string input, int lineNumber)
    : base(_returnRegex, input, lineNumber)
    {
    }
}
