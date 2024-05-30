using Agenda.Domain.Enums;

namespace Agenda.Domain.Models
{
    public class Person : Entity
    {
 
        public string Name { get; private set; }
        public DateTime Birthday { get; private set; }
        public Gender Gender { get; private set; }
        public virtual List<Phone> PhoneNumbers { get; set; }
        public Person(Guid id, string name, DateTime birthday, Gender gender)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            Gender = gender;
        }

    }
}
