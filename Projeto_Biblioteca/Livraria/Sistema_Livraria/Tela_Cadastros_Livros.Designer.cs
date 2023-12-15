namespace Sistema_Livraria
{
    partial class Tela_Cadastros_Livros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Cadastros_Livros));
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.cb_editora = new System.Windows.Forms.ComboBox();
            this.cb_autor = new System.Windows.Forms.ComboBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_ano = new System.Windows.Forms.ComboBox();
            this.btn_ajuda = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(87, 213);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 5;
            this.btn_Voltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btn_Voltar, "Volta ao menu principal");
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Observações:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ISBN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Editora:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Autor:";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(411, 213);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 21;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_pesquisar, "Abre uma lista para pesquisar todos os itens.");
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(168, 213);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 18;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_limpar, "Limpa o texto em tela");
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(249, 213);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 19;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_salvar, "Salva o conteudo em tela.");
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(330, 213);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 20;
            this.btn_remover.Text = "Remover";
            this.btn_remover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_remover, "Remove o dado atual da tela.");
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // cb_editora
            // 
            this.cb_editora.DisplayMember = "Nome";
            this.cb_editora.FormattingEnabled = true;
            this.cb_editora.Items.AddRange(new object[] {
            ""});
            this.cb_editora.Location = new System.Drawing.Point(203, 81);
            this.cb_editora.Name = "cb_editora";
            this.cb_editora.Size = new System.Drawing.Size(151, 21);
            this.cb_editora.TabIndex = 22;
            this.cb_editora.Text = " ";
            this.cb_editora.ValueMember = "id";
            // 
            // cb_autor
            // 
            this.cb_autor.DisplayMember = "Pseudonimo";
            this.cb_autor.FormattingEnabled = true;
            this.cb_autor.Location = new System.Drawing.Point(360, 81);
            this.cb_autor.Name = "cb_autor";
            this.cb_autor.Size = new System.Drawing.Size(124, 21);
            this.cb_autor.TabIndex = 23;
            this.cb_autor.ValueMember = "Id";
            this.cb_autor.SelectedIndexChanged += new System.EventHandler(this.cb_autor_SelectedIndexChanged);
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(9, 81);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(188, 20);
            this.txt_isbn.TabIndex = 24;
            // 
            // txt_observacao
            // 
            this.txt_observacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_observacao.Location = new System.Drawing.Point(12, 120);
            this.txt_observacao.Multiline = true;
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.Size = new System.Drawing.Size(472, 75);
            this.txt_observacao.TabIndex = 27;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nome.Location = new System.Drawing.Point(88, 42);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(299, 20);
            this.txt_nome.TabIndex = 26;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(9, 42);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(73, 20);
            this.txt_id.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ano de Publicação:";
            // 
            // cb_ano
            // 
            this.cb_ano.FormattingEnabled = true;
            this.cb_ano.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900",
            "1899",
            "1898",
            "1897",
            "1896",
            "1895",
            "1894",
            "1893",
            "1892",
            "1891",
            "1890",
            "1889",
            "1888",
            "1887",
            "1886",
            "1885",
            "1884",
            "1883",
            "1882",
            "1881",
            "1880",
            "1879",
            "1878",
            "1877",
            "1876",
            "1875",
            "1874",
            "1873",
            "1872",
            "1871",
            "1870",
            "1869",
            "1868",
            "1867",
            "1866",
            "1865",
            "1864",
            "1863",
            "1862",
            "1861",
            "1860",
            "1859",
            "1858",
            "1857",
            "1856",
            "1855",
            "1854",
            "1853",
            "1852",
            "1851",
            "1850",
            "1849",
            "1848",
            "1847",
            "1846",
            "1845",
            "1844",
            "1843",
            "1842",
            "1841",
            "1840",
            "1839",
            "1838",
            "1837",
            "1836",
            "1835",
            "1834",
            "1833",
            "1832",
            "1831",
            "1830",
            "1829",
            "1828",
            "1827",
            "1826",
            "1825",
            "1824",
            "1823",
            "1822",
            "1821",
            "1820",
            "1819",
            "1818",
            "1817",
            "1816",
            "1815",
            "1814",
            "1813",
            "1812",
            "1811",
            "1810",
            "1809",
            "1808",
            "1807",
            "1806",
            "1805",
            "1804",
            "1803",
            "1802",
            "1801",
            "1800",
            "1799",
            "1798",
            "1797",
            "1796",
            "1795",
            "1794",
            "1793",
            "1792",
            "1791",
            "1790",
            "1789",
            "1788",
            "1787",
            "1786",
            "1785",
            "1784",
            "1783",
            "1782",
            "1781",
            "1780",
            "1779",
            "1778",
            "1777",
            "1776",
            "1775",
            "1774",
            "1773",
            "1772",
            "1771",
            "1770",
            "1769",
            "1768",
            "1767",
            "1766",
            "1765",
            "1764",
            "1763",
            "1762",
            "1761",
            "1760",
            "1759",
            "1758",
            "1757",
            "1756",
            "1755",
            "1754",
            "1753",
            "1752",
            "1751",
            "1750",
            "1749",
            "1748",
            "1747",
            "1746",
            "1745",
            "1744",
            "1743",
            "1742",
            "1741",
            "1740",
            "1739",
            "1738",
            "1737",
            "1736",
            "1735",
            "1734",
            "1733",
            "1732",
            "1731",
            "1730",
            "1729",
            "1728",
            "1727",
            "1726",
            "1725",
            "1724",
            "1723",
            "1722",
            "1721",
            "1720",
            "1719",
            "1718",
            "1717",
            "1716",
            "1715",
            "1714",
            "1713",
            "1712",
            "1711",
            "1710",
            "1709",
            "1708",
            "1707",
            "1706",
            "1705",
            "1704",
            "1703",
            "1702",
            "1701",
            "1700",
            "1699",
            "1698",
            "1697",
            "1696",
            "1695",
            "1694",
            "1693",
            "1692",
            "1691",
            "1690",
            "1689",
            "1688",
            "1687",
            "1686",
            "1685",
            "1684",
            "1683",
            "1682",
            "1681",
            "1680"});
            this.cb_ano.Location = new System.Drawing.Point(393, 41);
            this.cb_ano.Name = "cb_ano";
            this.cb_ano.Size = new System.Drawing.Size(91, 21);
            this.cb_ano.TabIndex = 29;
            // 
            // btn_ajuda
            // 
            this.btn_ajuda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajuda.ImageKey = "INTERROGACAO.png";
            this.btn_ajuda.ImageList = this.imageList1;
            this.btn_ajuda.Location = new System.Drawing.Point(12, 213);
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
            // Tela_Cadastros_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(505, 248);
            this.Controls.Add(this.btn_ajuda);
            this.Controls.Add(this.cb_ano);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_observacao);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.cb_autor);
            this.Controls.Add(this.cb_editora);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Cadastros_Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::SysLib - Cadastro de Livros::";
            this.Load += new System.EventHandler(this.Tela_Cadastros_Livros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.ComboBox cb_editora;
        private System.Windows.Forms.ComboBox cb_autor;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_ano;
        private System.Windows.Forms.Button btn_ajuda;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}