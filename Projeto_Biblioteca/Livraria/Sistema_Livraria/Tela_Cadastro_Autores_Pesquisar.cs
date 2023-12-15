using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cl_Bll;
using Cl_Dal;
using Cl_Model;


namespace Sistema_Livraria
{
    public partial class Tela_Cadastro_Autores_Pesquisar : Form
    {
        public Tela_Cadastro_Autores_Pesquisar()
        {
            InitializeComponent();
        }

        //carrega o Model e o Dal
        public AutoresModel autoresModel;
        private AutoresDal autoresDal;

        private void carregarGrid()
        {
            dataGridView1.DataSource = autoresDal.listarTodosArray();
        }

        private void Tela_Cadastro_Autores_Pesquisar_Load(object sender, EventArgs e)
        {
            this.autoresModel = new AutoresModel();
            this.autoresModel.Id = 0;
            this.autoresDal = new AutoresDal();
            this.carregarGrid();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        metodo e botao selecionar 
        */
        private void selecionarItem()
        {
            Int32 i = 0;

            i = dataGridView1.CurrentRow.Index;
            autoresModel.Id = Int32.Parse(dataGridView1[0, i].Value.ToString());
            autoresModel.Nome = dataGridView1[1, i].Value.ToString();
            autoresModel.Pseudonimo = dataGridView1[2, i].Value.ToString();
            autoresModel.Observacoes = dataGridView1[3, i].Value.ToString();
        }
        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            this.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclas de Atalho: \r\n" +
            "Tab - Movimentação de atalho pelos botões da tela. \r\n\r\n" +
            "Campos da tabela:\r\n" +
            "Código - Id único para identificação do autor.\r\n" +
            "Nome - Nome do autor. \r\n" +
            "Pseudonimo - Nome adotado pelo autor que não usa o seu nome civil verdadeiro. \r\n" +
            "Observações - Observações a serem relatadas pelo usuário. \r\n\r\n" +
            "Botões:\r\n" +
            "Voltar - Volta a tela anterior. \r\n" +
            "Selecionar - Seleciona um autor para realizar a alteração desejada.",
            "Ajuda",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
}
