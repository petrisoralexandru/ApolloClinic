using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ApolloClinic.DataAccess.Data;
using ApolloClinic.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApolloClinic.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _database;
        internal DbSet<T> dbSet;

        public Repository(AppDbContext database)
        {
            _database = database;
            dbSet = _database.Set<T>();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;

            query = query.Where(filter);

            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
