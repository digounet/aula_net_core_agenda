using Agenda.Domain.Enums;
using Agenda.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.Data.Mappings
{
    public class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("persons");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(p => p.Birthday)
                .HasColumnName("birthday")
                .IsRequired();

            builder.Property(p => p.Gender)
                .HasColumnName("gender")
                .HasConversion(x => x.ToString(), x => (Gender)Enum.Parse(typeof(Gender), x))
                .IsRequired();
        }
    }
}
