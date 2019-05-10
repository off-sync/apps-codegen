using System.ComponentModel.DataAnnotations;

using OffSync.Apps.Codegen.Domain.CodeModels;

namespace OffSync.Apps.Codegen.Domain.ApplicationModels
{
    public abstract class AbstractExecutable
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Interface[] Dependencies { get; set; }

        [Required]
        public Class Model { get; set; }

        /// <summary>
        /// Optional Config definition. Must only contain properties.
        /// </summary>
        public Interface Config { get; set; }
    }
}
