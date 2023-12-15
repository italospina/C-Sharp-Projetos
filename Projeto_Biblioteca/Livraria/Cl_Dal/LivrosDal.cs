using Cl_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_Dal
{
    public class LivrosDal
    {
        private SqlConnection _conexaoLivros;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public LivrosDal() 
        {
            _conexaoBanco = new Conexao();
            _conexaoLivros = _conexaoBanco.obterConexao();
        }

        private int obterProximoID()
        {
            int id = 0;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText = "select isnull(max(liv_id), 0) + 1 as id " +
                                          "  from tblLivros";

                id = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

                return id;

            }
            catch (Exception erro_dal_01)
            {
                return -1;
                throw new Exception(erro_dal_01.Message);
            }
        }

        public void inserir (LivrosModel parLivros)
        {
            int id = obterProximoID();

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText = "insert into tblLivros (liv_id,  liv_nome,  liv_ano_publicacao,  liv_isbn,  liv_observacao,  fk_edi_nome, fk_aut_nome) " +
                                          "              values (@liv_id, @liv_nome, @liv_ano_publicacao, @liv_isbn, @liv_observacao, @fk_edi_nome, @fk_aut_nome)";
                _comandoSql.Parameters.Add("@liv_id"            , SqlDbType.Int).Value = id;
                _comandoSql.Parameters.Add("@liv_nome"          , SqlDbType.VarChar).Value = parLivros.Nome;
                _comandoSql.Parameters.Add("@liv_ano_publicacao", SqlDbType.Int).Value = parLivros.Ano_Publicacao;
                _comandoSql.Parameters.Add("@liv_isbn"          , SqlDbType.Decimal).Value = parLivros.Isbn;
                _comandoSql.Parameters.Add("@liv_observacao"    , SqlDbType.VarChar).Value = parLivros.Observacoes;
                _comandoSql.Parameters.Add("@fk_edi_nome"       , SqlDbType.VarChar).Value = parLivros.Edi_Nome;
                _comandoSql.Parameters.Add("@fk_aut_nome"       , SqlDbType.VarChar).Value = parLivros.Aut_Nome;
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception erro_dal_02)
            {

                throw new Exception(erro_dal_02.Message);
            }
        }

        public void atualizar(LivrosModel parLivros)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText = "update tblLivros " +
                                          " set liv_id=@liv_id, " +
                                          "     liv_nome=@liv_nome, " +
                                          "     liv_ano_publicacao=@liv_ano_publicacao, " +
                                          "     liv_isbn=@liv_isbn, " +
                                          "     liv_observacao=@liv_observacao, " +
                                          "     fk_edi_nome=@fk_edi_nome, " +
                                          "     fk_aut_nome=@fk_aut_nome " +
                                          " where liv_id=@liv_id";

                _comandoSql.Parameters.Add("@liv_id", SqlDbType.Int).Value = parLivros.Id;
                _comandoSql.Parameters.Add("@liv_nome", SqlDbType.VarChar).Value = parLivros.Nome;
                _comandoSql.Parameters.Add("@liv_ano_publicacao", SqlDbType.Int).Value = parLivros.Ano_Publicacao;
                _comandoSql.Parameters.Add("@liv_isbn", SqlDbType.Decimal).Value = parLivros.Isbn;
                _comandoSql.Parameters.Add("@liv_observacao", SqlDbType.VarChar).Value = parLivros.Observacoes;
                _comandoSql.Parameters.Add("@fk_edi_nome", SqlDbType.VarChar).Value = parLivros.Edi_Nome;
                _comandoSql.Parameters.Add("@fk_aut_nome", SqlDbType.VarChar).Value = parLivros.Aut_Nome;
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception erro_dal_03)
            {

                throw new Exception(erro_dal_03.Message);
            }
        }

        public void excluir(int parIdLivros)
        {
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexaoLivros;
            _comandoSql.CommandText = "delete from tblLivros " +
                                      " where liv_id = @liv_id";
            _comandoSql.Parameters.Add("@liv_id", SqlDbType.Int).Value = parIdLivros;
            _comandoSql.ExecuteNonQuery();
        }

        public DataTable listarTodos()
        {
            DataTable tabela;
            SqlDataAdapter adaptador;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText = "select liv_id, liv_nome, liv_ano_publicacao, liv_isbn, fk_edi_nome, fk_aut_nome, liv_observacao " +
                                          "  from tblLivros  " +
                                          "  order by liv_nome;";

                tabela = new DataTable();

                adaptador = new SqlDataAdapter(_comandoSql);
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro_dal_04)
            {

                throw new Exception(erro_dal_04.Message);
            }
        }

        public List<LivrosModel> listarTodosArray()
        {
            List<LivrosModel> lista = new List<LivrosModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText = "select liv_id, liv_nome, liv_ano_publicacao, liv_isbn, fk_edi_nome, fk_aut_nome, liv_observacao " +
                                          "  from tblLivros " +
                                          "  order by fk_aut_nome, liv_ano_publicacao, liv_nome;";

                leitor = _comandoSql.ExecuteReader();

                while (leitor.Read())
                {
                    LivrosModel item    = new LivrosModel();
                    item.Id             = Convert.ToInt32(leitor["liv_id"]);
                    item.Nome           = leitor["liv_nome"].ToString();
                    item.Ano_Publicacao = Convert.ToInt32(leitor["liv_ano_publicacao"]);
                    item.Isbn           = Convert.ToDecimal(leitor["liv_isbn"]);
                    item.Observacoes    = leitor["liv_observacao"].ToString();
                    item.Edi_Nome       = leitor["fk_edi_nome"].ToString();
                    item.Aut_Nome       = leitor["fk_aut_nome"].ToString();

                    lista.Add(item);
                }

                leitor.Close();

                return lista;

            }
            catch (Exception erro_dal_05)
            {

                throw new Exception(erro_dal_05.Message);
            }
        }

    }
}
