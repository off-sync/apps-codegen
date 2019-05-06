using System.ComponentModel.DataAnnotations;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Queries.ParseModel
{
    public class ParseModelModel
    {
        [Required]
        public string Input { get; set; }
    }
}
