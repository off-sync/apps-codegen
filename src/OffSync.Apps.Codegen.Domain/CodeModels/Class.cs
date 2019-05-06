using System.ComponentModel.DataAnnotations;

namespace OffSync.Apps.Codegen.Domain.CodeModels
{
    public class Class
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public NamedType[] Properties { get; set; }
    }
}
