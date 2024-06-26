﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Agenda.Domain.Enums;

namespace Agenda.Application.ViewModel
{
    public class PersonViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }

        [DisplayName("Phone")]
        public string PhoneNumber { get; set; }
    }
}
