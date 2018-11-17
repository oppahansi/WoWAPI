using Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using wowapi.Entities;
using wowapi.Enumerations;

namespace wowapi.Repository.Classic
{
    public abstract class CRepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected CRepositoryContext RepositoryContext { get; set; }

        public CRepositoryBase(CRepositoryContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await this.RepositoryContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await this.RepositoryContext.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllByConditionsAsync(List<Func<T, bool>> filters, byte filterType)
        {
            switch(filterType)
            {
                case (byte)CommonEnums.FilterTypes.ANY:
                    return await this.RepositoryContext.Set<T>().Where(x => filters.Any(f => f(x))).ToListAsync();
                default:
                    return await this.RepositoryContext.Set<T>().Where(x => filters.All(f => f(x))).ToListAsync();
            }
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public async Task SaveAsync()
        {
            await this.RepositoryContext.SaveChangesAsync();
        }
    }
}
