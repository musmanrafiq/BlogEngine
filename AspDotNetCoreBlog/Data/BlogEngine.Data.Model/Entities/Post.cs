namespace BlogEngine.Data.Model.Entities
{
    public class Post : BaseEntity
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public string Content { get; set; }
    }
}
