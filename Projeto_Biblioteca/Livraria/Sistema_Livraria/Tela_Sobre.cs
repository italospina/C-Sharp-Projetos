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
    public partial class Tela_Sobre : Form
    {
        public Tela_Sobre()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Tela_Principal tela_principal = new Tela_Principal();
            this.Hide();
            tela_principal.ShowDialog();
        }

        private void Tela_Sobre_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
