using System.ComponentModel.DataAnnotations;

namespace Agenda.Domain.Enums
{
    public enum Gender
    {
        [Display(Name = "Male")]
        MALE,
        [Display(Name = "Female")]
        FEMALE,
        [Display(Name = "Other")]
        OTHER
    }
}
