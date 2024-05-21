namespace Agenda.Domain.Models
{
    public class Phone
    {
        public Guid Id { get; private set; }
        public Guid PersonId { get; private set; }
        public string PhoneNumber { get; private set; }

        public Phone(Guid id, Guid personId, string phoneNumber)
        {
            Id = id;
            PersonId = personId;
            PhoneNumber = phoneNumber;
        }
    }
}
