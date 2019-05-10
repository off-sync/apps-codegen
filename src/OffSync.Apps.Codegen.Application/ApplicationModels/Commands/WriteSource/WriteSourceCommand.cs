using System;
using System.Linq;

using OffSync.Apps.Codegen.Application.Interfaces;
using OffSync.Apps.Practises.Executables;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Commands.WriteSource
{
    public sealed class WriteSourceCommand<TCompilationUnit> :
        AbstractCommand<WriteSourceModel<TCompilationUnit>>
    {
        private readonly ICodeCompiler<TCompilationUnit> _codeCompiler;

        private readonly ISourcePathStrategy _sourcePathStrategy;

        private readonly ISourceWriter _sourceWriter;

        public WriteSourceCommand(
            ICodeCompiler<TCompilationUnit> codeCompiler,
            ISourcePathStrategy sourcePathStrategy,
            ISourceWriter sourceWriter)
        {
            _codeCompiler = codeCompiler ?? throw new ArgumentNullException(nameof(codeCompiler));
            _sourcePathStrategy = sourcePathStrategy ?? throw new ArgumentNullException(nameof(sourcePathStrategy));
            _sourceWriter = sourceWriter ?? throw new ArgumentNullException(nameof(sourceWriter));
        }

        protected override void InternalExecute(
            WriteSourceModel<TCompilationUnit> model)
        {
            var paths = model
                .Code
                .GroupBy(
                    cu => _sourcePathStrategy.GetSourcePath(
                        cu.Namespace,
                        cu.Name,
                        cu.IsBoilerPlate),
                    cu => cu.CompilationUnit);

            foreach (var path in paths)
            {
                string extension;

                var source = _codeCompiler.Compile(
                    path,
                    out extension);

                _sourceWriter.Write(
                    path.Key + extension,
                    source);
            }
        }
    }
}
