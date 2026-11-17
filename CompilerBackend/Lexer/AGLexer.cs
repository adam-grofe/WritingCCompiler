using CompilerBackend.Lexer.Tokens;
using System;
using System.Collections.Generic;
using System.Data;

namespace CompilerBackend.Lexer;

static public class AGLexer
{
    private static readonly string[] separator = new string[] { "\r\n", "\r", "\n" };

    static public IList<IToken> Tokenize(string sourceCode)
    {
        if (string.IsNullOrEmpty(sourceCode))
        {
            return new List<IToken>();
        }

        string[] lines = sourceCode.Split(separator, StringSplitOptions.None);
        var tokens = new List<IToken>();
        int lineNumber = 1;
        foreach (string line in lines)
        {
            string currentLine = line;
            while (!string.IsNullOrEmpty(currentLine))
            {
                currentLine = currentLine.TrimStart();
                var token = GetNextToken(currentLine, lineNumber);
                tokens.Add(token);
                currentLine = currentLine.Substring(token.Length).TrimStart();
            }
            lineNumber++;
        }
        return tokens;
    }

    static private IToken GetNextToken(string sourceCode, int lineNumber)
    {
        var supportedTokens = SupportedTokensFactory.GetSupportedTokens();
        IToken? longestToken = null;
        foreach (var tokenFactory in supportedTokens)
        {
            var token = tokenFactory(sourceCode, lineNumber);
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
