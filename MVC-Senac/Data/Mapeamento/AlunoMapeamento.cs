using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MVC_Senac.Models;

namespace MVC_Senac.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

           builder.HasKey(t => t.Id);

            builder.Property(t => t.Matricula).HasColumnType("varchar(10)");
            builder.Property(t => t.Nome).HasColumnType("varchar(40)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(14)");

        }
    }
}

//CREATE TABLE Aluno (

//Id INT IDENTITY(1,1) NOT NULL,

//Matricula VARCHAR(10) NOT NULL,

//Nome VARCHAR(40) NOT NULL,

//Cpf VARCHAR(14) NULL

//PRIMARY KEY(Id)

//)
 