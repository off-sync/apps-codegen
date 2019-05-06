using OffSync.Apps.Codegen.Domain.ApplicationModels;
using OffSync.Apps.Codegen.Domain.CodeModels;

namespace OffSync.Apps.Codegen.Application.Interfaces
{
    public interface ICodeGenerator<out TCompilationUnit>
    {
        TCompilationUnit GenerateCommand(
            string @namespace,
            Command command);

        TCompilationUnit GenerateQuery(
            string @namespace,
            Query query);

        TCompilationUnit GenerateClass(
            string @namespace,
            Class @class);

        TCompilationUnit GenerateInterface(
            string @namespace,
            Interface @interface);
    }
}
