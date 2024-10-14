using System.ComponentModel.DataAnnotations;

namespace Projeto_Gerenciador_De_Tarefas.Models
{
    public enum Status
    {
        Inativo,
        Ativo
    }
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        public Status Status { get; set; }
    }
}
