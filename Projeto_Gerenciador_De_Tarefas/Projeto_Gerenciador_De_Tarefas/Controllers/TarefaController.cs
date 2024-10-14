using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_Gerenciador_De_Tarefas.Context;
using Projeto_Gerenciador_De_Tarefas.Models;

namespace Projeto_Gerenciador_De_Tarefas.Controllers
{
    public class TarefaController : Controller
    {
        private readonly TarefaContext _context;

        public TarefaController(TarefaContext context)
        {
            _context = context;
        }

        public IActionResult Index() 
        { 
            var contatos = _context.Tarefas.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }

        public IActionResult Editar(int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Editar(Tarefa tarefa)
        {
            var tarefaEditar = _context.Tarefas.Find(tarefa.Id);

            tarefaEditar.Titulo = tarefa.Titulo;
            tarefaEditar.Descricao = tarefa.Descricao;
            tarefaEditar.Data = tarefa.Data;
            tarefaEditar.Status = tarefa.Status;

            _context.Tarefas.Update(tarefaEditar);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
                return RedirectToAction(nameof(Index));

            return View(tarefa);

        }

        public IActionResult Deletar (int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
                return RedirectToAction(nameof(Index));

            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Deletar (Tarefa tarefa)
        {
            var tarefaDeletar = _context.Tarefas.Find(tarefa.Id);

            _context.Tarefas.Remove(tarefaDeletar);
            _context.SaveChanges(); 
            
            return RedirectToAction(nameof(Index));
        }
    }
}
