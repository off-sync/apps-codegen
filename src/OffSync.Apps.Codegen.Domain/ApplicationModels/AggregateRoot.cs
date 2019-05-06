using System.ComponentModel.DataAnnotations;

using OffSync.Apps.Codegen.Domain.CodeModels;

namespace OffSync.Apps.Codegen.Domain.ApplicationModels
{
    public class AggregateRoot
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Class[] Domain { get; set; }

        [Required]
        public Command[] Commands { get; set; }

        [Required]
        public Query[] Queries { get; set; }
    }
}