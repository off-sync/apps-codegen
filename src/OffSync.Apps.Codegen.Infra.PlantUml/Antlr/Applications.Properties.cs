using System.Collections.Generic;
using System.Linq;

namespace OffSync.Apps.Codegen.Infra.PlantUml.Antlr
{
    public interface IApplicationContext
    {
        string Title { get; }

        IEnumerable<IAggregateRootContext> AggregateRoots { get; }

        IEnumerable<IInterfaceDefContext> Interfaces { get; }
    }

    public interface IAggregateRootContext
    {
        string Name { get; }

        IEnumerable<IClassDefContext> Domain { get; }

        IEnumerable<ICommandContext> Commands { get; }

        IEnumerable<IQueryContext> Queries { get; }
    }

    public interface ICommandContext
    {
        string Name { get; }

        IEnumerable<IPropertyContext> ModelProperties { get; }

        IEnumerable<IPropertyContext> ResultProperties { get; }

        IEnumerable<string> Dependencies { get; }

        IEnumerable<IPropertyContext> ConfigProperties { get; }
    }

    public interface IQueryContext
    {
        string Name { get; }

        IEnumerable<IPropertyContext> ModelProperties { get; }

        IEnumerable<IPropertyContext> ResultProperties { get; }

        IEnumerable<string> Dependencies { get; }

        IEnumerable<IPropertyContext> ConfigProperties { get; }
    }

    public interface IClassDefContext
    {
        string Name { get; }

        IEnumerable<IPropertyContext> Properties { get; }
    }

    public interface IInterfaceDefContext
    {
        string Name { get; }

        IEnumerable<IMethodContext> Methods { get; }
    }

    public interface IPropertyContext
    {
        string Name { get; }

        string Type { get; }
    }

    public interface IMethodContext
    {
        string Name { get; }

        /// <summary>
        /// ReturnType is null when the return type is void.
        /// </summary>
        string ReturnType { get; }

        IEnumerable<IParameterContext> Parameters { get; }
    }

    public interface IParameterContext
    {
        string Name { get; }

        string Type { get; }
    }

    public partial class ApplicationsParser
    {
        public partial class ApplicationContext :
            IApplicationContext
        {
            public string Title => title().title_.GetText();

            public IEnumerable<IAggregateRootContext> AggregateRoots => aggregateRoots()?.aggregateRoot() ?? Enumerable.Empty<AggregateRootContext>();

            public IEnumerable<IInterfaceDefContext> Interfaces => interfaces()?.interfaceDefs().interfaceDef() ?? Enumerable.Empty<InterfaceDefContext>();
        }

        public partial class AggregateRootContext :
            IAggregateRootContext
        {
            public string Name => name_.GetText();

            public IEnumerable<IClassDefContext> Domain => domain().classDefs().classDef() ?? Enumerable.Empty<ClassDefContext>();

            public IEnumerable<ICommandContext> Commands => commands()?.command() ?? Enumerable.Empty<CommandContext>();

            public IEnumerable<IQueryContext> Queries => queries()?.query() ?? Enumerable.Empty<QueryContext>();
        }

        public partial class CommandContext :
            ICommandContext
        {
            public string Name => name_.GetText();

            public IEnumerable<IPropertyContext> ModelProperties => modelClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();

            public IEnumerable<IPropertyContext> ResultProperties => resultClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();

            public IEnumerable<string> Dependencies => dependencies()?.dependency().Select(d => d.type_.GetText()) ?? Enumerable.Empty<string>();

            public IEnumerable<IPropertyContext> ConfigProperties => configClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();
        }

        public partial class QueryContext :
            IQueryContext
        {
            public string Name => name_.GetText();

            public IEnumerable<IPropertyContext> ModelProperties => modelClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();

            public IEnumerable<IPropertyContext> ResultProperties => resultClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();

            public IEnumerable<string> Dependencies => dependencies()?.dependency().Select(d => d.type_.GetText()) ?? Enumerable.Empty<string>();

            public IEnumerable<IPropertyContext> ConfigProperties => configClassDef()?.classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();
        }

        public partial class ClassDefContext :
            IClassDefContext
        {
            public string Name => name_.GetText();

            public IEnumerable<IPropertyContext> Properties => classBody().properties()?.property() ?? Enumerable.Empty<PropertyContext>();
        }

        public partial class InterfaceDefContext :
            IInterfaceDefContext
        {
            public string Name => name_.GetText();

            public IEnumerable<IMethodContext> Methods => methods().method();
        }

        public partial class PropertyContext :
            IPropertyContext
        {
            public string Name => name_.GetText();

            public string Type => type().GetText();
        }

        public partial class MethodContext :
            IMethodContext
        {
            public string Name => name_.GetText();

            /// <summary>
            /// ReturnType is null when the return type is void.
            /// </summary>
            public string ReturnType => returnType_.type()?.GetText();

            public IEnumerable<IParameterContext> Parameters => parameters()?.parameter() ?? Enumerable.Empty<ParameterContext>();
        }

        public partial class ParameterContext :
            IParameterContext
        {
            public string Name => name_.GetText();

            public string Type => type().GetText();
        }
    }
}
