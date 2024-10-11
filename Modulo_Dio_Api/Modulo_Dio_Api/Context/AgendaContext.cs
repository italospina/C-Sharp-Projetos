using Microsoft.EntityFrameworkCore;
using Modulo_Dio_Api.Entities;

namespace Modulo_Dio_Api.Context
{
    public class AgendaContext :DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }   

        public DbSet<Contato> Contatos { get; set; }
    }
}
