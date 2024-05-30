using Agenda.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Agenda.Application.ViewModel
{
    public class PersonDetailViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }

        [DisplayName("Phone")]
        public List<PhoneViewModel> PhoneNumbers { get; set; }
    }
}
