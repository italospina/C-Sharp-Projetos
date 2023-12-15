using Cl_Bll;
using Cl_Dal;
using Cl_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Livraria
{
    public partial class Tela_Cadastros_Livros : Form
    {
        private LivrosDal livrosDal;
        private AutoresDal autoresDal;
        private EditorasDal editorasDal;
        private LivrosModel livrosModel;
        private LivrosBll livrosBll;

        public Tela_Cadastros_Livros()
        {
            InitializeComponent();
        }

        private void carregarComboAutores()
        {
            cb_editora.DataSource = editorasDal.listarTodosArray();
            cb_autor.DataSource = autoresDal.listarTodosArray();
        }

        private void carregarComboEditores()
        {
            cb_editora.DataSource = editorasDal.listarTodosArray();
        }

        private void Tela_Cadastros_Livros_Load(object sender, EventArgs e)
         {
            autoresDal = new AutoresDal();
            editorasDal = new EditorasDal();
            livrosModel = new LivrosModel();
            carregarComboAutores();
            carregarComboEditores();
            limparTela();

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Livros_Pesquisar tel_cad_liv_pes = new Tela_Cadastro_Livros_Pesquisar();
            tel_cad_liv_pes.ShowDialog();

            if (tel_cad_liv_pes.livrosModel.Id > 0)
            {
                txt_id.Text = tel_cad_liv_pes.livrosModel.Id.ToString();
                txt_nome.Text = tel_cad_liv_pes.livrosModel.Nome.ToString();
                cb_ano.Text = tel_cad_liv_pes.livrosModel.Ano_Publicacao.ToString();
                txt_isbn.Text = tel_cad_liv_pes.livrosModel.Isbn.ToString();
                cb_editora.Text = tel_cad_liv_pes.livrosModel.Edi_Nome.ToString();
                cb_autor.Text = tel_cad_liv_pes.livrosModel.Aut_Nome.ToString();
                txt_observacao.Text = tel_cad_liv_pes.livrosModel.Observacoes.ToString();
            }

        }

        private void limparTela()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_isbn.Clear();
            txt_observacao.Clear();
            cb_ano.SelectedValue = 0;
            cb_editora.SelectedValue = 0;
            cb_autor.SelectedValue = 0;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            livrosModel = new LivrosModel();
            livrosBll = new LivrosBll();

            //faz verificacoes de campos nulos
            try
            {
                if (txt_nome.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Digite um nome para o livro!");
                    txt_nome.Focus();
                }
                else if (cb_ano.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Selecione o ano que o livro foi escrito!");
                    cb_ano.Focus();
                }
                else if (txt_isbn.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Digite o isbn do livro!");
                    txt_isbn.Focus();
                }
                

                //pergunta se usuario quer salvar
                else
                {
                    DialogResult dialogoResultado = MessageBox.Show("Aviso - Tem certeza que deseja salvar?",
                                                                    "Aviso",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Question);
                    if (dialogoResultado == DialogResult.Yes)
                    {
                        //insere dados
                        if (txt_id.Text.Trim() == String.Empty)
                        {
                            livrosModel.Id = 0;
                            livrosModel.Nome = txt_nome.Text.Trim();
                            livrosModel.Ano_Publicacao = int.Parse(cb_ano.Text.Trim());
                            livrosModel.Isbn = Decimal.Parse(txt_isbn.Text.Trim());
                            livrosModel.Edi_Nome = cb_editora.Text.Trim();
                            livrosModel.Aut_Nome = cb_autor.Text.Trim();
                            livrosModel.Observacoes = txt_observacao.Text.Trim();

                            livrosBll.inserir(livrosModel);

                            MessageBox.Show("Sucesso - Registro Incluido!",
                                            "Sucesso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            limparTela();
                        }

                        //atualiza dados
                        else
                        {
                            livrosModel.Id = int.Parse(txt_id.Text.Trim());
                            livrosModel.Nome = txt_nome.Text.Trim();
                            livrosModel.Ano_Publicacao = int.Parse(cb_ano.Text.Trim());
                            livrosModel.Isbn = Decimal.Parse(txt_isbn.Text.Trim());
                            livrosModel.Edi_Nome = cb_editora.Text.Trim();
                            livrosModel.Aut_Nome = cb_autor.Text.Trim();
                            livrosModel.Observacoes = txt_observacao.Text.Trim();

                            livrosBll.atualizar(livrosModel);

                            MessageBox.Show("Sucesso - Registro Atualizado!",
                                            "Sucesso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            limparTela();
                        }
                    }

                    //cancela a operacao
                    else
                    {
                        MessageBox.Show("Cancelado - Registro Cancelado!",
                                        "Cancelado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }

            catch (Exception erro_cad_edit_01)
            {
                MessageBox.Show(erro_cad_edit_01.Message);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Sem sucesso - Nenhum Registro Incluido!",
                                "Sem sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogoResultado = MessageBox.Show("Aviso - Os dados serão excluidos permanentemente.Tem certeza que deseja remover?",
                                                                "Aviso",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question);
                if (dialogoResultado == DialogResult.Yes)
                {
                    livrosBll = new LivrosBll();
                    livrosBll.excluir(int.Parse(txt_id.Text.Trim()));

                    MessageBox.Show("Sucesso - Registro exluido com sucesso!",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    limparTela();
                }
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Tela_Principal Tel_Princ = new Tela_Principal();
            this.Hide();
            Tel_Princ.ShowDialog();

        }

        private void cb_autor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclas de Atalho: \r\n" +
                "Tab - Movimentação de atalho pelos campos de texto e botões da tela. \r\n\r\n" +
                "Campos de textos:\r\n" +
                "Código - Id único para identificação do livro.\r\n" +
                "Nome - Nome do livro. \r\n" +
                "Ano de publicação - Ano de publicação do livro. \r\n" +
                "ISBN - Número Padrão Internacional de Livro \r\n" +
                "Editora - Nome da editora do livro. \r\n" +
                "Autor - Nome do autor que escreveu o livro. \r\n" +
                "Observações - Observações a serem relatadas pelo usuário. \r\n\r\n" +
                "Botões:\r\n" +
                "Voltar - Volta a tela anterior. \r\n" +
                "Limpar - Limpa todos os campos da tela. \r\n" +
                "Salvar - Salva as informações adicionadas ou modificadas \r\n" +
                "Remover - Exclui os dados relacionado ao autor. \r\n" +
                "Pesquisar - Abre uma tela com todos os livros para que você possa escolher um deles para realizar a alteração desejada.",
                "Ajuda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
