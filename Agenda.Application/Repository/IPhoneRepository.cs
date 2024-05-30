using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agenda.Domain.Models;

namespace Agenda.Application.Repository
{
    public interface IPhoneRepository
    {       
        void Add(Phone phone);
        void Remove(Phone person);
        void Update(Phone phone);
        Phone? GetById(Guid id);
        List<Phone> Get();
    }
}
