using static Admin.project.Models.Base.Interface.IEntity;

namespace Admin.project.Models.Base.Interface
{
    public interface ISoftDeleteEntity<T> : IEntity<T>
    {
        DateTime? DateOfDeleted { get; set; }
        int? DeletedUserId { get; set; }
    }
    public interface ISoftDeleteEntity : ISoftDeleteEntity<int>, IEntity<int>
    {
    }
}
