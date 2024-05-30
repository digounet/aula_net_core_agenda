using Agenda.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.Data.Mappings
{
    public class PhoneMapping : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable("phones");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.PhoneNumber)
                .HasColumnName("phone_number")
                .IsRequired();

            builder.Property(p => p.PersonId)
                .HasColumnName("person_id")
                .IsRequired();

            builder.HasOne(p => p.Person)
                .WithMany(p => p.PhoneNumbers)
                .HasForeignKey(p => p.PersonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
