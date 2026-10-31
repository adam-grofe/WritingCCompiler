using System.Collections.Generic;

namespace CompilerBackend.Lexer;

public interface ILexer
{
    List<string> Tokenize(string sourceCode);
}
