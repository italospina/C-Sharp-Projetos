using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cl_Dal;
using Cl_Model;

namespace Cl_Bll
{
    public class EditorasBll
    {
        static void Main() { }

        private EditorasDal editorasDal;

        //contrutor
        public EditorasBll()
        {
            editorasDal = new EditorasDal();
        }

        public void inserir(EditorasModel parEditoras)
        {
            try
            {
                if (editorasDal.obterNumeroEditorasSigla(parEditoras.Sigla) > 0)
                {
                    throw new Exception("BLL: Já existe uma editora com a Sigla informada!");
                }
                else
                {
                    editorasDal.inserir(parEditoras);
                }
            }
            catch (Exception Erro_Bll_01)
            {
                throw new Exception(Erro_Bll_01.Message);
            }
        }

        public void atualizar(EditorasModel parEditoras)
        {
            editorasDal.atualizar(parEditoras);
        }

        public void excluir(int parIdEditoras)
        {
            editorasDal.excluir(parIdEditoras);
        }

        public DataTable listarTodos()
        {
            return editorasDal.listarTodos();
        }

        public List<EditorasModel> listarTodosArray()
        {
            return editorasDal.listarTodosArray();
        }
    }
}
