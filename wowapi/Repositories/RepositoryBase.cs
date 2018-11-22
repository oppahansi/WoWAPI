using Contracts;
using LazyCache;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using wowapi.Contexts;
using wowapi.Enumerations;

namespace wowapi.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DbContext _repositoryContext { get; set; }
        protected readonly IAppCache _cache;

        public RepositoryBase(DbContext repositoryContext, IAppCache cache)
        {
            _repositoryContext = repositoryContext;
            _cache = cache;
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            IEnumerable<T> result = await _cache.GetOrAddAsync(typeof(T).ToString(), async () =>
            {
                return await _repositoryContext.Set<T>().ToListAsync();
            }, new TimeSpan(12, 0, 0));             
        
            return result;
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, string cacheFiltersString)
        {
            IEnumerable<T> result = await _cache.GetOrAddAsync(cacheFiltersString, async () =>
            {
                return await _repositoryContext.Set<T>().Where(expression).ToListAsync();
            }, new TimeSpan(12, 0, 0));             
        
            return result;
        }

        public async Task<IEnumerable<T>> FindAllByConditionsAsync(List<Func<T, bool>> filters, byte filterType, string cacheFiltersString)
        {
            IEnumerable<T> result = await _cache.GetOrAddAsync(cacheFiltersString, async () =>
            {
                switch(filterType)
                {
                    case (byte)CommonEnums.FilterTypes.ANY:
                        return await _repositoryContext.Set<T>().Where(x => filters.Any(f => f(x))).ToListAsync();
                    default:
                        return await _repositoryContext.Set<T>().Where(x => filters.All(f => f(x))).ToListAsync();
                }
            }, new TimeSpan(12, 0, 0));             
        
            return result;
            
        }

        public void Create(T entity)
        {
            _repositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _repositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _repositoryContext.Set<T>().Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
