using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AnimalSpawnContext _context;
        private readonly DbSet<T> _entity;
        private readonly object _entities;

        public SQLRepository(AnimalSpawnContext context)
        {
            this._context = context;
            this._entity = context.Set<T>();

        }

        public async Task Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity");
            await _entities.AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            if (id <= 0) throw new ArgumentNullException("Entity");
            var entity = await GetById(id);
            _entities.Remove(entity);

        }

        public async Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _entities.Where(expression).AsNoTracking().AsEnumerable();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return _entities.AsNoTracking().AsEnumerable();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity");
            if (entity.Id <= 0) throw new ArgumentNullException("Entity");
            _entities.Update(entity);


        }
    }
}
