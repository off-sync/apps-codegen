using System.ComponentModel.DataAnnotations;

namespace OffSync.Apps.Codegen.Domain.CodeModels
{
    public class Interface
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Method[] Methods { get; set; }
    }
}
