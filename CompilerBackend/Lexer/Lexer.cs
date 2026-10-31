using System.Collections.Generic;
using CompilerBackend.Lexer.Tokens;

namespace CompilerBackend.Lexer;

static public class Lexer
{

    static public List<string> Tokenize(string sourceCode)
    {
        var tokens = new List<string>();
        while(!string.IsNullOrEmpty(sourceCode))
        {
            sourceCode = sourceCode.TrimStart();
            var token = GetNextToken(sourceCode);
            tokens.Add(token.TokenString());
            sourceCode = sourceCode.Substring(token.Length()).TrimStart();
        }
        return tokens;
    }

    static private IToken GetNextToken(string sourceCode)
    {
        var supportedTokens = SupportedTokensFactory.GetSupportedTokens();
        IToken? longestToken = null;
        foreach (var tokenFactory in supportedTokens)
        {
            var token = tokenFactory(sourceCode);
            if (token.IsMatch())
            {
                if (longestToken == null || token.Length() > longestToken.Length())
                {
                    longestToken = token;
                }
            }
        }
        if (longestToken != null)
        {
            return longestToken;
        }
        throw new System.Exception("No matching token found.");
    }
}
