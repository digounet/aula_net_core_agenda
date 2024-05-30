using Agenda.Application.Interface;
using Agenda.Application.Repository;
using Agenda.Application.ViewModel;
using Agenda.Domain.Models;

namespace Agenda.Application.Service
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _phoneRepository;

        public PhoneService(IPhoneRepository phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }



        public void AddPhone(PhoneViewModel phoneViewModel,Guid idPessoa)
        {
            var Id = Guid.NewGuid();            
            var phone = new Phone(Id, idPessoa, phoneViewModel.PhoneNumber);
            _phoneRepository.Add(phone);   
            
        }

        public PhoneViewModel GetPhoneById(Guid id)
        {
            var phone = _phoneRepository.GetById(id);
            return new PhoneViewModel
            {
                Id = phone.Id,
                PersonId = phone.PersonId,
                PhoneNumber = phone.PhoneNumber,

            };
        }

        public List<PhoneViewModel> GetPhones(Guid personId)
        {
            var phones = _phoneRepository.GetByPerson(personId);
            var response = new List<PhoneViewModel>();
            foreach (var phone in phones)
            {
                response.Add(new PhoneViewModel
                {
                    Id = phone.Id,
                    PersonId = phone.PersonId,
                    PhoneNumber = phone.PhoneNumber,
                });
            }


            return response;
        }

        public void RemovePhone(Guid id)
        {
            var phone = _phoneRepository.GetById(id);
            _phoneRepository.Remove(phone);
        }

        public void UpdatePhone(PhoneViewModel phoneViewModel, Guid idPessoa)
        {
            var existingPhone = _phoneRepository.GetById(phoneViewModel.Id);

            if (existingPhone == null)
            {
                throw new Exception("Phone not found");
            }


            var phone = new Phone(existingPhone.Id, idPessoa, phoneViewModel.PhoneNumber);
            _phoneRepository.Update(phone);
        }


    }
}
