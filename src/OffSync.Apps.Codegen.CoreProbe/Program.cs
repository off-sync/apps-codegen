using Microsoft.CodeAnalysis.CSharp.Syntax;

using OffSync.Apps.Codegen.Application.ApplicationModels.Commands.WriteSource;
using OffSync.Apps.Codegen.Application.ApplicationModels.Queries.GenerateCode;
using OffSync.Apps.Codegen.Application.ApplicationModels.Queries.ParseModel;
using OffSync.Apps.Practises.Executables;

namespace OffSync.Apps.Codegen.CoreProbe
{
    static class Program
    {
        static void Main(
            string[] args)
        {
            var input = "";

            var parseModelQuery = Resolve<IQuery<ParseModelModel, ParseModelResult>>();

            var parseResult = parseModelQuery.Execute(
                new ParseModelModel()
                {
                    Input = input,
                });

            var generateCodeQuery = Resolve<IQuery<GenerateCodeModel, GenerateCodeResult<CompilationUnitSyntax>>>();

            var generateCodeResult = generateCodeQuery.Execute(
                new GenerateCodeModel()
                {
                    Application = parseResult.Application,
                });

            var writeSourceCommand = Resolve<ICommand<WriteSourceModel<CompilationUnitSyntax>>>();

            writeSourceCommand.Execute(
                new WriteSourceModel<CompilationUnitSyntax>()
                {
                    Code = generateCodeResult.Code,
                });
        }

        static T Resolve<T>()
            where T : class
        {
            return null;
        }
    }
}
