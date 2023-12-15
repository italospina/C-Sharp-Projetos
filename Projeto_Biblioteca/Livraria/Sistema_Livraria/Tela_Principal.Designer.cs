namespace Sistema_Livraria
{
    partial class Tela_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.Stp_Menu = new System.Windows.Forms.MenuStrip();
            this.autoresToolStripMenuItemAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuEditoras = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuLivros = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_livro = new System.Windows.Forms.PictureBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ajuda = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Stp_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_livro)).BeginInit();
            this.SuspendLayout();
            // 
            // Stp_Menu
            // 
            this.Stp_Menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Stp_Menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Stp_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItemAutores,
            this.editorasToolStripMenuEditoras,
            this.livrosToolStripMenuLivros,
            this.sobreToolStripMenuItem});
            this.Stp_Menu.Location = new System.Drawing.Point(0, 0);
            this.Stp_Menu.Name = "Stp_Menu";
            this.Stp_Menu.ShowItemToolTips = true;
            this.Stp_Menu.Size = new System.Drawing.Size(459, 24);
            this.Stp_Menu.TabIndex = 1;
            this.Stp_Menu.TabStop = true;
            this.Stp_Menu.Text = "Menu";
            // 
            // autoresToolStripMenuItemAutores
            // 
            this.autoresToolStripMenuItemAutores.Name = "autoresToolStripMenuItemAutores";
            this.autoresToolStripMenuItemAutores.Size = new System.Drawing.Size(60, 20);
            this.autoresToolStripMenuItemAutores.Text = "Autores";
            this.autoresToolStripMenuItemAutores.ToolTipText = "Adicione, exclua, atualize ou verifique os dados referentes aos autores.";
            this.autoresToolStripMenuItemAutores.Click += new System.EventHandler(this.autoresToolStripMenuItemAutores_Click);
            // 
            // editorasToolStripMenuEditoras
            // 
            this.editorasToolStripMenuEditoras.Name = "editorasToolStripMenuEditoras";
            this.editorasToolStripMenuEditoras.Size = new System.Drawing.Size(61, 20);
            this.editorasToolStripMenuEditoras.Text = "Editoras";
            this.editorasToolStripMenuEditoras.ToolTipText = "Adicione, exclua, atualize ou verifique os dados referentes as editoras.";
            this.editorasToolStripMenuEditoras.Click += new System.EventHandler(this.editorasToolStripMenuEditoras_Click);
            // 
            // livrosToolStripMenuLivros
            // 
            this.livrosToolStripMenuLivros.Name = "livrosToolStripMenuLivros";
            this.livrosToolStripMenuLivros.Size = new System.Drawing.Size(50, 20);
            this.livrosToolStripMenuLivros.Text = "Livros";
            this.livrosToolStripMenuLivros.ToolTipText = "Adicione, exclua, atualize ou verifique os dados referentes aos livros.";
            this.livrosToolStripMenuLivros.Click += new System.EventHandler(this.livrosToolStripMenuLivros_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.ToolTipText = "Verifique informações da aplicação.";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seja Bem Vindo ao Sistema de Livraria SysLib.\r\nPara prosseguir selecione uma das " +
    "opções do menu acima!\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pic_livro
            // 
            this.pic_livro.Image = global::Sistema_Livraria.Properties.Resources.f4bbe191bcc833b27d7fa241220c470e_logotipo_do_livro_na_tela2;
            this.pic_livro.Location = new System.Drawing.Point(110, 78);
            this.pic_livro.Name = "pic_livro";
            this.pic_livro.Size = new System.Drawing.Size(203, 200);
            this.pic_livro.TabIndex = 1;
            this.pic_livro.TabStop = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(372, 250);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 23;
            this.btn_Sair.TabStop = false;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_Sair, "Sair da Aplicação");
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_ajuda
            // 
            this.btn_ajuda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajuda.ImageKey = "INTERROGACAO.png";
            this.btn_ajuda.ImageList = this.imageList1;
            this.btn_ajuda.Location = new System.Drawing.Point(12, 250);
            this.btn_ajuda.Name = "btn_ajuda";
            this.btn_ajuda.Size = new System.Drawing.Size(29, 23);
            this.btn_ajuda.TabIndex = 32;
            this.btn_ajuda.Text = "\r\n";
            this.toolTip1.SetToolTip(this.btn_ajuda, "Ajuda - Informações sobre a tela.");
            this.btn_ajuda.UseVisualStyleBackColor = false;
            this.btn_ajuda.Click += new System.EventHandler(this.btn_ajuda_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "3593455.png");
            this.imageList1.Images.SetKeyName(1, "INTERROGACAO.png");
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(459, 285);
            this.Controls.Add(this.btn_ajuda);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_livro);
            this.Controls.Add(this.Stp_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Stp_Menu;
            this.MaximizeBox = false;
            this.Name = "Tela_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::SysLib - Sistema de Livraria::";
            this.Load += new System.EventHandler(this.Tela_Principal_Load);
            this.Stp_Menu.ResumeLayout(false);
            this.Stp_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_livro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Stp_Menu;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_livro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItemAutores;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuEditoras;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuLivros;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_ajuda;
        private System.Windows.Forms.ImageList imageList1;
    }
}

