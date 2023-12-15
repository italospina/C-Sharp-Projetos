using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Class_Dal
{
    public class Conexao
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private String _stringConexao = "Data Source=WINDOWS_SQL\\ITALO; " +
                                        "Initial Catalog=Projeto_App_SQL_SERVER; " +
                                        "Integrated Security=True; ";

        public SqlConnection obterConexao()
        {
            try
            {
                _conexao = new SqlConnection(_stringConexao);
                _conexao.Open();
                return _conexao;
            }
            catch (Exception erro1)
            {
                return null;
                throw new Exception(erro1.Message);
            }
        }

        public void fecharConexao(SqlConnection parConexao)
        {
            try
            {
                if(parConexao == null)
                {
                    if(parConexao.State == ConnectionState.Open)
                    {
                        parConexao.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}