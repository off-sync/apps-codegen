namespace OffSync.Apps.Codegen.Application.Interfaces
{
    public interface ICodeCompiler<in TCompilationUnit>
    {
        string Compile(
            TCompilationUnit compilationUnit);
    }
}
