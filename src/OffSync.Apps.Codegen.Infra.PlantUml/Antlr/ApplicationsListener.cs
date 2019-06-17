//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Applications.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace OffSync.Apps.Codegen.Infra.PlantUml.Antlr {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ApplicationsParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IApplicationsListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.application"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterApplication([NotNull] ApplicationsParser.ApplicationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.application"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitApplication([NotNull] ApplicationsParser.ApplicationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.title"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTitle([NotNull] ApplicationsParser.TitleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.title"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTitle([NotNull] ApplicationsParser.TitleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.aggregateRoots"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregateRoots([NotNull] ApplicationsParser.AggregateRootsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.aggregateRoots"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregateRoots([NotNull] ApplicationsParser.AggregateRootsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.aggregateRoot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregateRoot([NotNull] ApplicationsParser.AggregateRootContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.aggregateRoot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregateRoot([NotNull] ApplicationsParser.AggregateRootContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.domain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDomain([NotNull] ApplicationsParser.DomainContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.domain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDomain([NotNull] ApplicationsParser.DomainContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.classDefs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDefs([NotNull] ApplicationsParser.ClassDefsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.classDefs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDefs([NotNull] ApplicationsParser.ClassDefsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.classDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDef([NotNull] ApplicationsParser.ClassDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.classDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDef([NotNull] ApplicationsParser.ClassDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassBody([NotNull] ApplicationsParser.ClassBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassBody([NotNull] ApplicationsParser.ClassBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProperties([NotNull] ApplicationsParser.PropertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProperties([NotNull] ApplicationsParser.PropertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProperty([NotNull] ApplicationsParser.PropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProperty([NotNull] ApplicationsParser.PropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.commands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommands([NotNull] ApplicationsParser.CommandsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.commands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommands([NotNull] ApplicationsParser.CommandsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommand([NotNull] ApplicationsParser.CommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommand([NotNull] ApplicationsParser.CommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.commandClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommandClassDef([NotNull] ApplicationsParser.CommandClassDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.commandClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommandClassDef([NotNull] ApplicationsParser.CommandClassDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.modelClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModelClassDef([NotNull] ApplicationsParser.ModelClassDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.modelClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModelClassDef([NotNull] ApplicationsParser.ModelClassDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.resultClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResultClassDef([NotNull] ApplicationsParser.ResultClassDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.resultClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResultClassDef([NotNull] ApplicationsParser.ResultClassDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.dependencies"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDependencies([NotNull] ApplicationsParser.DependenciesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.dependencies"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDependencies([NotNull] ApplicationsParser.DependenciesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.dependency"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDependency([NotNull] ApplicationsParser.DependencyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.dependency"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDependency([NotNull] ApplicationsParser.DependencyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.configClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConfigClassDef([NotNull] ApplicationsParser.ConfigClassDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.configClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConfigClassDef([NotNull] ApplicationsParser.ConfigClassDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.queries"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueries([NotNull] ApplicationsParser.QueriesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.queries"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueries([NotNull] ApplicationsParser.QueriesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery([NotNull] ApplicationsParser.QueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery([NotNull] ApplicationsParser.QueryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.queryClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueryClassDef([NotNull] ApplicationsParser.QueryClassDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.queryClassDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueryClassDef([NotNull] ApplicationsParser.QueryClassDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.interfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaces([NotNull] ApplicationsParser.InterfacesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.interfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaces([NotNull] ApplicationsParser.InterfacesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.interfaceDefs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceDefs([NotNull] ApplicationsParser.InterfaceDefsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.interfaceDefs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceDefs([NotNull] ApplicationsParser.InterfaceDefsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.interfaceDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceDef([NotNull] ApplicationsParser.InterfaceDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.interfaceDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceDef([NotNull] ApplicationsParser.InterfaceDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.methods"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethods([NotNull] ApplicationsParser.MethodsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.methods"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethods([NotNull] ApplicationsParser.MethodsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethod([NotNull] ApplicationsParser.MethodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethod([NotNull] ApplicationsParser.MethodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.typeOrVoid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeOrVoid([NotNull] ApplicationsParser.TypeOrVoidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.typeOrVoid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeOrVoid([NotNull] ApplicationsParser.TypeOrVoidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameters([NotNull] ApplicationsParser.ParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameters([NotNull] ApplicationsParser.ParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter([NotNull] ApplicationsParser.ParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter([NotNull] ApplicationsParser.ParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SimpleType</c>
	/// labeled alternative in <see cref="ApplicationsParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleType([NotNull] ApplicationsParser.SimpleTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SimpleType</c>
	/// labeled alternative in <see cref="ApplicationsParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleType([NotNull] ApplicationsParser.SimpleTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GenericType</c>
	/// labeled alternative in <see cref="ApplicationsParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGenericType([NotNull] ApplicationsParser.GenericTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GenericType</c>
	/// labeled alternative in <see cref="ApplicationsParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGenericType([NotNull] ApplicationsParser.GenericTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NullableSimpleType</c>
	/// labeled alternative in <see cref="ApplicationsParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullableSimpleType([NotNull] ApplicationsParser.NullableSimpleTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NullableSimpleType</c>
	/// labeled alternative in <see cref="ApplicationsParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullableSimpleType([NotNull] ApplicationsParser.NullableSimpleTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ReferenceType</c>
	/// labeled alternative in <see cref="ApplicationsParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReferenceType([NotNull] ApplicationsParser.ReferenceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ReferenceType</c>
	/// labeled alternative in <see cref="ApplicationsParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReferenceType([NotNull] ApplicationsParser.ReferenceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.dataType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataType([NotNull] ApplicationsParser.DataTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.dataType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataType([NotNull] ApplicationsParser.DataTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.nullableDataType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullableDataType([NotNull] ApplicationsParser.NullableDataTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.nullableDataType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullableDataType([NotNull] ApplicationsParser.NullableDataTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArguments([NotNull] ApplicationsParser.TypeArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArguments([NotNull] ApplicationsParser.TypeArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.qualifiedId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedId([NotNull] ApplicationsParser.QualifiedIdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.qualifiedId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedId([NotNull] ApplicationsParser.QualifiedIdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId([NotNull] ApplicationsParser.IdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId([NotNull] ApplicationsParser.IdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ApplicationsParser.parameterName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterName([NotNull] ApplicationsParser.ParameterNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ApplicationsParser.parameterName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterName([NotNull] ApplicationsParser.ParameterNameContext context);
}
} // namespace OffSync.Apps.Codegen.Infra.PlantUml.Antlr