//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Spreadsheet.g4 by ANTLR 4.6

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
/// <see cref="SpreadsheetParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public interface ISpreadsheetListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>addsubExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddsubExp([NotNull] SpreadsheetParser.AddsubExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addsubExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddsubExp([NotNull] SpreadsheetParser.AddsubExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parethesisExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParethesisExp([NotNull] SpreadsheetParser.ParethesisExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parethesisExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParethesisExp([NotNull] SpreadsheetParser.ParethesisExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numericAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericAtomExp([NotNull] SpreadsheetParser.NumericAtomExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numericAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericAtomExp([NotNull] SpreadsheetParser.NumericAtomExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>mulDivExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulDivExp([NotNull] SpreadsheetParser.MulDivExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>mulDivExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulDivExp([NotNull] SpreadsheetParser.MulDivExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>idAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdAtomExp([NotNull] SpreadsheetParser.IdAtomExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>idAtomExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdAtomExp([NotNull] SpreadsheetParser.IdAtomExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>functionExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionExp([NotNull] SpreadsheetParser.FunctionExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionExp</c>
	/// labeled alternative in <see cref="SpreadsheetParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionExp([NotNull] SpreadsheetParser.FunctionExpContext context);
}
