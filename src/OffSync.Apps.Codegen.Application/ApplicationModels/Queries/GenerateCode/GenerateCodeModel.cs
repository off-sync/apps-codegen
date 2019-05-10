using System.ComponentModel.DataAnnotations;

using OffSync.Apps.Codegen.Domain.ApplicationModels;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Queries.GenerateCode
{
    public sealed class GenerateCodeModel
    {
        [Required]
        public ApplicationModel Application { get; set; }
    }
}