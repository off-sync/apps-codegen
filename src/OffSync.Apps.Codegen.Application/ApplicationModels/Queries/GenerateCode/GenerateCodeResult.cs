using System.Collections.Generic;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Queries.GenerateCode
{
    public sealed class GenerateCodeResult<TCompilationUnit>
    {
        public IReadOnlyDictionary<string, TCompilationUnit> CompilationUnits { get; set; }
    }
}