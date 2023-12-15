using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_Model
{
    public class LivrosModel
    {
        private int _id;
        private string _nome;
        private int _ano_publicacao;
        private decimal _isbn;
        private string _observacoes;
        private string _edi_nome;
        private string _aut_nome;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Ano_Publicacao
        {
            get { return _ano_publicacao; }
            set { _ano_publicacao = value; }
        }

        public decimal Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Observacoes
        {
            get { return _observacoes; }
            set { _observacoes = value; }
        }
        public string Edi_Nome
        {
            get { return _edi_nome; }
            set { _edi_nome = value; }
        }

        public string Aut_Nome
        {
            get { return _aut_nome; }
            set { _aut_nome = value; }
        }
    }
}
