using CompilerBackend;
using ConsoleFrontend.Stages;
using System;
using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;

namespace ConsoleFrontend;

sealed class Program
{
    static int Main(string[] args)
    {
        Option<FileInfo> inputFileOption = new("--input", "-i")
        {
            Description = "The C file to compile.",
            Required = true
        };
        Option<FileInfo> outputFileOption = new("--output", "-o")
        {
            Description = "The output file to write the compiled code to."
        };

        RootCommand rootCommand = new("Simple C Compiler based on the book 'Writing a C Compiler' by Nora Sandler.");
        rootCommand.Options.Add(inputFileOption);
        rootCommand.Options.Add(outputFileOption);

        rootCommand.SetAction(parseResult =>
        {
            if (parseResult.Errors.Count == 0 && parseResult.GetValue(inputFileOption) is FileInfo parsedFile)
            {
                FileInfo? inputFileInfo = parseResult.GetValue(inputFileOption);
                if (inputFileInfo == null)
                {
                    Console.Error.WriteLine("Input file is required.");
                    return 1;
                }
                if (!inputFileInfo.Exists)
                {
                    Console.Error.WriteLine($"Input file '{inputFileInfo.FullName}' does not exist.");
                    return 1;
                }
                FileInfo outputFileInfo = parseResult.GetValue(outputFileOption) ?? new FileInfo(Path.ChangeExtension(inputFileInfo.FullName, ".out"));
                StageRunner.Run(inputFileInfo.FullName, outputFileInfo.FullName, new AGCompiler());
                return 0;
            }
            foreach (ParseError parseError in parseResult.Errors)
            {
                Console.Error.WriteLine(parseError.Message);
            }
            return 1;
        });

        return rootCommand.Parse(args).Invoke();
    }
}
