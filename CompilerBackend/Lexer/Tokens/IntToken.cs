using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;
public class IntToken : TokenBase
{
    private static readonly Regex _intRegex = new Regex(@"^int\b");

    public IntToken(string input)
    : base(_intRegex, input)
    {
    }
}
