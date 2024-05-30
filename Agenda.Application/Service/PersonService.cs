using Agenda.Application.Interface;
using Agenda.Application.Repository;
using Agenda.Application.ViewModel;
using Agenda.Domain.Models;

namespace Agenda.Application.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPhoneRepository _phoneRepository;

        public PersonService(IPersonRepository personRepository, IPhoneRepository phoneRepository)
        {
            _personRepository = personRepository;
            _phoneRepository = phoneRepository;
        }

        public void AddPerson(PersonViewModel personViewModel, PhoneViewModel phoneViewModel)
        {
            var personId = Guid.NewGuid();
            var person = new Person(personId, personViewModel.Name, personViewModel.Birthday, personViewModel.Gender);
            var phone = new Phone(Guid.NewGuid(), personId, personViewModel.PhoneNumber);
            _personRepository.Add(person);
            _phoneRepository.Add(phone);
            person.PhoneNumbers.Add(new Phone(Guid.NewGuid(), personId, personViewModel.PhoneNumber));


        }

        public void UpdatePerson(PersonViewModel personViewModel)
        {
            var person = new Person(personViewModel.Id, personViewModel.Name, personViewModel.Birthday, personViewModel.Gender);
            _personRepository.Update(person);
        }

        public void RemovePerson(Guid id)
        {
            var person = _personRepository.GetById(id);
            _personRepository.Remove(person);
        }

        public List<PersonViewModel> GetPersons()
        {
            var persons = _personRepository.Get();
            var response = new List<PersonViewModel>();
            foreach (var person in persons)
            {
                response.Add(new PersonViewModel
                {
                    Id = person.Id,
                    Name = person.Name,
                    Birthday = person.Birthday,
                });
            }


            return response;
        }

        public PersonViewModel GetPersonById(Guid id)
        {
            var person = _personRepository.GetById(id); 
            return new PersonViewModel
            {
                Id = person.Id,
                Name = person.Name,
                Birthday = person.Birthday,
                Gender = person.Gender
            };  
        }
    }
}
