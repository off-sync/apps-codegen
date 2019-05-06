using OffSync.Apps.Codegen.Domain.ApplicationModels;

namespace OffSync.Apps.Codegen.Application.Interfaces
{
    public interface IModelParser
    {
        ApplicationModel Parse(
            string input);
    }
}
