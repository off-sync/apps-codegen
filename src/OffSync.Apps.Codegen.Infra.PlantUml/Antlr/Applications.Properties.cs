using System.Collections.Generic;
using System.Linq;

namespace OffSync.Apps.Codegen.Infra.PlantUml.Antlr
{
    public partial class ApplicationsParser
    {
        public partial class ApplicationContext
        {
            public string Title => title().title_.GetText();

            public IEnumerable<AggregateRootContext> AggregateRoots => aggregateRoots()?.aggregateRoot() ?? Enumerable.Empty<AggregateRootContext>();

            public IEnumerable<InterfaceDefContext> Interfaces => interfaces()?.interfaceDefs().interfaceDef() ?? Enumerable.Empty<InterfaceDefContext>();
        }

        public partial class AggregateRootContext
        {
            public string Name => name_.GetText();

            public IEnumerable<ClassDefContext> Domain => domain().classDefs().classDef() ?? Enumerable.Empty<ClassDefContext>();

            public IEnumerable<CommandContext> Commands => commands()?.command() ?? Enumerable.Empty<CommandContext>();

            public IEnumerable<QueryContext> Queries => queries()?.query() ?? Enumerable.Empty<QueryContext>();
        }

        public partial class CommandContext
        {
            public string Name => name_.GetText();

            public IEnumerable<PropertyContext> ModelProperties => modelClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();

            public IEnumerable<PropertyContext> ResultProperties => resultClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();

            public IEnumerable<string> Dependencies => dependencies()?.dependency().Select(d => d.type_.GetText()) ?? Enumerable.Empty<string>();

            public IEnumerable<PropertyContext> ConfigProperties => configClassDef().classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();
        }

        public partial class QueryContext
        {
            public string Name => name_.GetText();

            public IEnumerable<PropertyContext> ModelProperties => modelClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();

            public IEnumerable<PropertyContext> ResultProperties => resultClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();

            public IEnumerable<string> Dependencies => dependencies()?.dependency().Select(d => d.type_.GetText()) ?? Enumerable.Empty<string>();

            public IEnumerable<PropertyContext> ConfigProperties => configClassDef().classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();
        }

        public partial class ClassDefContext
        {
            public string Name => name_.GetText();

            public IEnumerable<PropertyContext> Properties => classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();
        }

        public partial class InterfaceDefContext
        {
            public string Name => name_.GetText();

            public IEnumerable<MethodContext> Methods => methods().method();
        }

        public partial class PropertyContext
        {
            public TypeContext Type => type();

            public string Name => name_.GetText();
        }

        public partial class MethodContext
        {
            /// <summary>
            /// ReturnType is null when the return type is void.
            /// </summary>
            public TypeContext ReturnType => returnType_.type();

            public string Name => name_.GetText();

            public IEnumerable<ParameterContext> Parameters => parameters()?.parameter() ?? Enumerable.Empty<ParameterContext>();
        }

        public partial class ParameterContext
        {
            public TypeContext Type => type();

            public string Name => name_.GetText();
        }
    }
}
