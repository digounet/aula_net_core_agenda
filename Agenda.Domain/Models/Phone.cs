namespace Agenda.Domain.Models
{
    public class Phone : Entity
    {
        public Guid PersonId { get; private set; }
        public string PhoneNumber { get; private set; }
        public virtual Person Person { get; set; }

        public Phone(Guid id, Guid personId, string phoneNumber)
        {
            Id = id;
            PersonId = personId;
            PhoneNumber = phoneNumber;
        }
    }
}
