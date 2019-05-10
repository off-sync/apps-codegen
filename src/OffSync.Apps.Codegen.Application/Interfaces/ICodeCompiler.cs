using System.Collections.Generic;

namespace OffSync.Apps.Codegen.Application.Interfaces
{
    public interface ICodeCompiler<in TCompilationUnit>
    {
        string Compile(
            IEnumerable<TCompilationUnit> compilationUnits,
            out string extension);
    }
}
