using System;
using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;

public class TokenBase : IToken
{
    private readonly string _matchedString;
    private readonly Regex _tokenRegex;
    public TokenBase(Regex tokenRegex, string input)
    {
        ArgumentNullException.ThrowIfNull(tokenRegex);
        ArgumentNullException.ThrowIfNull(input);

        _tokenRegex = tokenRegex;
        var match = _tokenRegex.Match(input.TrimStart());
        _matchedString = match.Success ? match.Value : string.Empty;
    }
    public bool IsMatch()
    {
        return !string.IsNullOrEmpty(_matchedString);
    }
    public int Length { get { return _matchedString.Length; } }
    public string TokenString()
    {
        return _matchedString;
    }
}
