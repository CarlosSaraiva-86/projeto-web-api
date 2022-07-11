using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Data.Interfaces;

namespace Web.Api.Core.Data
{
    public class BaseRepository<T> where T : Entity
    {
        protected readonly DbContext context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(DbContext context)
        {
            this.context = context;
            dbSet = this.context.Set<T>();
        }

        public Task<List<T>> ObterTodos()
        {
            return dbSet.ToListAsync();
        }

        public async Task Adicionar(T model)
        {
            dbSet.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task Excluir(T model)
        {
            dbSet.Remove(model);
            await context.SaveChangesAsync();
        }
    }
}
