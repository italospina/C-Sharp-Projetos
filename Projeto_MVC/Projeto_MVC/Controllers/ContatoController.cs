// Importa as dependências necessárias para o projeto, incluindo o ASP.NET Core MVC e os contextos e modelos do projeto.
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_MVC.Context;
using Projeto_MVC.Models;

namespace Projeto_MVC.Controllers
{
    // Define uma classe de controlador chamada ContatoController que herda de Controller.
    public class ContatoController : Controller
    {
        // Declara uma variável privada somente leitura do tipo AgendaContext, usada para acessar o banco de dados.
        private readonly AgendaContext _context;

        // Construtor da classe ContatoController, que recebe um parâmetro do tipo AgendaContext e o atribui à variável _context.
        // O uso de injeção de dependência garante que a instância do contexto do banco de dados seja fornecida automaticamente.
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        // Método que retorna a visualização principal (Index) com a lista de contatos.
        public IActionResult Index()
        {
            // Obtém a lista de contatos do banco de dados e armazena na variável 'contatos'.
            var contatos = _context.Contatos.ToList();
            // Retorna a visualização (View) com a lista de contatos como modelo.
            return View(contatos);
        }

        // Método que retorna a visualização para a criação de um novo contato.
        public IActionResult Criar()
        {
            return View();
        }

        // Método que recebe uma solicitação HTTP POST para criar um novo contato.
        // Ele recebe um objeto 'Contato' como parâmetro.
        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            // Verifica se os dados do modelo são válidos antes de prosseguir com a operação.
            if (ModelState.IsValid)
            {
                // Adiciona o contato ao contexto, marcando-o para ser salvo no banco de dados.
                _context.Contatos.Add(contato);
                // Salva as alterações no banco de dados.
                _context.SaveChanges();

                // Redireciona para a ação 'Index' após a criação do contato com sucesso.
                return RedirectToAction(nameof(Index));
            }
            // Se os dados não forem válidos, retorna a visualização com os dados do contato para que o usuário corrija os erros.
            return View(contato);
        }


        public IActionResult Editar(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return NotFound();

            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var contatoEditar = _context.Contatos.Find(contato.Id);

            contatoEditar.Nome = contato.Nome;
            contatoEditar.Telefone = contato.Telefone;
            contatoEditar.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoEditar);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var contatoDeletar = _context.Contatos.Find(contato.Id);


                _context.Contatos.Remove(contatoDeletar); 
                _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}