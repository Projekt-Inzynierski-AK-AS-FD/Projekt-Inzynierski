using Abituria.controls;
using Abituria.datamodels;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Abituria.viewmodel
{
    public class AccountDataService : IDataService<Account>
    {
        public readonly SimpleDbContextFactory mcontextFactory;
        private readonly NonQueryDataService<Account> mnonQueryDataService;
        public AccountDataService(SimpleDbContextFactory contextFactory)
        {
            mcontextFactory = contextFactory;
            mnonQueryDataService = new NonQueryDataService<Account>(contextFactory);
        }
        public async Task<Account> Create(Account entity)
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                //EntityEntry<Account> createdResult = await context.Set<Account>().AddAsync(entity);
                //await context.SaveChangesAsync();
                return await mnonQueryDataService.Create(entity);//createdResult.Entity;
            }
        }
        public async Task<bool> Delete(int id)
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                //Account entity = await context.Set<Account>().FirstOrDefaultAsync((e) => e.Id == id);
                //context.Set<Account>().Remove(entity);
                //await context.SaveChangesAsync();
                return await mnonQueryDataService.Delete(id);//true;
            }
        }
        public async Task<Account> Get(int id)
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                Account entity = await context.Accounts.Include(a => a.CompletedExercises).FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }
        public async Task<IEnumerable<Account>> GetAll()
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                IEnumerable<Account> entities = await context.Accounts.Include(a => a.CompletedExercises).ToListAsync();
                return entities;
            }
        }
        public async Task<Account> Update(int id, Account entity)
        {
            using (SimpleDbContext context = mcontextFactory.CreateDbContext())
            {
                //entity.Id = id;
                //context.Set<Account>().Update(entity);
                //await context.SaveChangesAsync();
                return await mnonQueryDataService.Update(id, entity);//entity;
            } 
        }
    }
}
