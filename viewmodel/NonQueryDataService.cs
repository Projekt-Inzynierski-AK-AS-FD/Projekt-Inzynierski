using Abituria.controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abituria.viewmodel
{
    public class NonQueryDataService<T> where T : DomainObject///Funkcje DataService bez geterów
    {
        private readonly SimpleDbContextFactory mcontextFactory;

        public NonQueryDataService(SimpleDbContextFactory contextFactory)
        {
            this.mcontextFactory = contextFactory;
        }
        public async Task<T> Create(T entity)// => throw new NotImplementedException();
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                var createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                //e.Entity
                return createdResult.Entity;//createdEntity.Entity;
            }
        }
        public async Task<bool> Delete(int id)// => throw new NotImplementedException();
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                //e.Entity
                return true;//createdEntity.Entity;
            }
        }
        /*public async Task<T> Get(int id)// => throw new NotImplementedException();
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                //context.Set<T>().Remove(entity);
                //await context.SaveChangesAsync();
                //e.Entity
                return entity;//true;//createdEntity.Entity;
            }
        }
        public async Task<IEnumerable<T>> GetAll()// => throw new NotImplementedException();
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();//FirstOrDefaultAsync((e) => e.Id == id);
                //context.Set<T>().Remove(entity);
                //await context.SaveChangesAsync();
                //e.Entity
                return entities;//entity;//true;//createdEntity.Entity;
            }
        }*/
        public async Task<T> Update(int id, T entity)// => throw new NotImplementedException();
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                //T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                //context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                //e.Entity
                return entity;//true;//createdEntity.Entity;
            }
        }
    }
}
