using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

class AstraPrinter : AstraBaseListener
{
    // override default listener behavior
    public override void ExitExpression(AstraParser.ExpressionContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
}