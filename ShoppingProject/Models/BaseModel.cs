using System.Diagnostics.CodeAnalysis;

namespace ShoppingProject.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public int? ModifierUserId { get; set; }
        public virtual UserAccountModels ModifireUserAccout { get; set; }
    }
    public class FullBaseModel: BaseModel
    {
        public int CreatorUserId { get; set; }
        public virtual UserAccountModels CreatorUserAccout { get; set; }
    }
}
