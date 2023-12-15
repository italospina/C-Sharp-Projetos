using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cl_Model
{

    public class AutoresModel
    {
        static void Main() { }

        private int _id;
        private string _nome;
        private string _pseudonimo;
        private string _observacoes;
        
        public int Id 
        {
            get { return _id;  }
            set { _id = value; }
        }

        public string Nome 
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Pseudonimo 
        {
            get { return _pseudonimo; }
            set { _pseudonimo = value;} 
        }

        public string Observacoes 
        {
            get { return _observacoes; }
            set { _observacoes = value;} 
        }

    }
}
