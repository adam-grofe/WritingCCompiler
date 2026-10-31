using CompilerBackend.Lexer.Tokens;

namespace CompilerTests.CompilerBackend.LexerTests;

public class TokenTests
{
    [Theory]
    [InlineData("return", "return")]
    [InlineData("return    ", "return")]
    [InlineData("    return", "return")]
    [InlineData("\treturn", "return")]
    [InlineData("return\t", "return")]
    [InlineData("\treturn\t", "return")]
    public void ReturnToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new ReturnToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }

    [Theory]
    [InlineData("0", "0")]
    [InlineData("1", "1")]
    [InlineData("12", "12")]
    [InlineData("123", "123")]
    [InlineData("0    ", "0")]
    [InlineData("1    ", "1")]
    [InlineData("12   ", "12")]
    [InlineData("123  ", "123")]
    [InlineData("    0    ", "0")]
    [InlineData("    1    ", "1")]
    [InlineData("    12   ", "12")]
    [InlineData("    123  ", "123")]
    [InlineData("  0", "0")]
    [InlineData("\t0", "0")]
    [InlineData("0\t", "0")]
    [InlineData("\t0\t", "0")]
    public void ConstantToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new ConstantToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }

    [Theory]
    [InlineData("int", "int")]
    [InlineData("int    ", "int")]
    [InlineData("    int", "int")]
    [InlineData("\tint", "int")]
    [InlineData("int\t", "int")]
    [InlineData("\tint\t", "int")]
    public void IntToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new IntToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }

    [Theory]
    [InlineData("void", "void")]
    [InlineData("void    ", "void")]
    [InlineData("    void", "void")]
    [InlineData("\tvoid", "void")]
    [InlineData("void\t", "void")]
    [InlineData("\tvoid\t", "void")]
    public void VoidToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new VoidToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }

    [Theory]
    [InlineData("(", "(")]
    [InlineData("(    ", "(")]
    [InlineData("    (", "(")]
    [InlineData("\t(", "(")]
    [InlineData("(\t", "(")]
    [InlineData("\t(\t", "(")]
    public void OpenParenthesisToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new OpenParenthesisToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }

    [Theory]
    [InlineData(")", ")")]
    [InlineData(")    ", ")")]
    [InlineData("    )", ")")]
    [InlineData("\t)", ")")]
    [InlineData(")\t", ")")]
    [InlineData("\t)\t", ")")]
    public void CloseParenthesisToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new CloseParenthesisToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }

    [Theory]
    [InlineData("}", "}")]
    [InlineData("}    ", "}")]
    [InlineData("    }", "}")]
    [InlineData("\t}", "}")]
    [InlineData("}\t", "}")]
    [InlineData("\t}\t", "}")]
    public void CloseBraceToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new CloseBraceToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }

    [Theory]
    [InlineData("{", "{")]
    [InlineData("{    ", "{")]
    [InlineData("    {", "{")]
    [InlineData("\t{", "{")]
    [InlineData("{\t", "{")]
    [InlineData("\t{\t", "{")]
    public void OpenBraceToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new OpenBraceToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }
    [Theory]
    [InlineData(";", ";")]
    [InlineData(";    ", ";")]
    [InlineData("    ;", ";")]
    [InlineData("\t;", ";")]
    [InlineData(";\t", ";")]
    [InlineData("\t;\t", ";")]
    public void SemicolonToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new SemicolonToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }

    [Theory]
    [InlineData("main", "main")]
    [InlineData("myVar", "myVar")]
    [InlineData("my_var", "my_var")]
    [InlineData("\tmyVar\t", "myVar")]
    [InlineData("myVar\t", "myVar")]
    [InlineData("\tmyVar", "myVar")]
    public void IdentifierToken_Matches(string input, string expected)
    {
        // Arrange
        var token = new IdentifierToken(input);

        // Act & Assert
        Assert.True(token.IsMatch());
        Assert.Equal(expected, token.TokenString());
    }

}
