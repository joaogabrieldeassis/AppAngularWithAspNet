using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartScoolApi.Domain.Models;

namespace SmartScoolApi.Data.Mappings
{
    public class ProfessorMapping : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .HasMaxLength(150);            

            builder.HasMany(c => c.Disciplinas)
                .WithOne(c => c.Professor);
        }
    }
}
