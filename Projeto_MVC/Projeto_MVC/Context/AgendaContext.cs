using Microsoft.EntityFrameworkCore;
using Projeto_MVC.Models;

namespace Projeto_MVC.Context
{
    public class AgendaContext : DbContext//DbContext herda as operações para o banco de dados
    {
        //Construtor
        //Vamos pegar a conexão do banco e passar para o nosso dbcontext que gerencia a conexao bd
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        //Propriedade para entidade contato
        public DbSet<Contato> Contatos { get; set; }
    }

}
