using Moq;
using ConsoleFrontend.Stages;
using CompilerBackend;

namespace CompilerTests.ConsoleFrontend;
public class CompilerStageTests
{

    [Fact]
    public void Run_Returns_Compiled_Output()
    {
        // Arrange
        string input = "It is a test";
        string expectedOutput = "IT IS A TEST";
        var mockCompiler = new Mock<ICompiler>();
        mockCompiler.Setup(x => x.Compile(input)).Returns(expectedOutput);
        var compilerStage = new CompilerStage(mockCompiler.Object);

        // Act
        var result = compilerStage.Run(input);

        // Assert
        Assert.Equal(expectedOutput, result);
        mockCompiler.Verify(c => c.Compile(input), Times.Once);
    }
}
