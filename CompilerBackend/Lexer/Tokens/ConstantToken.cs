using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;
public class ConstantToken : TokenBase
{
    private static readonly Regex _constantRegex = new Regex(@"^\d+\b");

    public ConstantToken(string input)
    : base(_constantRegex, input)
    {
    }
}
