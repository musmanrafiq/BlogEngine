using BlogEngine.Data.Model.Enums;

namespace BlogEngine.Data.Model.Entities
{
    public class Prompt : BaseEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public PromptType PromptType { get; set; }
    }
}
