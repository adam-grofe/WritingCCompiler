using CompilerBackend.Lexer.Tokens;
using System.Collections.Generic;
using System.Data;

namespace CompilerBackend.Lexer;

static public class AGLexer
{

    static public IList<IToken> Tokenize(string sourceCode)
    {
        var tokens = new List<IToken>();
        while (!string.IsNullOrEmpty(sourceCode))
        {
            sourceCode = sourceCode.TrimStart();
            var token = GetNextToken(sourceCode);
            tokens.Add(token);
            sourceCode = sourceCode.Substring(token.Length).TrimStart();
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
                if (longestToken == null || token.Length > longestToken.Length)
                {
                    longestToken = token;
                }
            }
        }
        if (longestToken != null)
        {
            return longestToken;
        }
        throw new InvalidExpressionException("No matching token found.");
    }
}
