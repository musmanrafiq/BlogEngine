using BlogEngine.Data.Model.Enums;

namespace BlogEngine.Business.Models
{
    public class PromptModel : BaseEntityModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public PromptType PromptType { get; set; }
    }
}
