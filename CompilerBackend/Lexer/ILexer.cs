using System.Collections.Generic;

namespace CompilerBackend.Lexer;

public interface ILexer
{
    IList<string> Tokenize(string sourceCode);
}
