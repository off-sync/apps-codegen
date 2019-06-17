using System;
using System.Collections.Generic;
using System.Linq;

using OffSync.Apps.Codegen.Domain.ApplicationModels;
using OffSync.Apps.Codegen.Domain.CodeModels;
using OffSync.Mapping.Mappert;

using static OffSync.Apps.Codegen.Infra.PlantUml.Antlr.ApplicationsParser;

namespace OffSync.Apps.Codegen.Infra.PlantUml.Common
{
    public class ApplicationContextMapper :
        Mapper<ApplicationContext, ApplicationModel>
    {
        private const string ModelClassName = "Model";

        private const string ResultClassName = "Result";

        private const string ConfigClassName = "Config";

        public ApplicationContextMapper()
        {
            Map(c => c.Title)
                .To(m => m.Namespace);

            #region Code Models
            var propertyMapper = new Mapper<PropertyContext, NamedType>(
                b =>
                {
                    b.Map(c => c.Type)
                        .To(m => m.Type)
                        .Using(ResolveType);
                });

            var classMapper = new Mapper<ClassDefContext, Class>(
                b =>
                {
                    b.MapItems(c => c.Properties)
                        .To(m => m.Properties)
                        .Using(propertyMapper.Map);
                });

            var parameterMapper = new Mapper<ParameterContext, NamedType>(
                b =>
                {
                    b.Map(c => c.Type)
                        .To(m => m.Type)
                        .Using(ResolveType);
                });

            var methodMapper = new Mapper<MethodContext, Method>(
                b =>
                {
                    b.Map(c => c.ReturnType)
                        .To(m => m.ReturnType)
                        .Using(ResolveType);

                    b.MapItems(c => c.Parameters)
                        .To(m => m.Parameters)
                        .Using(parameterMapper.Map);
                });

            var interfaceMapper = new Mapper<InterfaceDefContext, Interface>(
                b =>
                {
                    b.MapItems(c => c.Methods)
                        .To(m => m.Methods)
                        .Using(methodMapper.Map);
                });
            #endregion

            #region Aggregate Roots
            var commandMapper = new Mapper<CommandContext, Command>(
                b =>
                {
                    b.Map(c => c.ModelProperties)
                        .To(m => m.Model)
                        .Using(properties =>
                            new Class()
                            {
                                Name = ModelClassName,
                                Properties = properties
                                    .Select(propertyMapper.Map)
                                    .ToArray(),
                            });

                    b.Map(c => c.ResultProperties)
                        .To(m => m.Result)
                        .Using(properties =>
                            !properties.Any() ?
                                null :
                                new Class()
                                {
                                    Name = ResultClassName,
                                    Properties = properties
                                        .Select(propertyMapper.Map)
                                        .ToArray(),
                                });

                    b.Map(c => c.ConfigProperties)
                        .To(m => m.Config)
                        .Using(properties =>
                            !properties.Any() ?
                                null :
                                new Class()
                                {
                                    Name = ConfigClassName,
                                    Properties = properties
                                        .Select(propertyMapper.Map)
                                        .ToArray(),
                                });
                });

            var queryMapper = new Mapper<QueryContext, Query>(
                b =>
                {
                    b.Map(c => c.ModelProperties)
                        .To(m => m.Model)
                        .Using(properties =>
                            new Class()
                            {
                                Name = ModelClassName,
                                Properties = properties
                                    .Select(propertyMapper.Map)
                                    .ToArray(),
                            });

                    b.Map(c => c.ResultProperties)
                        .To(m => m.Result)
                        .Using(properties =>
                            new Class()
                            {
                                Name = ResultClassName,
                                Properties = properties
                                    .Select(propertyMapper.Map)
                                    .ToArray(),
                            });

                    b.Map(c => c.ConfigProperties)
                        .To(m => m.Config)
                        .Using(properties =>
                            !properties.Any() ?
                                null :
                                new Class()
                                {
                                    Name = ConfigClassName,
                                    Properties = properties
                                        .Select(propertyMapper.Map)
                                        .ToArray(),
                                });
                });

            var aggregateRootMapper = new Mapper<AggregateRootContext, AggregateRoot>(
                b =>
                {
                    b.MapItems(c => c.Domain)
                        .To(m => m.Domain)
                        .Using(classMapper.Map);

                    b.MapItems(c => c.Commands)
                        .To(m => m.Commands)
                        .Using(commandMapper.Map);

                    b.MapItems(c => c.Queries)
                        .To(m => m.Queries)
                        .Using(queryMapper.Map);
                });

            MapItems(c => c.AggregateRoots)
                .To(m => m.AggregateRoots)
                .Using(aggregateRootMapper.Map);
            #endregion

            #region Interfaces
            MapItems(c => c.Interfaces)
                .To(m => m.Interfaces)
                .Using(interfaceMapper.Map);
            #endregion
        }

        private static readonly IReadOnlyDictionary<string, Type> _simpleTypes = new Dictionary<string, Type>()
        {
            { "bool", typeof(bool) },
            { "datetime", typeof(DateTime) },
            { "int", typeof(int) },
            { "string", typeof(string) },
            { "ienumerable", typeof(IEnumerable<>) },
            { "iqueryable", typeof(IQueryable<>) },
        };

        private static Type ResolveType(
            TypeContext type)
        {
            if (type == null)
            {
                return null;
            }

            switch (type)
            {
                case SimpleTypeContext simpleType:
                    return ResolveSimpleType(simpleType.dataType());

                case NullableSimpleTypeContext nullableSimpleType:
                    return ResolveSimpleType(nullableSimpleType.nullableDataType().dataType());

                case ReferenceTypeContext referenceType:
                    return Type.GetType(referenceType.qualifiedId().GetText());

                case GenericTypeContext genericType:
                    return ResolveGenericType(genericType);
            }

            throw new ArgumentException(
                $"unsupported type: '{type}'",
                nameof(type));
        }

        private static Type ResolveSimpleType(
            DataTypeContext dataType) =>
            _simpleTypes[dataType.GetText().ToLowerInvariant()];

        private static Type ResolveGenericType(
            GenericTypeContext genericType)
        {
            var type = ResolveType(genericType.type());

            if (!type.IsGenericTypeDefinition)
            {
                throw new ArgumentException(
                    $"type must be a generic type definition: '{genericType}'",
                    nameof(genericType));
            }

            var typeArguments = genericType
                .typeArguments()
                .type()
                .Select(ResolveType)
                .ToArray();

            return type.MakeGenericType(typeArguments);
        }
    }
}
