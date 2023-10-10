using static Admin.project.Models.Base.Interface.IEntity;

namespace Admin.project.Models.Base.Interface
{
    public interface IAuditEntity : IAuditEntity<int>
    {
        DateTime CreatedDate { get; set; }
        int CreatedUserId { get; set; }
        DateTime? UpdatedDate { get; set; }
        int? UpdatedUserId { get; set; }
    }
    public interface IAuditEntity<T> : IEntity<T>
    {
    }

}