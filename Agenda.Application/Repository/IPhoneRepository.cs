using Agenda.Domain.Models;

namespace Agenda.Application.Repository
{
    public interface IPhoneRepository : IRepository<Phone>
    {
        IEnumerable<Phone> GetByPerson(Guid personId);
    }
}
