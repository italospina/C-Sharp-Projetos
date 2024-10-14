using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_Gerenciador_De_Tarefas.Models;


namespace Projeto_Gerenciador_De_Tarefas.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }

    

}
