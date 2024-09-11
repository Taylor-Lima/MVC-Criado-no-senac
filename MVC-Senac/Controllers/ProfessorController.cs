using Microsoft.AspNetCore.Mvc;
using MVC_Senac.Data.Repositorio;
using MVC_Senac.Data.Repositorio.Interface;
using MVC_Senac.Models;

namespace MVC_Senac.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepositorio _professorRepositorio;
        public ProfessorController(IProfessorRepositorio professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }
        public IActionResult Index()
        {
            var professor = _professorRepositorio.BuscarProfessor();
            return View(professor);
        }
        public IActionResult AdicionarProfessor()
        {
            return View();
        }
        public IActionResult InserirProfessor(Professor professor)
        {
            try
            {
                _professorRepositorio.InserirProfessor(professor);


            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int id)
        {
            var professor = _professorRepositorio.BuscarId(id);
            return View(professor);
        }
        public ActionResult EditarProfessor(Professor professor)
        {
            _professorRepositorio.EditarProfessor(professor);
            return RedirectToAction("Index");
        }
        public IActionResult ExcluirProfessor(Professor professor)
        {
            _professorRepositorio.ExcluirProfessor(professor);
            return RedirectToAction("index");
        }
    }
}
