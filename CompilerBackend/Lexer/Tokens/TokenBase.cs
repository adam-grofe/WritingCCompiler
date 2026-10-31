using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;

public class TokenBase: IToken
{
    protected string _matchedString;
    Regex _tokenRegex;
    public TokenBase(Regex tokenRegex, string input)
    {
        _tokenRegex = tokenRegex;
        var match = _tokenRegex.Match(input.TrimStart());
        _matchedString = match.Success ? match.Value : string.Empty;
    }
    public bool IsMatch()
    {
        return !string.IsNullOrEmpty(_matchedString);
    }
    public int Length()
    {
        return _matchedString.Length;
    }
    public string TokenString()
    {
        return _matchedString;
    }
}
