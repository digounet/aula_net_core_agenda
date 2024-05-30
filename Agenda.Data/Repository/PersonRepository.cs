using Agenda.Application.Repository;
using Agenda.Data.Context;
using Agenda.Domain.Enums;
using Agenda.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Data.Repository
{
    public class PersonRepository: Repository<Person>, IPersonRepository
    {
        public PersonRepository(AgendaDbContext context) : base(context)
        {
            
        }

        public Person? GetById(Guid id)
        {
            return DbSet
                .Include(x => x.PhoneNumbers)
                .FirstOrDefault(p => p.Id == id);
        }

        public List<Person> GetByGender(Gender gender)
        {
            throw new NotImplementedException();
        }
    }
}
