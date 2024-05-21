using Agenda.Application.Repository;
using Agenda.Domain.Models;

namespace Agenda.Data.Repository
{
    public class PersonRepository: IPersonRepository
    {
        private readonly List<Person> _persons;

        public PersonRepository()
        {
            _persons = new List<Person>();
        }

        public void Add(Person person)
        {
            _persons.Add(person);
        }

        public void Remove(Person person)
        {
            _persons.Remove(person);
        }

        public void Update(Person person)
        {
            var existingPerson = _persons.FirstOrDefault(p => p.Id == person.Id);
            if (existingPerson != null)
            {
                _persons.Remove(existingPerson);
                _persons.Add(person);
            }
        }

        public Person? GetById(Guid id)
        {
            return _persons.FirstOrDefault(p => p.Id == id);
        }

        public List<Person> Get()
        {
            return _persons;
        }
    }
}
