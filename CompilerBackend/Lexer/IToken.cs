namespace CompilerBackend.Lexer;

public interface IToken
{
    bool IsMatch();
    int Length { get; }

    string TokenString();
}
