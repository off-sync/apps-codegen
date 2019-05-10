namespace OffSync.Apps.Codegen.Application.Interfaces
{
    public interface ISourcePathStrategy
    {
        string GetSourcePath(
            string @namespace,
            string name,
            bool isBoilerPlate);
    }
}
