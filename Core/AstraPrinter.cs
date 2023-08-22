using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

class AstraPrinter : AstraBaseListener
{
    // override default listener behavior
    public override void EnterProgram(AstraParser.ProgramContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }

    public override void ExitProgram(AstraParser.ProgramContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }

}