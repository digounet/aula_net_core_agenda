using Agenda.Application.ViewModel;

namespace Agenda.Application.Interface
{
    public interface IPersonService
    {
        public void AddPerson(PersonViewModel personViewModel, PhoneViewModel phoneViewModel);

        public void UpdatePerson(PersonViewModel personViewModel);

        public void RemovePerson(Guid id);

        public List<PersonViewModel> GetPersons();

        public PersonViewModel GetPersonById(Guid id);
    }
}
