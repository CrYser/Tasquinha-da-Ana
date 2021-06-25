namespace PedidosRulote
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNome = new System.Windows.Forms.TextBox();
            this.panelItem = new System.Windows.Forms.Panel();
            this.RBHamburguer = new System.Windows.Forms.RadioButton();
            this.RBCachorro = new System.Windows.Forms.RadioButton();
            this.RBBifana = new System.Windows.Forms.RadioButton();
            this.RBKebab = new System.Windows.Forms.RadioButton();
            this.panelKebab = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.RBBox = new System.Windows.Forms.RadioButton();
            this.RBBoloCaco = new System.Windows.Forms.RadioButton();
            this.RBXL = new System.Windows.Forms.RadioButton();
            this.RBPaoPita = new System.Windows.Forms.RadioButton();
            this.RBMPaoNormal = new System.Windows.Forms.RadioButton();
            this.panelBifana = new System.Windows.Forms.Panel();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.RBCompleta = new System.Windows.Forms.RadioButton();
            this.RBSimples = new System.Windows.Forms.RadioButton();
            this.panelCachorro = new System.Windows.Forms.Panel();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panelHamburguer = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.BTNGravar = new System.Windows.Forms.Button();
            this.ListaEncomenda = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNLerFicheiro = new System.Windows.Forms.Button();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.TXTEncomenda = new System.Windows.Forms.TextBox();
            this.BTNNova = new System.Windows.Forms.Button();
            this.BTNFechar = new System.Windows.Forms.Button();
            this.pre_visualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.Documento = new System.Drawing.Printing.PrintDocument();
            this.BTNImpressao = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelItem.SuspendLayout();
            this.panelKebab.SuspendLayout();
            this.panelBifana.SuspendLayout();
            this.panelCachorro.SuspendLayout();
            this.panelHamburguer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Em nome de:";
            // 
            // TXTNome
            // 
            this.TXTNome.BackColor = System.Drawing.SystemColors.Control;
            this.TXTNome.Location = new System.Drawing.Point(10, 27);
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(124, 22);
            this.TXTNome.TabIndex = 4;
            this.TXTNome.TextChanged += new System.EventHandler(this.TXTNome_TextChanged);
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.RBHamburguer);
            this.panelItem.Controls.Add(this.RBCachorro);
            this.panelItem.Controls.Add(this.RBBifana);
            this.panelItem.Controls.Add(this.RBKebab);
            this.panelItem.Location = new System.Drawing.Point(10, 55);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(124, 108);
            this.panelItem.TabIndex = 8;
            // 
            // RBHamburguer
            // 
            this.RBHamburguer.AutoSize = true;
            this.RBHamburguer.Location = new System.Drawing.Point(3, 81);
            this.RBHamburguer.Name = "RBHamburguer";
            this.RBHamburguer.Size = new System.Drawing.Size(104, 20);
            this.RBHamburguer.TabIndex = 0;
            this.RBHamburguer.TabStop = true;
            this.RBHamburguer.Text = "Hamburguer ";
            this.RBHamburguer.UseVisualStyleBackColor = true;
            this.RBHamburguer.CheckedChanged += new System.EventHandler(this.RBHamburguer_CheckedChanged_1);
            // 
            // RBCachorro
            // 
            this.RBCachorro.AutoSize = true;
            this.RBCachorro.Location = new System.Drawing.Point(3, 55);
            this.RBCachorro.Name = "RBCachorro";
            this.RBCachorro.Size = new System.Drawing.Size(84, 20);
            this.RBCachorro.TabIndex = 0;
            this.RBCachorro.TabStop = true;
            this.RBCachorro.Text = "Cachorro ";
            this.RBCachorro.UseVisualStyleBackColor = true;
            this.RBCachorro.CheckedChanged += new System.EventHandler(this.RBCachorro_CheckedChanged_1);
            // 
            // RBBifana
            // 
            this.RBBifana.AutoSize = true;
            this.RBBifana.Location = new System.Drawing.Point(3, 29);
            this.RBBifana.Name = "RBBifana";
            this.RBBifana.Size = new System.Drawing.Size(67, 20);
            this.RBBifana.TabIndex = 0;
            this.RBBifana.TabStop = true;
            this.RBBifana.Text = "Bifana ";
            this.RBBifana.UseVisualStyleBackColor = true;
            this.RBBifana.CheckedChanged += new System.EventHandler(this.RBBifana_CheckedChanged_1);
            // 
            // RBKebab
            // 
            this.RBKebab.AutoSize = true;
            this.RBKebab.Checked = true;
            this.RBKebab.Location = new System.Drawing.Point(3, 3);
            this.RBKebab.Name = "RBKebab";
            this.RBKebab.Size = new System.Drawing.Size(69, 20);
            this.RBKebab.TabIndex = 0;
            this.RBKebab.TabStop = true;
            this.RBKebab.Text = "Kebab ";
            this.RBKebab.UseVisualStyleBackColor = true;
            this.RBKebab.CheckedChanged += new System.EventHandler(this.RBKebab_Checked);
            // 
            // panelKebab
            // 
            this.panelKebab.Controls.Add(this.radioButton8);
            this.panelKebab.Controls.Add(this.RBBox);
            this.panelKebab.Controls.Add(this.RBBoloCaco);
            this.panelKebab.Controls.Add(this.RBXL);
            this.panelKebab.Controls.Add(this.RBPaoPita);
            this.panelKebab.Controls.Add(this.RBMPaoNormal);
            this.panelKebab.Location = new System.Drawing.Point(10, 174);
            this.panelKebab.Name = "panelKebab";
            this.panelKebab.Size = new System.Drawing.Size(138, 156);
            this.panelKebab.TabIndex = 9;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(3, 55);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(79, 20);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Durum M";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // RBBox
            // 
            this.RBBox.AutoSize = true;
            this.RBBox.Location = new System.Drawing.Point(3, 133);
            this.RBBox.Name = "RBBox";
            this.RBBox.Size = new System.Drawing.Size(49, 20);
            this.RBBox.TabIndex = 0;
            this.RBBox.TabStop = true;
            this.RBBox.Text = "Box";
            this.RBBox.UseVisualStyleBackColor = true;
            // 
            // RBBoloCaco
            // 
            this.RBBoloCaco.AutoSize = true;
            this.RBBoloCaco.Location = new System.Drawing.Point(3, 107);
            this.RBBoloCaco.Name = "RBBoloCaco";
            this.RBBoloCaco.Size = new System.Drawing.Size(106, 20);
            this.RBBoloCaco.TabIndex = 0;
            this.RBBoloCaco.TabStop = true;
            this.RBBoloCaco.Text = "Bolo do caco";
            this.RBBoloCaco.UseVisualStyleBackColor = true;
            // 
            // RBXL
            // 
            this.RBXL.AutoSize = true;
            this.RBXL.Location = new System.Drawing.Point(3, 81);
            this.RBXL.Name = "RBXL";
            this.RBXL.Size = new System.Drawing.Size(83, 20);
            this.RBXL.TabIndex = 0;
            this.RBXL.TabStop = true;
            this.RBXL.Text = "Durum XL";
            this.RBXL.UseVisualStyleBackColor = true;
            // 
            // RBPaoPita
            // 
            this.RBPaoPita.AutoSize = true;
            this.RBPaoPita.Location = new System.Drawing.Point(3, 29);
            this.RBPaoPita.Name = "RBPaoPita";
            this.RBPaoPita.Size = new System.Drawing.Size(76, 20);
            this.RBPaoPita.TabIndex = 0;
            this.RBPaoPita.TabStop = true;
            this.RBPaoPita.Text = "Pão pita";
            this.RBPaoPita.UseVisualStyleBackColor = true;
            // 
            // RBMPaoNormal
            // 
            this.RBMPaoNormal.AutoSize = true;
            this.RBMPaoNormal.Checked = true;
            this.RBMPaoNormal.Location = new System.Drawing.Point(3, 3);
            this.RBMPaoNormal.Name = "RBMPaoNormal";
            this.RBMPaoNormal.Size = new System.Drawing.Size(95, 20);
            this.RBMPaoNormal.TabIndex = 0;
            this.RBMPaoNormal.TabStop = true;
            this.RBMPaoNormal.Text = "Pão normal";
            this.RBMPaoNormal.UseVisualStyleBackColor = true;
            // 
            // panelBifana
            // 
            this.panelBifana.Controls.Add(this.radioButton10);
            this.panelBifana.Controls.Add(this.RBCompleta);
            this.panelBifana.Controls.Add(this.RBSimples);
            this.panelBifana.Location = new System.Drawing.Point(10, 174);
            this.panelBifana.Name = "panelBifana";
            this.panelBifana.Size = new System.Drawing.Size(115, 83);
            this.panelBifana.TabIndex = 11;
            this.panelBifana.Visible = false;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(3, 55);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(106, 20);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.Text = "Bolo do caco";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // RBCompleta
            // 
            this.RBCompleta.AutoSize = true;
            this.RBCompleta.Location = new System.Drawing.Point(3, 29);
            this.RBCompleta.Name = "RBCompleta";
            this.RBCompleta.Size = new System.Drawing.Size(84, 20);
            this.RBCompleta.TabIndex = 0;
            this.RBCompleta.Text = "Completa";
            this.RBCompleta.UseVisualStyleBackColor = true;
            // 
            // RBSimples
            // 
            this.RBSimples.AutoSize = true;
            this.RBSimples.Checked = true;
            this.RBSimples.Location = new System.Drawing.Point(3, 3);
            this.RBSimples.Name = "RBSimples";
            this.RBSimples.Size = new System.Drawing.Size(75, 20);
            this.RBSimples.TabIndex = 0;
            this.RBSimples.TabStop = true;
            this.RBSimples.Text = "Simples";
            this.RBSimples.UseVisualStyleBackColor = true;
            // 
            // panelCachorro
            // 
            this.panelCachorro.Controls.Add(this.radioButton9);
            this.panelCachorro.Controls.Add(this.radioButton1);
            this.panelCachorro.Controls.Add(this.radioButton2);
            this.panelCachorro.Location = new System.Drawing.Point(9, 172);
            this.panelCachorro.Name = "panelCachorro";
            this.panelCachorro.Size = new System.Drawing.Size(139, 84);
            this.panelCachorro.TabIndex = 12;
            this.panelCachorro.Visible = false;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(4, 57);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(140, 20);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.Text = "à Manekas (Duplo)";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Completo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 20);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Simples";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panelHamburguer
            // 
            this.panelHamburguer.Controls.Add(this.radioButton4);
            this.panelHamburguer.Controls.Add(this.radioButton6);
            this.panelHamburguer.Controls.Add(this.radioButton5);
            this.panelHamburguer.Controls.Add(this.radioButton3);
            this.panelHamburguer.Location = new System.Drawing.Point(10, 174);
            this.panelHamburguer.Name = "panelHamburguer";
            this.panelHamburguer.Size = new System.Drawing.Size(112, 111);
            this.panelHamburguer.TabIndex = 11;
            this.panelHamburguer.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 20);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Simples";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 81);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(83, 20);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Text = "à David\'s";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 55);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(106, 20);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Text = "Bolo do caco";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 20);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "Completo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // BTNGravar
            // 
            this.BTNGravar.BackColor = System.Drawing.Color.DarkGray;
            this.BTNGravar.FlatAppearance.BorderSize = 0;
            this.BTNGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGravar.Location = new System.Drawing.Point(391, 364);
            this.BTNGravar.Name = "BTNGravar";
            this.BTNGravar.Size = new System.Drawing.Size(150, 35);
            this.BTNGravar.TabIndex = 15;
            this.BTNGravar.Text = "Gravar Encomenda";
            this.BTNGravar.UseVisualStyleBackColor = false;
            this.BTNGravar.Click += new System.EventHandler(this.BTNGravar_Click);
            // 
            // ListaEncomenda
            // 
            this.ListaEncomenda.BackColor = System.Drawing.SystemColors.Control;
            this.ListaEncomenda.FormattingEnabled = true;
            this.ListaEncomenda.ItemHeight = 16;
            this.ListaEncomenda.Location = new System.Drawing.Point(315, 27);
            this.ListaEncomenda.Name = "ListaEncomenda";
            this.ListaEncomenda.Size = new System.Drawing.Size(290, 260);
            this.ListaEncomenda.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Encomenda";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Silver;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Alface",
            "Batata",
            "Cebola frita",
            "Cebola na chapa",
            "Cenoura",
            "Cogumelos",
            "Milho",
            "Tomate",
            "Molho Ketchup",
            "Molho Maionese",
            "Molho Mostarda",
            "Molho Samurai",
            "Molho de Alho"});
            this.checkedListBox1.Location = new System.Drawing.Point(153, 27);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(147, 238);
            this.checkedListBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingredientes";
            // 
            // BTNLerFicheiro
            // 
            this.BTNLerFicheiro.BackColor = System.Drawing.Color.DarkGray;
            this.BTNLerFicheiro.FlatAppearance.BorderSize = 0;
            this.BTNLerFicheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLerFicheiro.Location = new System.Drawing.Point(262, 364);
            this.BTNLerFicheiro.Name = "BTNLerFicheiro";
            this.BTNLerFicheiro.Size = new System.Drawing.Size(123, 35);
            this.BTNLerFicheiro.TabIndex = 20;
            this.BTNLerFicheiro.Text = "Ler Encomenda";
            this.BTNLerFicheiro.UseVisualStyleBackColor = false;
            this.BTNLerFicheiro.Click += new System.EventHandler(this.BTNLerFicheiro_Click_1);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.BTNLimpar.FlatAppearance.BorderSize = 0;
            this.BTNLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLimpar.Location = new System.Drawing.Point(11, 364);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(114, 35);
            this.BTNLimpar.TabIndex = 21;
            this.BTNLimpar.Text = "Limpar Campos";
            this.BTNLimpar.UseVisualStyleBackColor = false;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click);
            // 
            // TXTEncomenda
            // 
            this.TXTEncomenda.BackColor = System.Drawing.Color.Silver;
            this.TXTEncomenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTEncomenda.Location = new System.Drawing.Point(307, 27);
            this.TXTEncomenda.Multiline = true;
            this.TXTEncomenda.Name = "TXTEncomenda";
            this.TXTEncomenda.Size = new System.Drawing.Size(305, 290);
            this.TXTEncomenda.TabIndex = 22;
            // 
            // BTNNova
            // 
            this.BTNNova.BackColor = System.Drawing.Color.DarkGray;
            this.BTNNova.FlatAppearance.BorderSize = 0;
            this.BTNNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNova.Location = new System.Drawing.Point(131, 364);
            this.BTNNova.Name = "BTNNova";
            this.BTNNova.Size = new System.Drawing.Size(125, 35);
            this.BTNNova.TabIndex = 23;
            this.BTNNova.Text = "Nova Encomenda";
            this.BTNNova.UseVisualStyleBackColor = false;
            this.BTNNova.Click += new System.EventHandler(this.BTNNova_Click);
            // 
            // BTNFechar
            // 
            this.BTNFechar.BackColor = System.Drawing.Color.DarkGray;
            this.BTNFechar.FlatAppearance.BorderSize = 0;
            this.BTNFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNFechar.Location = new System.Drawing.Point(547, 364);
            this.BTNFechar.Name = "BTNFechar";
            this.BTNFechar.Size = new System.Drawing.Size(65, 35);
            this.BTNFechar.TabIndex = 24;
            this.BTNFechar.Text = "Fechar";
            this.BTNFechar.UseVisualStyleBackColor = false;
            this.BTNFechar.Click += new System.EventHandler(this.BTNFechar_Click);
            // 
            // pre_visualizacao
            // 
            this.pre_visualizacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pre_visualizacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pre_visualizacao.ClientSize = new System.Drawing.Size(400, 300);
            this.pre_visualizacao.Enabled = true;
            this.pre_visualizacao.Icon = ((System.Drawing.Icon)(resources.GetObject("pre_visualizacao.Icon")));
            this.pre_visualizacao.Name = "printPreviewDialog1";
            this.pre_visualizacao.Visible = false;
            // 
            // Documento
            // 
            this.Documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Documento_PrintPage);
            // 
            // BTNImpressao
            // 
            this.BTNImpressao.BackColor = System.Drawing.Color.DarkGray;
            this.BTNImpressao.FlatAppearance.BorderSize = 0;
            this.BTNImpressao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNImpressao.Location = new System.Drawing.Point(489, 323);
            this.BTNImpressao.Name = "BTNImpressao";
            this.BTNImpressao.Size = new System.Drawing.Size(123, 35);
            this.BTNImpressao.TabIndex = 25;
            this.BTNImpressao.Text = "Impressão";
            this.BTNImpressao.UseVisualStyleBackColor = false;
            this.BTNImpressao.Click += new System.EventHandler(this.BTNImpressao_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(154, 247);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 20);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Com Ovo (+50 Cent)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(623, 411);
            this.ControlBox = false;
            this.Controls.Add(this.panelBifana);
            this.Controls.Add(this.panelHamburguer);
            this.Controls.Add(this.panelCachorro);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BTNImpressao);
            this.Controls.Add(this.BTNFechar);
            this.Controls.Add(this.BTNNova);
            this.Controls.Add(this.TXTEncomenda);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNLerFicheiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListaEncomenda);
            this.Controls.Add(this.BTNGravar);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.TXTNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelKebab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasquinha da Ana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            this.panelKebab.ResumeLayout(false);
            this.panelKebab.PerformLayout();
            this.panelBifana.ResumeLayout(false);
            this.panelBifana.PerformLayout();
            this.panelCachorro.ResumeLayout(false);
            this.panelCachorro.PerformLayout();
            this.panelHamburguer.ResumeLayout(false);
            this.panelHamburguer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNome;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.RadioButton RBHamburguer;
        private System.Windows.Forms.RadioButton RBCachorro;
        private System.Windows.Forms.RadioButton RBBifana;
        private System.Windows.Forms.RadioButton RBKebab;
        private System.Windows.Forms.Panel panelKebab;
        private System.Windows.Forms.RadioButton RBBox;
        private System.Windows.Forms.RadioButton RBBoloCaco;
        private System.Windows.Forms.RadioButton RBXL;
        private System.Windows.Forms.RadioButton RBPaoPita;
        private System.Windows.Forms.RadioButton RBMPaoNormal;
        private System.Windows.Forms.RadioButton RBCompleta;
        private System.Windows.Forms.RadioButton RBSimples;
        private System.Windows.Forms.Panel panelBifana;
        private System.Windows.Forms.Panel panelCachorro;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panelHamburguer;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button BTNGravar;
        private System.Windows.Forms.ListBox ListaEncomenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNLerFicheiro;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.TextBox TXTEncomenda;
        private System.Windows.Forms.Button BTNNova;
        private System.Windows.Forms.Button BTNFechar;
        private System.Windows.Forms.PrintPreviewDialog pre_visualizacao;
        private System.Drawing.Printing.PrintDocument Documento;
        private System.Windows.Forms.Button BTNImpressao;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}

