using Agenda.Domain.Models;

namespace Agenda.Application.Repository
{
    public interface IPersonRepository
    {
        void Add(Person person);
        void Remove(Person person);
        void Update(Person person);
        Person? GetById(Guid id);
        List<Person> Get();
    }
}
