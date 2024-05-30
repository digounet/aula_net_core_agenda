using Agenda.Domain.Enums;
using Agenda.Domain.Models;

namespace Agenda.Application.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        public List<Person> GetByGender(Gender gender);
    }
}
