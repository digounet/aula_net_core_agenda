using Agenda.Domain.Enums;

namespace Agenda.Domain.Models
{
    public class Person
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public DateTime Birthdy { get; private set; }
        public Gender Gender { get; private set; }
        public List<Phone> PhoneNumbers { get; set; }
        public Person(Guid id, string name, DateTime birthdy, Gender gender)
        {
            Id = id;
            Name = name;
            Birthdy = birthdy;
            Gender = gender;
            PhoneNumbers = new List<Phone>();
        }

    }
}
