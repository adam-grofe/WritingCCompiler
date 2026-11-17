using System;

namespace CompilerBackend.Lexer.Tokens;

static class SupportedTokensFactory
{
    static Func<string, int, IToken>[] _supportedTokens = new Func<string, int, IToken>[]
    {
        (input, lineNumber) => new IntToken(input, lineNumber),
        (input, lineNumber) => new ReturnToken(input, lineNumber),
        (input, lineNumber) => new VoidToken(input, lineNumber),
        (input, lineNumber) => new ConstantToken(input, lineNumber),
        (input, lineNumber) => new SemicolonToken(input, lineNumber),
        (input, lineNumber) => new OpenBraceToken(input, lineNumber),
        (input, lineNumber) => new CloseBraceToken(input, lineNumber),
        (input, lineNumber) => new OpenParenthesisToken(input, lineNumber),
        (input, lineNumber) => new CloseParenthesisToken(input, lineNumber),
        (input, lineNumber) => new IdentifierToken(input, lineNumber),
    };

    static public Func<string, int, IToken>[] GetSupportedTokens()
    {
        return _supportedTokens;
    }
}
