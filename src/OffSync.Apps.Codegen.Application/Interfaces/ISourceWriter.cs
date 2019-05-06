namespace OffSync.Apps.Codegen.Application.Interfaces
{
    public interface ISourceWriter
    {
        void Write(
            string path,
            string source);
    }
}
