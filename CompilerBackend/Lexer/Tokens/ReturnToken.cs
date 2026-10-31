using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;

public class ReturnToken : TokenBase
{
    private static readonly Regex _returnRegex = new Regex(@"^return\b");

    public ReturnToken(string input)
    : base(_returnRegex, input)
    {
    }
}
