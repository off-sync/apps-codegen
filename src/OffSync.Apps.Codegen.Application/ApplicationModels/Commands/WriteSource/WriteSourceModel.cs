using System.Collections.Generic;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Commands.WriteSource
{
    public sealed class WriteSourceModel<TCompilationUnit>
    {
        public IReadOnlyDictionary<string, TCompilationUnit> CompilationUnits { get; set; }
    }
}