namespace BlogEngine.Data.Model.Entities
{
    public class Post : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
