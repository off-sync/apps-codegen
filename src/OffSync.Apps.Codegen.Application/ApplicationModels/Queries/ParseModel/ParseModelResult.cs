using System.ComponentModel.DataAnnotations;

using OffSync.Apps.Codegen.Domain.ApplicationModels;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Queries.ParseModel
{
    public class ParseModelResult
    {
        [Required]
        public ApplicationModel ApplicationModel { get; set; }
    }
}
