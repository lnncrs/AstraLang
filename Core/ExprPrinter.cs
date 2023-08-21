class ExprPrinter : ExprBaseListener {
    // override default listener behavior
    public override void ExitExpr (ExprParser.ExprContext context) {
        Console.WriteLine("context: " + context.GetText());
    }
}