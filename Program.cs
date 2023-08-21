using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Reflection;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Astra;

class Program
{
      static string ExprParseMethod(string input)
      {
            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new ExprLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            ExprParser parser = new ExprParser(tokens);
            parser.BuildParseTree = true;
            IParseTree tree = parser.prog();
            return tree.ToStringTree(parser);
      }

      static string AstraParseMethod(string input)
      {
            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new TLLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            AstraParser parser = new AstraParser(tokens);
            parser.BuildParseTree = true;
            IParseTree tree = parser.parse();

            AstraPrinter printer = new AstraPrinter();
            ParseTreeWalker.Default.Walk(printer, tree);

            return tree.ToStringTree(parser);
      }

      static string TLParseMethod(string input)
      {
            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new TLLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            TLParser parser = new TLParser(tokens);
            parser.BuildParseTree = true;
            IParseTree tree = parser.parse();

            TLPrinter printer = new TLPrinter();
            ParseTreeWalker.Default.Walk(printer, tree);

            return tree.ToStringTree(parser);
      }

      static void BuildSource(string banner, string? fileInputPath, string? fileOutputPath)
      {
            Console.WriteLine(banner);
            Console.WriteLine($"input : {fileInputPath}");

            if (string.IsNullOrEmpty(fileInputPath))
            {
                  Console.WriteLine("input file is required.");
                  return;
            }

            if (!System.IO.File.Exists(fileInputPath))
            {
                  Console.WriteLine("input file does not exist.");
                  return;
            }

            if (string.IsNullOrEmpty(fileOutputPath))
            {
                  fileOutputPath = System.IO.Path.ChangeExtension(fileInputPath, ".out");
            }

            Console.WriteLine($"output: {fileOutputPath}");

            string fileOutputTreePath = System.IO.Path.ChangeExtension(fileInputPath, ".tree");

            Console.WriteLine($"tree  : {fileOutputTreePath}");

            string fileOutputCLangPath = System.IO.Path.ChangeExtension(fileInputPath, ".c");

            Console.WriteLine($"clang : {fileOutputCLangPath}");

            // load the source file
            string source = System.IO.File.ReadAllText(fileInputPath);

            // string tree = ExprParseMethod(source);
            // string tree = TLParseMethod(source);
            string tree = AstraParseMethod(source);

            // write to output file
            using System.IO.StreamWriter fileOutput = new System.IO.StreamWriter(fileOutputPath);
                  fileOutput.WriteLine(tree);

            // write to output file
            using System.IO.StreamWriter fileTree = new System.IO.StreamWriter(fileOutputTreePath);
                  fileTree.WriteLine(tree);
      }

      static async Task<int> Main(string[] args)
      {
            // display the banner
            OperatingSystem os = Environment.OSVersion;
            Version? version = Assembly.GetEntryAssembly()?.GetName().Version ?? new Version(0, 0, 0, 0);
            int bitness = IntPtr.Size * 8;

            string banner = $"AstraLang version {version} ({os.Platform} {os.Version} {bitness}-bit)";
            string sampleSource = "helloworld.astra";

            string binaryDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            string sourceDirectory = currentDirectory;

            var inputFile = new Option<string?>(
            name: "--input",
            description: "Source file path",
            getDefaultValue: () => Path.Combine(binaryDirectory, "samples", sampleSource));

            var outputFile = new Option<string?>(
            name: "--output",
            description: "Source file path");

            var rootCommand = new RootCommand(banner);
            rootCommand.AddOption(inputFile);
            rootCommand.AddOption(outputFile);

            rootCommand.SetHandler((fileInput, fileOutput) =>
                {
                      BuildSource(banner, fileInput, fileOutput);
                },
                inputFile, outputFile);

            return await rootCommand.InvokeAsync(args);
      }
}

