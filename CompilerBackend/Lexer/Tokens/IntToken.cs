using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;

public class IntToken : TokenBase
{
    private static readonly Regex _intRegex = new Regex(@"^int\b");

    public IntToken(string input, int lineNumber)
    : base(_intRegex, input, lineNumber)
    {
    }
}
