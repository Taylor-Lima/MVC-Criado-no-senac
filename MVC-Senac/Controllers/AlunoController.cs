using Microsoft.AspNetCore.Mvc;
using MVC_Senac.Data.Repositorio.Interface;
using MVC_Senac.Models;

namespace MVC_Senac.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            var aluno = _alunoRepositorio.BuscarAluno();
            return View(aluno);
        }
        public IActionResult AdicionarAluno()
        {
            return View();
        }
        public IActionResult InserirAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.InserirAluno(aluno);


            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
