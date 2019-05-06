
using OffSync.Apps.Codegen.Domain.CodeModels;

namespace OffSync.Apps.Codegen.Domain.ApplicationModels
{
    public class Command :
        AbstractExecutable
    {
        /// <summary>
        /// Optional Result object definition. If this is null,
        /// the command does not return a result.
        /// </summary>
        public Class Result { get; set; }
    }
}