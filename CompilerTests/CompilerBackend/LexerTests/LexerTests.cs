using CompilerBackend.Lexer;

namespace CompilerTests.CompilerBackend.LexerTests;

public class LexerTests
{
    [Theory]
    [InlineData("return 0;", new string[] { "return", "0", ";" })]
    [InlineData("return 5;", new string[] { "return", "5", ";" })]
    [InlineData("return 12;", new string[] { "return", "12", ";" })]
    [InlineData("return 12 ;", new string[] { "return", "12", ";" })]
    [InlineData("\nreturn 12;", new string[] { "return", "12", ";" })]
    [InlineData("\treturn 12;", new string[] { "return", "12", ";" })]
    [InlineData("return\t12;", new string[] { "return", "12", ";" })]
    [InlineData("return 12\t;", new string[] { "return", "12", ";" })]
    public void ReturnStatement_TokenizesCorrectly(string sourceCode, string[] expectedTokens)
    {
        // Act
        var tokens = Lexer.Tokenize(sourceCode);

        // Assert
        Assert.Equal(expectedTokens, tokens);
    }

    [Theory]
    [InlineData("4myvar")]
    [InlineData("$myvar")]
    [InlineData("!myvar")]
    public void InvalidToken_ThrowsException(string input)
    {
        // Act & Assert
        Assert.Throws<System.Exception>(() => Lexer.Tokenize(input));
    }

    [Theory]
    [InlineData("void main() { return; }", new string[] { "void", "main", "(", ")", "{", "return", ";", "}" })]
    [InlineData("int main() { return 2; }", new string[] { "int", "main", "(", ")", "{", "return", "2", ";", "}" })]
    [InlineData("int main(void) { return 2; }", new string[] { "int", "main", "(", "void", ")", "{", "return", "2", ";", "}" })]
    [InlineData("int main( void ) { return 2; }", new string[] { "int", "main", "(", "void", ")", "{", "return", "2", ";", "}" })]
    [InlineData("int main(\tvoid\t) {\n\treturn 2; }", new string[] { "int", "main", "(", "void", ")", "{", "return", "2", ";", "}" })]
    public void MainFunction_TokenizesCorrectly(string sourceCode, string[] expectedTokens)
    {
        // Act
        var tokens = Lexer.Tokenize(sourceCode);
        // Assert
        Assert.Equal(expectedTokens, tokens);
    }
}
