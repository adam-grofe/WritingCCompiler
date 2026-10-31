using CompilerBackend;

namespace CompilerTests.CompilerBackend.IntegrationTests
{
    public class CompilerTests
    {

        [Fact]
        public void Compile_ShouldReturnAssembly()
        {
            // Arrange
            var compiler = new Compiler();
            var input = 
@"int main(void) { 
    return 2; 
}";

            // Act
            var result = compiler.Compile(input);

            // Assert
            Assert.True(result.Contains(".global main"));
            Assert.True(result.Contains("main:"));
            Assert.True(result.Contains("movl"));
            Assert.True(result.Contains("$2, %eax"));
            Assert.True(result.Contains("ret"));
        }
    }
}
