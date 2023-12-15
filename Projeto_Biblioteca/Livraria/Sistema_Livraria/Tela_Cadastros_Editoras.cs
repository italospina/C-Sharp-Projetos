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

using Cl_Bll;
using System.Diagnostics.Eventing.Reader;

namespace Sistema_Livraria
{
    public partial class Tela_Cadastros_Editoras : Form
    {
        public Tela_Cadastros_Editoras()
        {
            InitializeComponent();
        }

        private EditorasModel editorasModel;
        private EditorasBll editorasBll;
        //private string DialogoResultado;
        
        //botao voltar
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Tela_Principal Tel_Princ = new Tela_Principal();
            this.Hide();
            Tel_Princ.ShowDialog();
        }

        /*
        metodos e botao de limpar a tela 
        */
        private void limparTela()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_sigla.Clear();
            txt_observacao.Clear();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limparTela();
            txt_nome.Focus();
        }

        //botao remover
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
                    editorasBll = new EditorasBll();
                    editorasBll.excluir(int.Parse(txt_id.Text.Trim()));

                    MessageBox.Show("Sucesso - Registro exluido com sucesso!",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    limparTela();
                }
            }
        }

        //botao salvar
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            editorasModel = new EditorasModel();
            editorasBll = new EditorasBll();

            //faz verificacoes de campos nulos
            try
            {
                if (txt_nome.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Digite um nome para a Editora!");
                    txt_nome.Focus();
                }
                else if (txt_sigla.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Digite uma sigla para a Editora!");
                    txt_sigla.Focus();
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
                            editorasModel.Id = 0;
                            editorasModel.Nome = txt_nome.Text.Trim();
                            editorasModel.Sigla = txt_sigla.Text.Trim();
                            editorasModel.Observacoes = txt_observacao.Text.Trim();

                            editorasBll.inserir(editorasModel);

                            MessageBox.Show("Sucesso - Registro Incluido!",
                                            "Sucesso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            limparTela();
                        }

                        //atualiza dados
                        else
                        {
                            editorasModel.Id = int.Parse(txt_id.Text.Trim());
                            editorasModel.Nome = txt_nome.Text.Trim();
                            editorasModel.Sigla = txt_sigla.Text.Trim();
                            editorasModel.Observacoes = txt_observacao.Text.Trim();
                            editorasBll.atualizar(editorasModel);

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

        //botao pesquisar
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Editoras_Pesquisar tela_cad_edi_pes = new Tela_Cadastro_Editoras_Pesquisar();
            tela_cad_edi_pes.ShowDialog();
            if (tela_cad_edi_pes.editorasModel.Id > 0)
            {
                txt_id.Text = tela_cad_edi_pes.editorasModel.Id.ToString();
                txt_nome.Text = tela_cad_edi_pes.editorasModel.Nome.ToString();
                txt_sigla.Text = tela_cad_edi_pes.editorasModel.Sigla.ToString();
                txt_observacao.Text = tela_cad_edi_pes.editorasModel.Observacoes.ToString();
            }
        }

        private void Tela_Cadastros_Editoras_Load(object sender, EventArgs e)
        {

        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclas de Atalho: \r\n" +
                "Tab - Movimentação de atalho pelos botões da tela. \r\n\r\n" +
                "Campos da tabela:\r\n" +
                "Código - Id único para identificação do editora.\r\n" +
                "Nome - Nome da editora. \r\n" +
                "Sigla - Sigla da editora. \r\n" +
                "Observações - Observações a serem relatadas pela editora. \r\n\r\n" +
                "Botões:\r\n" +
                "Voltar - Volta a tela anterior. \r\n" +
                "Limpar - Limpa todos os campos da tela. \r\n" +
                "Salvar - Salva as informações adicionadas ou modificadas \r\n" +
                "Remover - Exclui os dados relacionado ao autor. \r\n" +
                "Pesquisar - Abre uma tela com todos as editoras para que você possa escolher um deles para realizar a alteração desejada.",
                "Ajuda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
