using System;

using OffSync.Apps.Codegen.Application.Interfaces;
using OffSync.Apps.Practises.Executables;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Commands.WriteSource
{
    public sealed class WriteSourceCommand<TCompilationUnit> :
        AbstractCommand<WriteSourceModel<TCompilationUnit>>
    {
        private readonly ICodeCompiler<TCompilationUnit> _codeCompiler;

        private readonly ISourceWriter _sourceWriter;

        public WriteSourceCommand(
            ICodeCompiler<TCompilationUnit> codeCompiler,
            ISourceWriter sourceWriter)
        {
            _codeCompiler = codeCompiler ?? throw new ArgumentNullException(nameof(codeCompiler));
            _sourceWriter = sourceWriter ?? throw new ArgumentNullException(nameof(sourceWriter));
        }

        protected override void InternalExecute(
            WriteSourceModel<TCompilationUnit> model)
        {
            foreach (var compilationUnit in model.CompilationUnits)
            {
                var source = _codeCompiler.Compile(
                    compilationUnit.Value);

                _sourceWriter.Write(
                    compilationUnit.Key,
                    source);
            }
        }
    }
}
