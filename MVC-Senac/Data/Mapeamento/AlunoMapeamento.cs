using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MVC_Senac.Models;

namespace MVC_Senac.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Matricula).HasColumnType("varchar(7)");
            builder.Property(t => t.Nome).HasColumnType("varchar(255)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(14)");

        }
    }
}
