using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;
public class SemicolonToken : TokenBase
{
    private static readonly Regex _semicolonRegex = new Regex(@"^;");

    public SemicolonToken(string input)
    : base(_semicolonRegex, input)
    {
    }
}
