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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AstraParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public interface IAstraListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] AstraParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] AstraParser.ParseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] AstraParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] AstraParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] AstraParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] AstraParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] AstraParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] AstraParser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>identifierFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierFunctionCall([NotNull] AstraParser.IdentifierFunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierFunctionCall([NotNull] AstraParser.IdentifierFunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>printlnFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintlnFunctionCall([NotNull] AstraParser.PrintlnFunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>printlnFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintlnFunctionCall([NotNull] AstraParser.PrintlnFunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>printFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintFunctionCall([NotNull] AstraParser.PrintFunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>printFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintFunctionCall([NotNull] AstraParser.PrintFunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>assertFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssertFunctionCall([NotNull] AstraParser.AssertFunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>assertFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssertFunctionCall([NotNull] AstraParser.AssertFunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>sizeFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSizeFunctionCall([NotNull] AstraParser.SizeFunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>sizeFunctionCall</c>
	/// labeled alternative in <see cref="AstraParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSizeFunctionCall([NotNull] AstraParser.SizeFunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] AstraParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] AstraParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.ifStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStat([NotNull] AstraParser.IfStatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.ifStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStat([NotNull] AstraParser.IfStatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.elseIfStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfStat([NotNull] AstraParser.ElseIfStatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.elseIfStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfStat([NotNull] AstraParser.ElseIfStatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.elseStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseStat([NotNull] AstraParser.ElseStatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.elseStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseStat([NotNull] AstraParser.ElseStatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.functionDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDecl([NotNull] AstraParser.FunctionDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.functionDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDecl([NotNull] AstraParser.FunctionDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] AstraParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] AstraParser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] AstraParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] AstraParser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.idList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdList([NotNull] AstraParser.IdListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.idList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdList([NotNull] AstraParser.IdListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.exprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprList([NotNull] AstraParser.ExprListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.exprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprList([NotNull] AstraParser.ExprListContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>boolExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolExpression([NotNull] AstraParser.BoolExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>boolExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolExpression([NotNull] AstraParser.BoolExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numberExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberExpression([NotNull] AstraParser.NumberExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberExpression([NotNull] AstraParser.NumberExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] AstraParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] AstraParser.IdentifierExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] AstraParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] AstraParser.NotExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>orExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrExpression([NotNull] AstraParser.OrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>orExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrExpression([NotNull] AstraParser.OrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>unaryMinusExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryMinusExpression([NotNull] AstraParser.UnaryMinusExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryMinusExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryMinusExpression([NotNull] AstraParser.UnaryMinusExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>powerExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPowerExpression([NotNull] AstraParser.PowerExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>powerExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPowerExpression([NotNull] AstraParser.PowerExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>eqExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqExpression([NotNull] AstraParser.EqExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>eqExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqExpression([NotNull] AstraParser.EqExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>andExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpression([NotNull] AstraParser.AndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>andExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpression([NotNull] AstraParser.AndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>inExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInExpression([NotNull] AstraParser.InExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>inExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInExpression([NotNull] AstraParser.InExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stringExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringExpression([NotNull] AstraParser.StringExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stringExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringExpression([NotNull] AstraParser.StringExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionExpression([NotNull] AstraParser.ExpressionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionExpression([NotNull] AstraParser.ExpressionExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddExpression([NotNull] AstraParser.AddExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddExpression([NotNull] AstraParser.AddExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>compExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompExpression([NotNull] AstraParser.CompExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>compExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompExpression([NotNull] AstraParser.CompExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>nullExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullExpression([NotNull] AstraParser.NullExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>nullExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullExpression([NotNull] AstraParser.NullExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] AstraParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] AstraParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultExpression([NotNull] AstraParser.MultExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultExpression([NotNull] AstraParser.MultExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>listExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterListExpression([NotNull] AstraParser.ListExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>listExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitListExpression([NotNull] AstraParser.ListExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ternaryExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTernaryExpression([NotNull] AstraParser.TernaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ternaryExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTernaryExpression([NotNull] AstraParser.TernaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>inputExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInputExpression([NotNull] AstraParser.InputExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>inputExpression</c>
	/// labeled alternative in <see cref="AstraParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInputExpression([NotNull] AstraParser.InputExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList([NotNull] AstraParser.ListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList([NotNull] AstraParser.ListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AstraParser.indexes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexes([NotNull] AstraParser.IndexesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AstraParser.indexes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexes([NotNull] AstraParser.IndexesContext context);
}
