using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerBackend;
public interface ICompiler
{
    string Compile(string input);
}
