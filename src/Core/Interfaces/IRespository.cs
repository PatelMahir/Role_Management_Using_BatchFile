public interface IRepository where T : BaseEntity
{
    Task GetByIdAsync(int id);
    Task<IReadOnlyList> ListAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
