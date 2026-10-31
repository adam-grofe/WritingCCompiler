using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;
public class CloseBraceToken : TokenBase
{
    private static readonly Regex _closedBraceRegex = new Regex(@"^\}");

    public CloseBraceToken(string input)
    : base(_closedBraceRegex, input)
    {
    }
}
