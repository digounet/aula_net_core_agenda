using Agenda.Domain.Enums;

namespace Agenda.Domain.Models
{
    public class Person
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public DateTime Birthday { get; private set; }
        public Gender Gender { get; private set; }
        public List<Phone> PhoneNumbers { get; set; }//Isso vai levar Id PersonId e PhoneNumber
        public Person(Guid id, string name, DateTime birthday, Gender gender)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            Gender = gender;
            PhoneNumbers = new List<Phone>();
        }

    }
}
