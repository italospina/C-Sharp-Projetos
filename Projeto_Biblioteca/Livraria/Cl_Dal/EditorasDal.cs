using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cl_Model;

namespace Cl_Dal
{
    public class EditorasDal
    {
        private SqlConnection _conexaoEditoras;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public EditorasDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoEditoras = _conexaoBanco.obterConexao();
        }
        public int obterNumeroEditorasSigla(String parSigla)
        {
            int id = 0;
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText = "select count(edi_id) num" +
                                          "  from tblEditoras"+
                                          " where edi_sigla = @edi_sigla";
                _comandoSql.Parameters.Add("", SqlDbType.VarChar).Value = parSigla;

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
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText = "select isnull (max(edi_id), 0) + 1 as id" +
                                          "  from tblEditoras";
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
         insere os dados usando o EditorasModel com parametro parEditoras
        */
        public void inserir (EditorasModel parEditoras)
        {
            int id = obterProximoId();

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText = "insert into tblEditoras (edi_id, edi_nome, edi_sigla, edi_observacoes)    " +
                                          "                 values (@edi_id, @edi_nome, @edi_sigla, @edi_observacoes)";
                _comandoSql.Parameters.Add("@edi_id", SqlDbType.Int).Value = id;
                _comandoSql.Parameters.Add("@edi_nome", SqlDbType.VarChar).Value = parEditoras.Nome;
                _comandoSql.Parameters.Add("@edi_sigla", SqlDbType.VarChar).Value = parEditoras.Sigla;
                _comandoSql.Parameters.Add("@edi_observacoes", SqlDbType.VarChar).Value = parEditoras.Observacoes;
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
        public void atualizar (EditorasModel parEditoras)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText = "update tblEditoras                        " + 
                                          "   set edi_id = @edi_id,                  " +
                                          "       edi_nome = @edi_nome,              " +
                                          "       edi_sigla = @edi_sigla,            " +
                                          "       edi_observacoes = @edi_observacoes " +
                                          " where edi_id = @edi_id                   ";
                _comandoSql.Parameters.Add("@edi_id", SqlDbType.Int).Value = parEditoras.Id;
                _comandoSql.Parameters.Add("@edi_nome", SqlDbType.VarChar).Value = parEditoras.Nome;
                _comandoSql.Parameters.Add("@edi_sigla", SqlDbType.VarChar).Value = parEditoras.Sigla;
                _comandoSql.Parameters.Add("@edi_observacoes", SqlDbType.VarChar).Value = parEditoras.Observacoes;
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
        public void excluir (int parCodigoEditoras)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText = "delete from tblEditoras" +
                                          " where edi_id = @edi_id" ;

                _comandoSql.Parameters.Add("@edi_id", SqlDbType.Int).Value = parCodigoEditoras;
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
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText = "select edi_id, edi_nome, edi_sigla, edi_observacoes " +
                                          " from tblEditoras"                                    +
                                          " order by edi_nome asc";
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

        public List<EditorasModel> listarTodosArray ()
        {
            List<EditorasModel> lista = new List<EditorasModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText = "select edi_id, edi_nome, edi_sigla, edi_observacoes " +
                                          " from tblEditoras" +
                                          " order by edi_nome asc";

                leitor = _comandoSql.ExecuteReader();

                while (leitor.Read())
                {

                    EditorasModel itens = new EditorasModel();
                    itens.Id = Convert.ToInt32(leitor["edi_id"]);
                    itens.Nome = leitor["edi_nome"].ToString();
                    itens.Sigla = leitor["edi_sigla"].ToString();
                    itens.Observacoes = leitor["edi_observacoes"].ToString();

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
