using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Livraria
{
    public partial class Tela_Login : Form
    {
        //1.0 - Processo de inicialização
        public Tela_Login()
        {
            InitializeComponent();
        }

        //1.1Carregamento do Forms
        private void Tela_Login_Load(object sender, EventArgs e)
        {
            //pré definicao de comandos
            /*
              mudar conforme o seu ambiente 
              txt_servidor = Seu Data_Source (servidor)
              txt_bd = Seu nome do banco de dados
            */

            this.txt_servidor.Text = "WINDOWS_SQL\\ITALO";
            this.txt_bd.Text = "Projeto_App_SQL_SERVER";

            //1.2 String para analise do passo 1.3 - ConfiguracaoBancoDados.txt salva as informações de usuario e senha nesse path
            string path = @"C:\Users\estud\source\repos\Livraria\Sistema_Livraria\bin\Debug\ConfiguracaoBancoDados.txt";

            //1.3 - Verifica se ja existe um arquivo salvo para o sistema
            bool fileExist = File.Exists(path);
            if (fileExist)
            {
                try
                {
                    StreamReader arquivo = new StreamReader("ConfiguracaoBancoDados.txt");
                    txt_usuario.Text = arquivo.ReadLine();
                    txt_senha.Text = arquivo.ReadLine();
                    arquivo.Close();
                }
                catch (SqlException erro_Login_1)
                {
                    MessageBox.Show(erro_Login_1 + "Erro ao se conectar ao banco de dados \n" +
                                    "Acesse as configurações do banco de dados e informe os parametros corretos");
                }
            }
            else
            {
                Console.WriteLine("Arquivo não existe no sistema!");
            }
        }

        //1.4 - Botão de salvar as informações de senha e usuario (fiz por preguiça de sempre ter que digitar)
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBancoDados.txt", false);
                arquivo.WriteLine(txt_usuario.Text);
                arquivo.WriteLine(txt_senha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo Atualizado com sucesso!");
            }
            catch (SqlException erro_Login_2)
            {
                MessageBox.Show(erro_Login_2.Message);
            }
        }

        //1.5 Esconder / Ver Senha
        private void btn_hide_Click(object sender, EventArgs e)
        {
            btn_eye.BringToFront();
            txt_senha.UseSystemPasswordChar = false;
        }

        private void btn_eye_Click(object sender, EventArgs e)
        {
            btn_hide.BringToFront();
            txt_senha.UseSystemPasswordChar = true;

        }

        //1.6 -Acesso no sistema
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source="+ txt_servidor.Text +"; Initial Catalog="+txt_bd.Text+ "; User ID=" + txt_usuario.Text + ";Password=" + txt_senha.Text;
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                
                Tela_Principal Form_Menu = new Tela_Principal();
                this.Hide();
                Form_Menu.ShowDialog();
            }
            catch (SqlException erro_Login_1)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + "Verifique os dados informados" + erro_Login_1);
            }
        }

        //sai do app
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclas de Atalho: \r\n" +
                            "Tab - Movimentação de atalho pelos campos de texto e botões da tela. \r\n\r\n" +
                            "Campos de textos:\r\n" +
                            "Servidor - Campo bloqueado que indica o sevidor localizado o banco de dados.\r\n" +
                            "Banco de Dados - Campo bloqueado que indica o nome do banco de dados. \r\n" +
                            "Usuario - Usuario usado para acesso do banco de dados. \r\n" +
                            "Senha - Senha usada pelo usuario. \r\n\r\n" +
                            "Botões:\r\n" +
                            "Login - Acesso a aplicação. \r\n" +
                            "Salvar - Salva as informações de usuario e senha para um proximo login. \r\n" +
                            "Sair - Sai da aplicação",
                            "Ajuda",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
