using System.Collections.Generic;

using OffSync.Apps.Codegen.Domain.CodeModels;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Commands.WriteSource
{
    public sealed class WriteSourceModel<TCompilationUnit>
    {
        public IEnumerable<CodeModel<TCompilationUnit>> Code { get; set; }
    }
}