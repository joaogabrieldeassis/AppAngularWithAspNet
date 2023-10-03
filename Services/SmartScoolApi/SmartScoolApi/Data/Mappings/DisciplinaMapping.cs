using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartScoolApi.Domain.DomainModel.Models;

namespace SmartScoolApi.Data.Mappings
{
    public class DisciplinaMapping : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .HasMaxLength(150);

            builder.HasMany(c => c.Alunos)
                .WithMany(c => c.Disciplinas);

            builder.HasOne(c => c.Professor)
                .WithMany(c=>c.Disciplinas);
        }
    }
}
