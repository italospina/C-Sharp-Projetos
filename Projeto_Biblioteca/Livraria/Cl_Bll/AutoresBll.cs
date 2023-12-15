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
    public class AutoresBll
    {
        private AutoresDal autoresDal;

        //contrutor
        public AutoresBll()
        {
            autoresDal = new AutoresDal();
        }

        public void inserir(AutoresModel parAutores)
        {
            try
            {
                if (autoresDal.obterNumeroAutoresPseudonimo(parAutores.Pseudonimo) > 0)
                {
                    throw new Exception("BLL: Já existe uma autor com o pseudonimo informado!");
                }
                else
                {
                    autoresDal.inserir(parAutores);
                }
            }
            catch (Exception Erro_Bll_01)
            {
                throw new Exception(Erro_Bll_01.Message);
            }
        }

        public void atualizar(AutoresModel parAutores)
        {
            autoresDal.atualizar(parAutores);
        }

        public void excluir(int parIdAutores)
        {
            autoresDal.excluir(parIdAutores);
        }

        public DataTable listarTodos()
        {
            return autoresDal.listarTodos();
        }

        public List<AutoresModel> listarTodosArray()
        {
            return autoresDal.listarTodosArray();
        }
    }
}
