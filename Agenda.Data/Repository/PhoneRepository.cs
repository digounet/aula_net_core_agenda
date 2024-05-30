using Agenda.Application.Repository;
using Agenda.Data.Context;
using Agenda.Domain.Models;

namespace Agenda.Data.Repository
{
    public class PhoneRepository : Repository<Phone>, IPhoneRepository
    {
        public PhoneRepository(AgendaDbContext context) : base(context)
        {
        }

        public IEnumerable<Phone> GetByPerson(Guid personId)
        {
            return DbSet.Where(x => x.PersonId == personId).ToList();
        }
    }
}
