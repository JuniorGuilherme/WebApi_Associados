using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoList.Repositories.Interfaces
{
    public interface IRepositoryBase<Entity>
        where Entity : class
    {
         void Create(Entity obj);
        List<Entity> GetAll();
        void Update(Entity obj);
        Entity GetById(int id);
        void Delete(int id);
        Task <Entity> GetByIdAsync(int id);
        Task <List<Entity>> GetAllAsync();
    }
}