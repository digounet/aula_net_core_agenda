using Agenda.Domain.Models;

namespace Agenda.Application.Repository
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T? GetById(Guid id);
        List<T> Get();
    }
}
