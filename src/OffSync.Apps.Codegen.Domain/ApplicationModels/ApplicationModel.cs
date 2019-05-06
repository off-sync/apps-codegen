using System.ComponentModel.DataAnnotations;

using OffSync.Apps.Codegen.Domain.CodeModels;

namespace OffSync.Apps.Codegen.Domain.ApplicationModels
{
    public class ApplicationModel
    {
        [Required]
        public string Namespace { get; set; }

        [Required]
        public AggregateRoot[] AggregateRoots { get; set; }

        [Required]
        public Interface[] Interfaces { get; set; }
    }
}
