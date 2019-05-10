using System.ComponentModel.DataAnnotations;

namespace OffSync.Apps.Codegen.Domain.CodeModels
{
    public class Interface
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Method[] Methods { get; set; }

        /// <summary>
        /// Properties on interfaces are implemented with only a getter. 
        /// This can be used for Config definitions for example.
        /// </summary>
        [Required]
        public NamedType[] Properties { get; set; }
    }
}
