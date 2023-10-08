namespace Admin.project.Models.Base.Interface
{
    public interface IEntity
    {
        public interface IEntity<T>
        {
            public T Id { get; set; }
        }
        public interface IEntity : IEntity<int>
        {

        }
    }
}
