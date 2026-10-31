using System;

namespace CompilerBackend.Lexer.Tokens;

static class SupportedTokensFactory
{
    static Func<string, IToken>[] _supportedTokens = new Func<string, IToken>[]
    {
        input => new IdentifierToken(input),
        input => new ReturnToken(input),
        input => new ConstantToken(input),
        input => new IntToken(input),
        input => new VoidToken(input),
        input => new SemicolonToken(input),
        input => new OpenBraceToken(input),
        input => new CloseBraceToken(input),
        input => new OpenParenthesisToken(input),
        input => new CloseParenthesisToken(input),
    };

    static public Func<string, IToken>[] GetSupportedTokens()
    {
        return _supportedTokens;
    }
}
