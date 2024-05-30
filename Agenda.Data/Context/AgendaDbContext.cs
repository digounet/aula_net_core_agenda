using Agenda.Data.Mappings;
using Agenda.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Data.Context
{
    public class AgendaDbContext : DbContext
    {
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMapping());
            modelBuilder.ApplyConfiguration(new PhoneMapping());
            base.OnModelCreating(modelBuilder);
                
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
