namespace OffSync.Apps.Codegen.Domain.CodeModels
{
    public class CodeModel<TCompilationUnit>
    {
        public string Namespace { get; set; }

        public string Name { get; set; }

        public TCompilationUnit CompilationUnit { get; set; }

        /// <summary>
        /// IsBoilerPlate determines whether this code model should only 
        /// be generated if it does not exist already.
        /// </summary>
        public bool IsBoilerPlate { get; set; }
    }
}
