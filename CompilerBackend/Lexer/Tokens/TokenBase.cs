using System;
using System.Text.RegularExpressions;

namespace CompilerBackend.Lexer.Tokens;

public class TokenBase : IToken
{
    private readonly string _matchedString;
    private readonly Regex _tokenRegex;
    private readonly int _lineNumber;

    public TokenBase(Regex tokenRegex, string input, int lineNumber)
    {
        ArgumentNullException.ThrowIfNull(tokenRegex);
        ArgumentNullException.ThrowIfNull(input);
        _lineNumber = lineNumber;

        _tokenRegex = tokenRegex;
        var match = _tokenRegex.Match(input.TrimStart());
        _matchedString = match.Success ? match.Value : string.Empty;
    }
    public bool IsMatch()
    {
        return !string.IsNullOrEmpty(_matchedString);
    }
    public int Length { get { return _matchedString.Length; } }
    public string TokenString { get { return _matchedString; } }
    public int LineNumber { get { return _lineNumber; } }
}
