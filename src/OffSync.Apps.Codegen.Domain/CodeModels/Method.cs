using System.ComponentModel.DataAnnotations;

namespace OffSync.Apps.Codegen.Domain.CodeModels
{
    public class Method
    {
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// If the ReturnType is null, this means that the method does not return
        /// a value. (I.e. is a void method.)
        /// </summary>
        public string ReturnType { get; set; }

        [Required]
        public NamedType[] Parameters { get; set; }
    }
}