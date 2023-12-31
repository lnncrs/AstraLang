//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from AntlrTool\Astra.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IAstraListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class AstraBaseListener : IAstraListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] AstraParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] AstraParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] AstraParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] AstraParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] AstraParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] AstraParser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] AstraParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] AstraParser.IfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] AstraParser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] AstraParser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.doWhileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoWhileStatement([NotNull] AstraParser.DoWhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.doWhileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoWhileStatement([NotNull] AstraParser.DoWhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.inputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInputStatement([NotNull] AstraParser.InputStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.inputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInputStatement([NotNull] AstraParser.InputStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.outputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOutputStatement([NotNull] AstraParser.OutputStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.outputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOutputStatement([NotNull] AstraParser.OutputStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] AstraParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] AstraParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] AstraParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] AstraParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stringLiteral</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringLiteral([NotNull] AstraParser.StringLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stringLiteral</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringLiteral([NotNull] AstraParser.StringLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveExpression([NotNull] AstraParser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveExpression([NotNull] AstraParser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>relationalExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelationalExpression([NotNull] AstraParser.RelationalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>relationalExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelationalExpression([NotNull] AstraParser.RelationalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>intLiteral</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntLiteral([NotNull] AstraParser.IntLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>intLiteral</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntLiteral([NotNull] AstraParser.IntLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>doubleLiteral</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoubleLiteral([NotNull] AstraParser.DoubleLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>doubleLiteral</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoubleLiteral([NotNull] AstraParser.DoubleLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable([NotNull] AstraParser.VariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable([NotNull] AstraParser.VariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parensExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParensExpression([NotNull] AstraParser.ParensExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parensExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParensExpression([NotNull] AstraParser.ParensExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeExpression([NotNull] AstraParser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeExpression([NotNull] AstraParser.MultiplicativeExpressionContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
