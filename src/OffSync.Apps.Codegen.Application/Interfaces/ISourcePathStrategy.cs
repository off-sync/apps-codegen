using OffSync.Apps.Codegen.Domain.ApplicationModels;
using OffSync.Apps.Codegen.Domain.CodeModels;

namespace OffSync.Apps.Codegen.Application.Interfaces
{
    public interface ISourcePathStrategy
    {
        string GetBasePathForDomain(
            ApplicationModel applicationModel,
            AggregateRoot aggregateRoot);

        string GetBasePathForCommand(
            ApplicationModel applicationModel,
            AggregateRoot aggregateRoot,
            Command command);

        string GetBasePathForQuery(
            ApplicationModel applicationModel,
            AggregateRoot aggregateRoot,
            Query query);

        string GetBasePathForInterface(
            ApplicationModel applicationModel,
            Interface @interface);
    }
}
