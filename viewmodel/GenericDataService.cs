using Abituria.controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace Abituria.viewmodel
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject//class
    {
        private readonly SimpleDbContextFactory mcontextFactory;
        private readonly NonQueryDataService<T> mnonQueryDataService;
        public GenericDataService(SimpleDbContextFactory contextFactory)
        {
            this.mcontextFactory = contextFactory;
            mnonQueryDataService = new NonQueryDataService<T>(contextFactory);
        }
        public async Task<T> Create(T entity)// => throw new NotImplementedException();
        {
            using(SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                //var createdResult = await context.Set<T>().AddAsync(entity);
                //await context.SaveChangesAsync();
                //e.Entity
                return await mnonQueryDataService.Create(entity);//createdResult.Entity;//createdEntity.Entity;
            }
        }
        public async Task<bool> Delete(int id)// => throw new NotImplementedException();
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                //T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                //context.Set<T>().Remove(entity);
                //await context.SaveChangesAsync();
                //e.Entity
                return await mnonQueryDataService.Delete(id);//true;//createdEntity.Entity;
            }
        }
        public async Task<T> Get(int id)// => throw new NotImplementedException();
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
        }
        public async Task<T> Update(int id, T entity)// => throw new NotImplementedException();
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                //entity.Id = id;
                //context.Set<T>().Update(entity);
                //T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                //context.Set<T>().Remove(entity);
                //await context.SaveChangesAsync();
                //e.Entity
                return await mnonQueryDataService.Update(id, entity);//entity;//true;//createdEntity.Entity;
            }
        }
    }
}
