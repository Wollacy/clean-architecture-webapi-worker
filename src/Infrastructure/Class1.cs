using Core.Entities;

namespace Core.Interfaces
{
    public interface IExampleRepository
    {
        Task<IEnumerable<ExampleEntity>> GetAllAsync();
        Task<ExampleEntity> GetByIdAsync(int id);
        Task AddAsync(ExampleEntity entity);
        Task UpdateAsync(ExampleEntity entity);
        Task DeleteAsync(int id);
    }
}
