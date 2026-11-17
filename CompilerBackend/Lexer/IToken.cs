namespace CompilerBackend.Lexer;

public interface IToken
{
    bool IsMatch();
    int Length { get; }
    int LineNumber { get; }

    string TokenString { get; }
}
