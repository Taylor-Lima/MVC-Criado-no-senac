using MVC_Senac.Models;

namespace MVC_Senac.Data.Repositorio.Interface
{
    public interface IProfessorRepositorio
    {
        List<Professor> BuscarProfessor();
        void InserirProfessor(Professor professor);
        Professor BuscarId(int id);
        void EditarProfessor(Professor professor);
        void ExcluirProfessor(Professor professor);
    }
}
