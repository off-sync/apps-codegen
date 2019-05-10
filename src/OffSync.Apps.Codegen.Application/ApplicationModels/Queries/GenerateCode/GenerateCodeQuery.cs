using System;
using System.Collections.Generic;

using OffSync.Apps.Codegen.Application.Interfaces;
using OffSync.Apps.Codegen.Domain.ApplicationModels;
using OffSync.Apps.Codegen.Domain.CodeModels;
using OffSync.Apps.Practises.Executables;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Queries.GenerateCode
{
    public sealed class GenerateCodeQuery<TCompilationUnit> :
        AbstractQuery<GenerateCodeModel, GenerateCodeResult<TCompilationUnit>>
    {
        private readonly ICodeGenerator<TCompilationUnit> _codeGenerator;

        public GenerateCodeQuery(
            ICodeGenerator<TCompilationUnit> codeGenerator)
        {
            _codeGenerator = codeGenerator ?? throw new ArgumentNullException(nameof(codeGenerator));
        }

        protected override GenerateCodeResult<TCompilationUnit> InternalExecute(
            GenerateCodeModel model)
        {
            var code = new List<CodeModel<TCompilationUnit>>();

            foreach (var aggregateRoot in model.Application.AggregateRoots)
            {
                code.AddRange(
                    GenerateAggregateRootCode(
                        model.Application,
                        aggregateRoot));
            }

            foreach (var @interface in model.Application.Interfaces)
            {
                code.AddRange(
                    GenerateInterfaceCode(
                        model.Application,
                        @interface));
            }

            return new GenerateCodeResult<TCompilationUnit>()
            {
                Code = code,
            };
        }

        private IEnumerable<CodeModel<TCompilationUnit>> GenerateAggregateRootCode(
            ApplicationModel applicationModel,
            AggregateRoot aggregateRoot)
        {
            #region Domain
            var domainNamespace = $"{applicationModel.Namespace}.Domain.{aggregateRoot.Name}";

            foreach (var domain in aggregateRoot.Domain)
            {
                var compilationUnit = _codeGenerator.GenerateClass(
                    domainNamespace,
                    domain);

                yield return new CodeModel<TCompilationUnit>()
                {
                    Namespace = domainNamespace,
                    Name = domain.Name,
                    CompilationUnit = compilationUnit,
                };
            }
            #endregion

            #region Commands
            foreach (var command in aggregateRoot.Commands)
            {
                var commandNamespace = $"{applicationModel.Namespace}.Application.{aggregateRoot.Name}.Commands.{command.Name}";

                // command
                var compilationUnit = _codeGenerator.GenerateCommand(
                    commandNamespace,
                    command);

                yield return new CodeModel<TCompilationUnit>()
                {
                    Namespace = commandNamespace,
                    Name = command.Name + "Command",
                    CompilationUnit = compilationUnit,
                };

                // TODO command boilerplate

                // model
                compilationUnit = _codeGenerator.GenerateClass(
                    commandNamespace,
                    command.Model);

                yield return new CodeModel<TCompilationUnit>()
                {
                    Namespace = commandNamespace,
                    Name = command.Name + "Model",
                    CompilationUnit = compilationUnit,
                };

                if (command.Result != null)
                {
                    // result
                    compilationUnit = _codeGenerator.GenerateClass(
                        commandNamespace,
                        command.Model);

                    yield return new CodeModel<TCompilationUnit>()
                    {
                        Namespace = commandNamespace,
                        Name = command.Name + "Result",
                        CompilationUnit = compilationUnit,
                    };
                }

                // TODO config
            }
            #endregion

            #region Queries
            foreach (var query in aggregateRoot.Queries)
            {
                var queryNamespace = $"{applicationModel.Namespace}.Application.{aggregateRoot.Name}.Queries.{query.Name}";

                // query
                var compilationUnit = _codeGenerator.GenerateQuery(
                    queryNamespace,
                    query);

                yield return new CodeModel<TCompilationUnit>()
                {
                    Namespace = queryNamespace,
                    Name = query.Name + "Query",
                    CompilationUnit = compilationUnit,
                };

                // TODO query boilerplate

                // model
                compilationUnit = _codeGenerator.GenerateClass(
                    queryNamespace,
                    query.Model);

                yield return new CodeModel<TCompilationUnit>()
                {
                    Namespace = queryNamespace,
                    Name = query.Name + "Model",
                    CompilationUnit = compilationUnit,
                };

                // result
                compilationUnit = _codeGenerator.GenerateClass(
                    queryNamespace,
                    query.Model);

                yield return new CodeModel<TCompilationUnit>()
                {
                    Namespace = queryNamespace,
                    Name = query.Name + "Result",
                    CompilationUnit = compilationUnit,
                };

                // TODO config
            }
            #endregion
        }

        private IEnumerable<CodeModel<TCompilationUnit>> GenerateInterfaceCode(
            ApplicationModel applicationModel,
            Interface @interface)
        {
            var @namespace = $"{applicationModel.Namespace}.Interfaces";

            var compilationUnit = _codeGenerator.GenerateInterface(
                @namespace,
                @interface);

            yield return new CodeModel<TCompilationUnit>()
            {
                Namespace = @namespace,
                Name = @interface.Name,
                CompilationUnit = compilationUnit,
            };
        }
    }
}
