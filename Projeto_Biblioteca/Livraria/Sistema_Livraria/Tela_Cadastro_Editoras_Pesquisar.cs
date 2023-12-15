using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cl_Dal;
using Cl_Model;

namespace Sistema_Livraria
{
    public partial class Tela_Cadastro_Editoras_Pesquisar : Form
    {
        public Tela_Cadastro_Editoras_Pesquisar()
        {
            InitializeComponent();
        }

        //carrega o Model e o Dal
        public EditorasModel editorasModel;
        private EditorasDal editorasDal;

        private void carregarGrid()
        {
            dataGridView1.DataSource = editorasDal.listarTodosArray();
        }

        private void Tela_Cadastro_Editoras_Pesquisar_Load(object sender, EventArgs e)
        {
            this.editorasModel = new EditorasModel();
            this.editorasModel.Id = 0;
            this.editorasDal = new EditorasDal();
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
            editorasModel.Id          = Int32.Parse(dataGridView1[0, i].Value.ToString());
            editorasModel.Nome        = dataGridView1            [1, i].Value.ToString();
            editorasModel.Sigla       = dataGridView1            [2, i].Value.ToString();
            editorasModel.Observacoes = dataGridView1            [3, i].Value.ToString();
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
            "Código - Id único para identificação da editora.\r\n" +
            "Nome - Nome da editora. \r\n" +
            "Sigla -Sigla usada pela editora. \r\n" +
            "Observações - Observações a serem relatadas pelo usuário. \r\n\r\n" +
            "Botões:\r\n" +
            "Voltar - Volta a tela anterior. \r\n" +
            "Selecionar - Seleciona uma editora para realizar a alteração desejada.",
            "Ajuda",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
}
