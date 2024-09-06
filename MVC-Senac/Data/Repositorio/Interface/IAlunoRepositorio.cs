using MVC_Senac.Models;

namespace MVC_Senac.Data.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAluno();
        void InserirAluno(Aluno aluno);
        Aluno BuscarId(int id);
        void EditarAluno(Aluno aluno);

        void ExcluirAluno(Aluno aluno);
    }
}
