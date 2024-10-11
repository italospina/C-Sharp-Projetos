using Microsoft.AspNetCore.Mvc;
using Modulo_Dio_Api.Context;
using Modulo_Dio_Api.Entities;

namespace Modulo_Dio_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context) 
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(SelecionarPorId), new { id = contato.Id }, contato);
            //return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult SelecionarPorId(int id) 
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return NotFound();

            return Ok(contato);
        }
        [HttpGet("Selecionar Por Nome")]
        public IActionResult SelecioneNome(string nome)
        {
            var contatos = _context.Contatos.Where(x=> x.Nome.Contains(nome));
            return Ok(contatos);
            
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarContato(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletarContato(int id) 
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
