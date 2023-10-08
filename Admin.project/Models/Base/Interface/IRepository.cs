using static Admin.project.Models.Base.Interface.IEntity;

namespace Admin.project.Models.Base.Interface
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<bool> RemoveAsync(int id);
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> UpdateAsync(int Id, TEntity entity);
    }
}
