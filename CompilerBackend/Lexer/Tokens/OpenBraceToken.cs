using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;
public class OpenBraceToken : TokenBase
{
    private static readonly Regex _openBraceRegex = new Regex(@"^\{");

    public OpenBraceToken(string input)
    : base(_openBraceRegex, input)
    {
    }
}
