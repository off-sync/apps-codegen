using System.ComponentModel.DataAnnotations;

using OffSync.Apps.Codegen.Domain.CodeModels;

namespace OffSync.Apps.Codegen.Domain.ApplicationModels
{
    public class Query :
        AbstractExecutable
    {
        [Required]
        public Class Result { get; set; }
    }
}