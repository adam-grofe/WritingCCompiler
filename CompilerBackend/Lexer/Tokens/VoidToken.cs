using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;
public class VoidToken : TokenBase
{
    private static readonly Regex _voidRegex = new Regex(@"^void\b");

    public VoidToken(string input)
    : base(_voidRegex, input)
    {
    }
}
