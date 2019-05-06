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
        private readonly ISourcePathStrategy _sourcePathStrategy;

        private readonly ICodeGenerator<TCompilationUnit> _codeGenerator;

        public GenerateCodeQuery(
            ISourcePathStrategy sourcePathStrategy,
            ICodeGenerator<TCompilationUnit> codeGenerator)
        {
            _sourcePathStrategy = sourcePathStrategy ?? throw new ArgumentNullException(nameof(sourcePathStrategy));
            _codeGenerator = codeGenerator ?? throw new ArgumentNullException(nameof(codeGenerator));
        }

        protected override GenerateCodeResult<TCompilationUnit> InternalExecute(
            GenerateCodeModel model)
        {
            var compilationUnits = new Dictionary<string, TCompilationUnit>();

            foreach (var aggregateRoot in model.ApplicationModel.AggregateRoots)
            {
                GenerateAggregateRootCode(
                    model.ApplicationModel,
                    aggregateRoot,
                    compilationUnits);
            }

            foreach (var @interface in model.ApplicationModel.Interfaces)
            {
                GenerateInterfaceCode(
                    model.ApplicationModel,
                    @interface,
                    compilationUnits);
            }

            return new GenerateCodeResult<TCompilationUnit>()
            {
                CompilationUnits = compilationUnits,
            };
        }

        private void GenerateAggregateRootCode(
            ApplicationModel applicationModel,
            AggregateRoot aggregateRoot,
            Dictionary<string, TCompilationUnit> compilationUnits)
        {
            #region Domain
            var domainPath = _sourcePathStrategy.GetBasePathForDomain(
                applicationModel,
                aggregateRoot);

            var domainNamespace = $"{applicationModel.Namespace}.Domain.{aggregateRoot.Name}";

            foreach (var domain in aggregateRoot.Domain)
            {
                var compilationUnit = _codeGenerator.GenerateClass(
                    domainNamespace,
                    domain);

                compilationUnits.Add(
                    domainPath + domain.Name,
                    compilationUnit);
            }
            #endregion

            #region Commands
            foreach (var command in aggregateRoot.Commands)
            {
                var commandPath = _sourcePathStrategy.GetBasePathForCommand(
                    applicationModel,
                    aggregateRoot,
                    command);

                var commandNamespace = $"{applicationModel.Namespace}.Application.{aggregateRoot.Name}.Commands.{command.Name}";

                // command
                var compilationUnit = _codeGenerator.GenerateCommand(
                    commandNamespace,
                    command);

                compilationUnits.Add(
                    commandPath + command.Name + "Command",
                    compilationUnit);

                // model
                compilationUnit = _codeGenerator.GenerateClass(
                    commandNamespace,
                    command.Model);

                compilationUnits.Add(
                    commandPath + command.Name + "Model",
                    compilationUnit);

                if (command.Result != null)
                {
                    // result
                    compilationUnit = _codeGenerator.GenerateClass(
                        commandNamespace,
                        command.Model);

                    compilationUnits.Add(
                        commandPath + command.Name + "Result",
                        compilationUnit);
                }

                // TODO config
            }
            #endregion

            #region Queries
            foreach (var query in aggregateRoot.Queries)
            {
                var queryPath = _sourcePathStrategy.GetBasePathForQuery(
                    applicationModel,
                    aggregateRoot,
                    query);

                var queryNamespace = $"{applicationModel.Namespace}.Application.{aggregateRoot.Name}.Queries.{query.Name}";

                // query
                var compilationUnit = _codeGenerator.GenerateQuery(
                    queryNamespace,
                    query);

                compilationUnits.Add(
                    queryPath + query.Name + "Query",
                    compilationUnit);

                // model
                compilationUnit = _codeGenerator.GenerateClass(
                    queryNamespace,
                    query.Model);

                compilationUnits.Add(
                    queryPath + query.Name + "Model",
                    compilationUnit);

                // result
                compilationUnit = _codeGenerator.GenerateClass(
                    queryNamespace,
                    query.Model);

                compilationUnits.Add(
                    queryPath + query.Name + "Result",
                    compilationUnit);

                // TODO config
            }
            #endregion
        }

        private void GenerateInterfaceCode(
            ApplicationModel applicationModel,
            Interface @interface,
            Dictionary<string, TCompilationUnit> compilationUnits)
        {
            var path = _sourcePathStrategy.GetBasePathForInterface(
                applicationModel,
                @interface);

            var compilationUnit = _codeGenerator.GenerateInterface(
                $"{applicationModel.Namespace}.Interfaces",
                @interface);

            compilationUnits.Add(
                path + @interface.Name,
                compilationUnit);
        }
    }
}
