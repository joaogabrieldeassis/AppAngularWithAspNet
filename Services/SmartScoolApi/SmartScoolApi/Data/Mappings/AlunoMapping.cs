using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartScoolApi.Domain.DomainModel.Models;

namespace SmartScoolApi.Data.Mappings
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(c => c.Id);

            builder.OwnsOne(c => c.NomeCompleto, x =>
            {
                x.Property(v => v.Nome)
                .HasMaxLength(150)
                .HasColumnName("Nome");

                x.Property(v => v.Sobrenome)
                .HasMaxLength(150)
                .HasColumnName("Sobre Nome");
            });

            

            builder.HasMany(c => c.Disciplinas)
                .WithMany(c => c.Alunos);
        }
    }    
}
