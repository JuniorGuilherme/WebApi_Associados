using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.Repositories.Data
{
    public class AssociatedRepository : IAssociatedRepository
    {
        private DataContext dataContext;
        public AssociatedRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(Associated ass)
        {
            dataContext.Entry(ass).State = EntityState.Added;
            dataContext.SaveChanges();
        }
        public List<Associated> GetAll()
        {
            return dataContext.Associated.ToList();
        }
        
        public void Update(Associated ass)
        {            
            dataContext.Entry(ass).State = EntityState.Modified;           
            dataContext.SaveChanges();
        }
        public Associated GetById(int id)
        {
            return dataContext.Associated.SingleOrDefault(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
    }
}