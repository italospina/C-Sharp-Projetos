using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_Model
{
    public class EditorasModel
    {
        private int _id;
        private string _nome;
        private string _sigla;
        private string _observacoes;

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

        public string Sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }

        public string Observacoes
        {
            get { return _observacoes; }
            set { _observacoes = value; }
        }
    }
}
