namespace OffSync.Apps.Codegen.Application.Interfaces
{
    public interface ISourceWriter<in TCompilationUnit>
    {
        void Write(
            string path,
            TCompilationUnit compilationUnit);
    }
}
