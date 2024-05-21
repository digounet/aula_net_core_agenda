using Agenda.Domain.Models;

namespace Agenda.Data.Repository
{
    public class PhoneRepository
    {
        private readonly List<Phone> _phones;

        public PhoneRepository()
        {
            _phones = new List<Phone>();
        }

        public void Add(Phone phone)
        {
            _phones.Add(phone);
        }

        public void Remove(Phone phone)
        {
            _phones.Remove(phone);
        }

        public void Update(Phone phone)
        {
            var existingPhone = _phones.FirstOrDefault(p => p.Id == phone.Id);
            if (existingPhone != null)
            {
                _phones.Remove(existingPhone);
                _phones.Add(phone);
            }
        }

        public Phone? GetById(Guid id)
        {
            return _phones.FirstOrDefault(p => p.Id == id);
        }

        public List<Phone>? GetByPersonId(Guid personId)
        {
            return _phones.Where(p => p.PersonId == personId).ToList();
        }
    }
}
