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
  * `ICodeGenerator<TCompilationUnit>`
    * `TCompilationUnit` GenerateCommand(`Command` command)
    * `TCompilationUnit` GenerateQuery(`Query` query)
    * `TCompilationUnit` GenerateClass(`Class` @class)
    * `TCompilationUnit` GenerateInterface(`Interface` @interface)
  * `ISourcePathStrategy`
    * `string` GetBasePathForDomain(`ApplicationModel` applicationModel, `AggregateRoot` aggregateRoot)
    * `string` GetBasePathForCommand(`ApplicationModel` applicationModel, `AggregateRoot` aggregateRoot, `Command` command)
    * `string` GetBasePathForQuery(`ApplicationModel` applicationModel, `AggregateRoot` aggregateRoot, `Query` query)
    * `string` GetPathForInterface(`ApplicationModel` applicationModel, `Interface` @interface)
  * `ISourceWriter<TCompilationUnit>`
    * `void` Write(`string` path, `TCompilationUnit` source)

## OffSync.Apps.Codegen.Infra.PlantUml

* `PlantUmlAntlrModelParser`

## OffSync.Apps.Codegen.Infra.EnvDte

* `EnvDteSourceWriter`
