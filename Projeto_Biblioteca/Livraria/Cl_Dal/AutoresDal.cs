using Cl_Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cl_Dal
{
    public class AutoresDal
    {
        private SqlConnection _conexaoAutores;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public AutoresDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoAutores = _conexaoBanco.obterConexao();
        }
        public int obterNumeroAutoresPseudonimo(String parPseudonimo)
        {
            int id = 0;
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText = "select count(aut_id) num" +
                                          "  from tblAutores" +
                                          " where aut_pseudonimo = @aut_pseudonimo";
                _comandoSql.Parameters.Add("", SqlDbType.VarChar).Value = parPseudonimo;

                id = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

                return id;
            }
            catch (Exception Erro_Dal_01)
            {
                return -1;
                throw new Exception(Erro_Dal_01.Message);
            }
        }

        private int obterProximoId()
        {
            int id = 0;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText = "select isnull (max(aut_id), 0) + 1 as id" +
                                          "  from tblAutores";
                id = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

                return id;
            }
            catch (Exception ex_ed_dal_1)
            {
                return -1;
                throw new Exception(ex_ed_dal_1.Message);
            }
        }

        /*
         insere os dados usando o AutoresModel com parametro parAutores
        */
        public void inserir(AutoresModel parAutores)
        {
            int id = obterProximoId();

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText = "insert into tblAutores (aut_id, aut_nome, aut_pseudonimo, aut_observacoes)    " +
                                          "                 values (@aut_id, @aut_nome, @aut_pseudonimo, @aut_observacoes)";
                _comandoSql.Parameters.Add("@aut_id", SqlDbType.Int).Value = id;
                _comandoSql.Parameters.Add("@aut_nome", SqlDbType.VarChar).Value = parAutores.Nome;
                _comandoSql.Parameters.Add("@aut_pseudonimo", SqlDbType.VarChar).Value = parAutores.Pseudonimo;
                _comandoSql.Parameters.Add("@aut_observacoes", SqlDbType.VarChar).Value = parAutores.Observacoes;
                _comandoSql.ExecuteNonQuery();

            }
            catch (Exception ex_ed_dal_2)
            {
                throw new Exception(ex_ed_dal_2.Message);
            }
        }

        /*
            atualiza os dados  usando o EditorasModel com parametro parEditoras
        */
        public void atualizar(AutoresModel parAutores)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores; 
                _comandoSql.CommandText = "update tblAutores                         " +
                                          "   set aut_id = @aut_id,                  " +
                                          "       aut_nome = @aut_nome,              " +
                                          "       aut_pseudonimo = @aut_pseudonimo,  " +
                                          "       aut_observacoes = @aut_observacoes " +
                                          " where aut_id = @aut_id                   ";
                _comandoSql.Parameters.Add("@aut_id", SqlDbType.Int).Value = parAutores.Id;
                _comandoSql.Parameters.Add("@aut_nome", SqlDbType.VarChar).Value = parAutores.Nome;
                _comandoSql.Parameters.Add("@aut_pseudonimo", SqlDbType.VarChar).Value = parAutores.Pseudonimo;
                _comandoSql.Parameters.Add("@aut_observacoes", SqlDbType.VarChar).Value = parAutores.Observacoes;
                _comandoSql.ExecuteNonQuery();

            }
            catch (Exception ex_ed_dal_3)
            {
                throw new Exception(ex_ed_dal_3.Message);
            }
        }
        /*
            exclui os dados  usando o EditorasModel com parametro parEditoras
        */
        public void excluir(int parCodigoAutores)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText = "delete from tblAutores" +
                                          " where aut_id = @aut_id";

                _comandoSql.Parameters.Add("@aut_id", SqlDbType.Int).Value = parCodigoAutores;
                _comandoSql.ExecuteNonQuery();

            }
            catch (Exception ex_ed_dal_4)
            {
                throw new Exception(ex_ed_dal_4.Message);
            }
        }

        public DataTable listarTodos()
        {
            DataTable tabela;
            SqlDataAdapter adaptador;
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText = "select aut_id, aut_nome, aut_pseudonimo, aut_observacoes " +
                                          " from tblAutores" +
                                          " order by aut_nome asc";
                tabela = new DataTable();
                adaptador = new SqlDataAdapter(_comandoSql);
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception ex_ed_dal_4)
            {
                return null;
                throw new Exception(ex_ed_dal_4.Message);
            }
        }

        public List<AutoresModel> listarTodosArray()
        {
            List<AutoresModel> lista = new List<AutoresModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText = "select aut_id, aut_nome, aut_pseudonimo, aut_observacoes " +
                                          " from tblAutores" +
                                          " order by aut_pseudonimo asc";

                leitor = _comandoSql.ExecuteReader();

                while (leitor.Read())
                {

                    AutoresModel itens = new AutoresModel();
                    itens.Id = Convert.ToInt32(leitor["aut_id"]);
                    itens.Nome = leitor["aut_nome"].ToString();
                    itens.Pseudonimo = leitor["aut_pseudonimo"].ToString();
                    itens.Observacoes = leitor["aut_observacoes"].ToString();

                    lista.Add(itens);

                }
                leitor.Close();

                return lista;

            }
            catch (SqlException erro_dal_1)
            {
                return null;
                throw new Exception(erro_dal_1.Message);
            }
        }

    }
}
