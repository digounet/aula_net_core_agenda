using Agenda.Domain.Enums;

namespace Agenda.Application.ViewModel
{
    public class PersonViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
    }
}
