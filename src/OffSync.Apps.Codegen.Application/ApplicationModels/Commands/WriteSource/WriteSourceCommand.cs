using System;

using OffSync.Apps.Codegen.Application.Interfaces;
using OffSync.Apps.Practises.Executables;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Commands.WriteSource
{
    public sealed class WriteSourceCommand<TCompilationUnit> :
        AbstractCommand<WriteSourceModel<TCompilationUnit>>
    {
        private readonly ISourceWriter<TCompilationUnit> _sourceWriter;

        public WriteSourceCommand(
            ISourceWriter<TCompilationUnit> sourceWriter)
        {
            _sourceWriter = sourceWriter ?? throw new ArgumentNullException(nameof(sourceWriter));
        }

        protected override void InternalExecute(
            WriteSourceModel<TCompilationUnit> model)
        {
            foreach (var compilationUnit in model.CompilationUnits)
            {
                _sourceWriter.Write(
                    compilationUnit.Key,
                    compilationUnit.Value);
            }
        }
    }
}
