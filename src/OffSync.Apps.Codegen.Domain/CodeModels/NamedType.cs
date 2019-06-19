using System.ComponentModel.DataAnnotations;

namespace OffSync.Apps.Codegen.Domain.CodeModels
{
    public class NamedType
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }
    }
}