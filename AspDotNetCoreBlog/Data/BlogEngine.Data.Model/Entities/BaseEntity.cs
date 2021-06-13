using System;

namespace BlogEngine.Data.Model.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateOn { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
