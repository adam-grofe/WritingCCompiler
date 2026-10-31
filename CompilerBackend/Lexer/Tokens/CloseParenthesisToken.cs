using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;
public class CloseParenthesisToken : TokenBase
{
    private static readonly Regex _closedParenthesisRegex = new Regex(@"^\)");

    public CloseParenthesisToken(string input)
    : base(_closedParenthesisRegex, input)
    {
    }
}
