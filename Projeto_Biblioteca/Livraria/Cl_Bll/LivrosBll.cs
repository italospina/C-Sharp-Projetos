using Cl_Dal;
using Cl_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_Bll
{
    public class LivrosBll
    {
        private LivrosDal livrosDal;

        //contrutor
        public LivrosBll()
        {
            livrosDal = new LivrosDal();
        }

        public void inserir(LivrosModel parLivros)
        {
            livrosDal.inserir(parLivros);
        }

        public void atualizar(LivrosModel parLivros)
        {
            livrosDal.atualizar(parLivros);
        }

        public void excluir(int parIdLivos)
        {
            livrosDal.excluir(parIdLivos);
        }

        public DataTable listarTodos()
        {
            return livrosDal.listarTodos();
        }

        public List<LivrosModel> listarTodosArray()
        {
            return livrosDal.listarTodosArray();
        }
    }
}
