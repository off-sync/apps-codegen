# Off-Sync.com Apps Codegen

## OffSync.Apps.Codegen.Domain

* `ApplicationModels`
  * `ApplicationModel`
    * `AggregateRoot[]` AggregateRoots
    * `Interface[]` Interfaces
  * `AggregateRoot`
    * `string` Name
    * `Class[]` Domain
    * `Executable[]` Commands
    * `Executable[]` Queries
  * `Executable`
    * `string` Name
    * `Interface[]` Dependencies
    * `Class` Model
    * `Class` Result
* `CodeModels`
  * `Class`
    * `string` Name
    * `Property[]` Properties
  * `Interface`
    * `string` Name
    * `Method[]` Methods

## OffSync.Apps.Codegen.Application

* `ApplicationModels`
  * Queries
    * `ParseModel`
  * Commands
    * `GenerateSource`  
* Interfaces
  * `IModelParser`
    * `ApplicationModel` Parse(`string` input)
  * `ITypeResolver`
    * `Type` Resolve(`ApplicationModel` application, `string` type)
  * `ICodeGenerator<TCompilationUnit>`
    * `TCompilationUnit` GenerateCommand(`string` namespace, `Command` command)
    * `TCompilationUnit` GenerateQuery(`string` namespace, `Query` query)
    * `TCompilationUnit` GenerateClass(`string` namespace, `Class` @class)
    * `TCompilationUnit` GenerateInterface(`string` namespace, `Interface` @interface)
  * `ICodeCompiler<TCompilationUnit>`
    * `string` Compile(`TCompilationUnit` compilationUnit)
  * `ISourcePathStrategy`
    * `string` GetBasePathForDomain(`ApplicationModel` applicationModel, `AggregateRoot` aggregateRoot)
    * `string` GetBasePathForCommand(`ApplicationModel` applicationModel, `AggregateRoot` aggregateRoot, `Command` command)
    * `string` GetBasePathForQuery(`ApplicationModel` applicationModel, `AggregateRoot` aggregateRoot, `Query` query)
    * `string` GetPathForInterface(`ApplicationModel` applicationModel, `Interface` @interface)
  * `ISourceWriter`
    * `void` Write(`string` path, `string` source)

## OffSync.Apps.Codegen.Infra.PlantUml

* `PlantUmlAntlrModelParser`

## OffSync.Apps.Codegen.Infra.Roslyn

* `RoslynCodeGenerator`
* `RoslynCodeCompiler`

## OffSync.Apps.Codegen.Infra.EnvDte

* `EnvDteSourcePathStrategy`
* `EnvDteSourceWriter`
