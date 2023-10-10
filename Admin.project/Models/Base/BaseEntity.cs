using Admin.project.Models.Base.Interface;
using System.Security.Principal;
using static Admin.project.Models.Base.Interface.IEntity;

namespace Admin.project.Models.Base
{
    public class BaseEntity<T> : IEntity<T>
    {
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class BaseEntity : BaseEntity<int>, IEntity, IEntity<int>
    {

    }
    public class AuditEntity<T> : BaseEntity<T>, IEntity<T>, IAuditEntity<T>
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
    }
    public class AuditEntity : AuditEntity<int>, IAuditEntity, IAuditEntity<int>, IEntity, IEntity<int>
    {
    }
    public class SoftDeleteEntity<T> : BaseEntity<T>, IEntity<T>, ISoftDeleteEntity<T>
    {
        public DateTime? DateOfDeleted { get; set; }
        public int? DeletedUserId { get; set; }
    }
    public class SoftDeleteEntity : SoftDeleteAuditEntity<int>, ISoftDeleteEntity, ISoftDeleteEntity<int>, IEntity, IEntity<int>
    {
    }
    public class SoftDeleteAuditEntity<T> : BaseEntity<T>, IEntity<T>, ISoftDeleteEntity<T>, IAuditEntity<T>
    {
        public DateTime? DateOfDeleted { get; set; }
        public int? DeletedUserId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
    }
    public class SoftDeleteAuditEntity : SoftDeleteAuditEntity<int>, IEntity, IEntity<int>, ISoftDeleteEntity, ISoftDeleteEntity<int>, IAuditEntity, IAuditEntity<int>
    {
    }
}
