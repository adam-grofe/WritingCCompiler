using CompilerBackend;

namespace CompilerTests.CompilerBackend.IntegrationTests
{
    public class CompilerTests
    {

        [Fact]
        public void Compile_ShouldReturnAssembly()
        {
            // Arrange
            var compiler = new AGCompiler();
            var input = 
@"int main(void) { 
    return 2; 
}";

            // Act
            var result = compiler.Compile(input);

            // Assert
            Assert.Contains(result, ".global main");
            Assert.Contains(result, "main:");
            Assert.Contains(result, "movl");
            Assert.Contains(result, "$2, %eax");
            Assert.Contains(result, "ret");
        }
    }
}
