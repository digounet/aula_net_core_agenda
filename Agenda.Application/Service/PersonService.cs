using Agenda.Application.Interface;
using Agenda.Application.Repository;
using Agenda.Application.ViewModel;
using Agenda.Domain.Models;

namespace Agenda.Application.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void AddPerson(PersonViewModel personViewModel)
        {
            var personId = Guid.NewGuid();
            var person = new Person(personId, personViewModel.Name, personViewModel.Birthdy, personViewModel.Gender);
            person.PhoneNumbers.Add(new Phone(Guid.NewGuid(), personId, personViewModel.PhoneNumber));
            _personRepository.Add(person);
        }

        public void UpdatePerson(PersonViewModel personViewModel)
        {
            var person = new Person(personViewModel.Id, personViewModel.Name, personViewModel.Birthdy, personViewModel.Gender);
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
                    Birthdy = person.Birthdy,
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
                Birthdy = person.Birthdy,
            };  
        }
    }
}
