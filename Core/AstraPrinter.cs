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
    public override void EnterAssignment(AstraParser.AssignmentContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void ExitAssignment(AstraParser.AssignmentContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void EnterIfStatement(AstraParser.IfStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void ExitIfStatement(AstraParser.IfStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void EnterWhileStatement(AstraParser.WhileStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void ExitWhileStatement(AstraParser.WhileStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void EnterDoWhileStatement(AstraParser.DoWhileStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void ExitDoWhileStatement(AstraParser.DoWhileStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void EnterInputStatement(AstraParser.InputStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void ExitInputStatement(AstraParser.InputStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void EnterOutputStatement(AstraParser.OutputStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
    public override void ExitOutputStatement(AstraParser.OutputStatementContext context)
    {
        Console.WriteLine("context: " + context.GetText());
    }
}