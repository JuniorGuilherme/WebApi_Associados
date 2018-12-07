using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;

namespace ToDoList.Repositories.Data
{
    public class DependenteRepository
    {
        private DataContext dataContext;
        public DependenteRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(Dependente dep)
        {
            dataContext.Entry(dep).State = EntityState.Added;
            dataContext.SaveChanges();
        }
        public List<Dependente> GetAll()
        {
            return dataContext.Dependente.ToList();
        }
        
        public void Update(Dependente dep)
        {            
            dataContext.Entry(dep).State = EntityState.Modified;           
            dataContext.SaveChanges();
        }
        public Dependente GetById(int id)
        {
            return dataContext.Dependente.SingleOrDefault(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
    }
}