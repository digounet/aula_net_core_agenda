using Agenda.Application.Repository;
using Agenda.Data.Context;
using Agenda.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly AgendaDbContext Db;
        protected readonly DbSet<T> DbSet;

        public Repository(AgendaDbContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
            Db.SaveChanges();
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
            Db.SaveChanges();
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
            Db.SaveChanges();
        }

        public T? GetById(Guid id)
        {
            return DbSet.FirstOrDefault(p => p.Id == id);
        }

        public List<T> Get()
        {
            return DbSet.ToList();
        }
    }
}
