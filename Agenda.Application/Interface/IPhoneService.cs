using Agenda.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.Interface
{
    public interface IPhoneService
    {
        public void AddPhone(PhoneViewModel phoneViewModel,Guid idPessoa);

        public void UpdatePhone(PhoneViewModel phoneViewModel, Guid idPessoa);

        public void RemovePhone(Guid id);

        public List<PhoneViewModel> GetPhones();

        public PhoneViewModel GetPhoneById(Guid id);
    }
}
