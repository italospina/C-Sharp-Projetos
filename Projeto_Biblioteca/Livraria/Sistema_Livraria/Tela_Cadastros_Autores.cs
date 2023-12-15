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
    public partial class Tela_Cadastros_Autores : Form
    {
        public Tela_Cadastros_Autores()
        {
            InitializeComponent();
        }

        private AutoresModel autoresModel;
        private AutoresBll autoresBll;

        //botao voltar
        private void btn_Voltar_Click(object sender, EventArgs e)
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
            txt_pseudonimo.Clear();
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
                    autoresBll = new AutoresBll();
                    autoresBll.excluir(int.Parse(txt_id.Text.Trim()));

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
            autoresModel = new AutoresModel();
            autoresBll = new AutoresBll();

            //faz verificacoes de campos nulos
            try
            {
                if (txt_nome.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Digite um nome para a Autor!");
                    txt_nome.Focus();
                }
                else if (txt_pseudonimo.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Digite uma Pseudonimo para o Autor!");
                    txt_pseudonimo.Focus();
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
                            autoresModel.Id = 0;
                            autoresModel.Nome = txt_nome.Text.Trim();
                            autoresModel.Pseudonimo = txt_pseudonimo.Text.Trim();
                            autoresModel.Observacoes = txt_observacao.Text.Trim();

                            autoresBll.inserir(autoresModel);

                            MessageBox.Show("Sucesso - Registro Incluido!",
                                            "Sucesso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            limparTela();
                        }

                        //atualiza dados
                        else
                        {
                            autoresModel.Id = int.Parse(txt_id.Text.Trim());
                            autoresModel.Nome = txt_nome.Text.Trim();
                            autoresModel.Pseudonimo = txt_pseudonimo.Text.Trim();
                            autoresModel.Observacoes = txt_observacao.Text.Trim();
                            autoresBll.atualizar(autoresModel);

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

            catch (Exception erro_cad_aut_01)
            {
                MessageBox.Show(erro_cad_aut_01.Message);
            }
        }

        //botao pesquisar
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Autores_Pesquisar tela_cad_aut_pes = new Tela_Cadastro_Autores_Pesquisar();
            tela_cad_aut_pes.ShowDialog();
            if (tela_cad_aut_pes.autoresModel.Id > 0)
            {
                txt_id.Text = tela_cad_aut_pes.autoresModel.Id.ToString();
                txt_nome.Text = tela_cad_aut_pes.autoresModel.Nome.ToString();
                txt_pseudonimo.Text = tela_cad_aut_pes.autoresModel.Pseudonimo.ToString();
                txt_observacao.Text = tela_cad_aut_pes.autoresModel.Observacoes.ToString();
            }
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
                "Limpar - Limpa todos os campos da tela. \r\n" +
                "Salvar - Salva as informações adicionadas ou modificadas \r\n" +
                "Remover - Exclui os dados relacionado ao autor. \r\n" +
                "Pesquisar - Abre uma tela com todos os autores para que você possa escolher um deles para realizar a alteração desejada.",
                "Ajuda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
