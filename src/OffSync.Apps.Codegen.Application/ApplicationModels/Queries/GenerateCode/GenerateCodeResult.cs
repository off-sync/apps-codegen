using System.Collections.Generic;

using OffSync.Apps.Codegen.Domain.CodeModels;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Queries.GenerateCode
{
    public sealed class GenerateCodeResult<TCompilationUnit>
    {
        public IEnumerable<CodeModel<TCompilationUnit>> Code { get; set; }
    }
}