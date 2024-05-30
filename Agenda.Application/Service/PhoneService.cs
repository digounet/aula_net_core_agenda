using Agenda.Application.Interface;
using Agenda.Application.Repository;
using Agenda.Application.ViewModel;
using Agenda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.Service
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _phoneRepository;
        private readonly IPersonRepository _personRepository;

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

        public List<PhoneViewModel> GetPhones()
        {
            var phones = _phoneRepository.Get();
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
            
            var phone = new Phone(phoneViewModel.Id, idPessoa, phoneViewModel.PhoneNumber);
            _phoneRepository.Update(phone);
        }


    }
}
