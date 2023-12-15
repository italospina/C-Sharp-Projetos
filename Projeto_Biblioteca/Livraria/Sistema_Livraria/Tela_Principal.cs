using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
  
using System.Data.Sql;
using System.Data.SqlClient;

using Cl_Dal;

namespace Sistema_Livraria
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {

        }
        //chama o Tela_Cadastros_Editoras
        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Cadastros_Editoras Tel_Cad_Edit = new Tela_Cadastros_Editoras();
            this.Hide();
            Tel_Cad_Edit.ShowDialog();
            
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Cadastros_Livros Tel_Cad_Liv = new Tela_Cadastros_Livros();
            this.Hide();
            Tel_Cad_Liv.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Cadastros_Autores Tel_Cad_Aut = new Tela_Cadastros_Autores();
            this.Hide();
            Tel_Cad_Aut.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //apenas teste de conexao
            //SqlConnection con;
            Conexao conexao = new Conexao();
            SqlConnection sqlConn = new SqlConnection();
            
            sqlConn = conexao.obterConexao();
            MessageBox.Show("Conexao Realizada!");

            //removendo
            conexao.fecharConexao(sqlConn);
            MessageBox.Show("Conexao Fechada");
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Sobre Tel_sob = new Tela_Sobre();
            this.Hide();
            Tel_sob.ShowDialog();
        }

        private void autoresToolStripMenuItemAutores_Click(object sender, EventArgs e)
        {
            Tela_Cadastros_Autores Tel_Cad_Aut = new Tela_Cadastros_Autores();
            this.Hide();
            Tel_Cad_Aut.ShowDialog();
        }

        private void livrosToolStripMenuLivros_Click(object sender, EventArgs e)
        {
            Tela_Cadastros_Livros Tel_Cad_Liv = new Tela_Cadastros_Livros();
            this.Hide();
            Tel_Cad_Liv.ShowDialog();
        }

        private void editorasToolStripMenuEditoras_Click(object sender, EventArgs e)
        {
            Tela_Cadastros_Editoras Tel_Cad_Edit = new Tela_Cadastros_Editoras();
            this.Hide();
            Tel_Cad_Edit.ShowDialog();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclas de Atalho: \r\n" +
                            "Tab - Movimentação de atalho pelos botões da tela. \r\n\r\n" +
                            "Campos de textos:\r\n" +
                            "Autores - Atualizar, excluir, adicionar dados de autores.\r\n" +
                            "Editoras - Atualizar, excluir, adicionar dados de editoras. \r\n" +
                            "Livros - Atualizar, excluir, adicionar dados dos livros.. \r\n" +
                            "Sobre - Senha usada pelo usuario. \r\n\r\n" +
                            "Botões:\r\n" +
                            "Sair - Sai da aplicação",
                            "Ajuda",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
