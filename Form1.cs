using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PedidosRulote
{
    public delegate void UpdateTextBoxDelegate(int value);

    public partial class Form1 : Form
    {
        int contagemitens;
        float preco = 0.00f;
        readonly string Tasquinha_da_Ana = System.AppDomain.CurrentDomain.BaseDirectory;
        readonly string dateAndTime = DateTime.Now.ToString("yyyy-MM-dd");

        //===============================================================================================================
        public Form1()
        {
            InitializeComponent();
        }

        //===============================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            BTNNova.Enabled = false;
            BTNLerFicheiro.Enabled = true;
            BTNGravar.Enabled = false;
            BTNImpressao.Enabled = false;
        }

        //===============================================================================================================
        private void BTNGravar_Click(object sender, EventArgs e)
        {
            ListaEncomenda.Items.Add(TXTNome.Text + " - ");

            if (RBKebab.Checked)
            {
                string txt = "";
                txt = panelItem.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                ListaEncomenda.Items.Add(txt);

                string tipokebab = "";
                tipokebab = panelKebab.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                ListaEncomenda.Items.Add(tipokebab);

                switch (panelKebab.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text)
                {
                    case "Durum M":
                        preco += 4.20f;
                        break;
                    case "Durum XL":
                        preco += 5.00f;
                        break;
                    case "Pão normal":
                        preco += 4.10f;
                        break;
                    case "Pão pita":
                        preco += 4.60f;
                        break;
                    case "Bolo do caco":
                        preco += 4.50f;
                        break;
                    case "Box":
                        preco += 4.60f;
                        break;
                }

                AddIngredientes();
            }
            else if (RBBifana.Checked)
            {
                string txt = "";
                txt = panelItem.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                ListaEncomenda.Items.Add(txt);

                string tipobifana = "";
                tipobifana = panelBifana.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                ListaEncomenda.Items.Add(tipobifana);

                switch (panelBifana.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text)
                {
                    case "Simples":
                        preco += 3.30f;
                        break;
                    case "Completa":
                        preco += 4.10f;
                        break;
                    case "Bolo do caco":
                        preco += 3.90f;
                        break;
                }

                AddIngredientes();
            }
            else if (RBCachorro.Checked)
            {
                string txt = "";
                txt = panelItem.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                ListaEncomenda.Items.Add(txt);

                string tipocachorro = "";
                tipocachorro = panelCachorro.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                ListaEncomenda.Items.Add(tipocachorro);

                switch (panelCachorro.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text)
                {
                    case "Simples":
                        preco += 3.30f;
                        break;
                    case "Completo":
                        preco += 4.00f;
                        break;
                    case "à Manekas (Duplo)":
                        preco += 4.90f;
                        break;
                }

                AddIngredientes();
            }
            else if (RBHamburguer.Checked)
            {
                string txt = "";
                txt = panelItem.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                ListaEncomenda.Items.Add(txt);

                string tipohamburguer = "";
                tipohamburguer = panelHamburguer.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                ListaEncomenda.Items.Add(tipohamburguer);

                switch (panelHamburguer.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text)
                {
                    case "Simples":
                        preco += 3.50f;
                        break;
                    case "Completo":
                        preco += 4.10f;
                        break;
                    case "Bolo do caco":
                        preco += 3.90f;
                        break;
                    case "à David's":
                        preco += 4.90f;
                        break;
                }

                AddIngredientes();
            }

            StringBuilder stringB = new StringBuilder();
            foreach (var item in ListaEncomenda.Items)
            {
                stringB.Append(item.ToString());
            }
            TXTEncomenda.Text = (stringB.ToString());
            Gravarficheiro();
            NovaEncomenda();
            BTNLerFicheiro.Enabled = true;
            BTNGravar.Enabled = false;
            BTNNova.Enabled = true;
            BTNLimpar.Enabled = false;
            contagemitens = 0;
        }

        //===============================================================================================================
        private void AddIngredientes()
        {
            ListaEncomenda.Items.Add(" - ");
                
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string s = (string)checkedListBox1.CheckedItems[i];
                ListaEncomenda.Items.Add(s);
                if (contagemitens == checkedListBox1.CheckedItems.Count - 1 && checkBox1.Checked == false)
                    ListaEncomenda.Items.Add(" - ");
                else
                {
                    contagemitens++;
                    ListaEncomenda.Items.Add(", ");
                }
            }

            if (checkBox1.Checked)
            {
                ListaEncomenda.Items.Add("Ovo - ");
                preco += 0.50f;
            }

            ListaEncomenda.Items.Add(preco + "€");
        }

        //===============================================================================================================
        #region Paineis

        //===============================================================================================================
        private void RBKebab_Checked(object sender, EventArgs e)
        {
            if (RBKebab.Checked)
                panelKebab.Visible = true;
            else
                panelKebab.Visible = false;
        }

        //===============================================================================================================
        private void RBBifana_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RBBifana.Checked)
                panelBifana.Visible = true;
            else
                panelBifana.Visible = false;
        }

        //===============================================================================================================
        private void RBCachorro_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RBCachorro.Checked)
                panelCachorro.Visible = true;
            else
                panelCachorro.Visible = false;
        }

        //===============================================================================================================
        private void RBHamburguer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RBHamburguer.Checked)
                panelHamburguer.Visible = true;
            else
                panelHamburguer.Visible = false;
        }
        #endregion

        //===============================================================================================================
        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            Apagarcampos();
            TXTNome.Focus();
            BTNLerFicheiro.Enabled = true;
            BTNGravar.Enabled = false;
        }

        //===============================================================================================================
        private void BTNNova_Click(object sender, EventArgs e)
        {
            Apagarcampos();
            TXTNome.Focus();
        }

        //===============================================================================================================
        private void Apagarcampos()
        {
            ListaEncomenda.Items.Clear();
            TXTEncomenda.Clear();
            TXTNome.Clear();
            preco = 0.00f;
            checkBox1.Checked = false;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
            foreach (Control c in panelItem.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = true;
                }
            }

            foreach (Control c in panelKebab.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = true;
                }
            }

            foreach (Control c in panelBifana.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = true;
                }
            }

            foreach (Control c in panelCachorro.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = true;
                }
            }

            foreach (Control c in panelHamburguer.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = true;
                }
            }

            BTNGravar.Enabled = false;
            BTNLimpar.Enabled = true;
            BTNNova.Enabled = false;
            BTNImpressao.Enabled = false;
        }

        //===============================================================================================================
        private void Gravarficheiro()
        {
            StreamWriter ficheiro = new StreamWriter(Tasquinha_da_Ana + "Encomenda " + dateAndTime + ".txt", true, Encoding.Default);
            ficheiro.WriteLine((string)TXTEncomenda.Text);

            ficheiro.Dispose();
        }

        //===============================================================================================================
        private void BTNFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //===============================================================================================================
        private void TXTNome_TextChanged(object sender, EventArgs e)
        {
            if (TXTNome.Text != "")
                BTNGravar.Enabled = true;
        }

        //===============================================================================================================
        private void BTNLerFicheiro_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(Tasquinha_da_Ana + "Encomenda " + dateAndTime + ".txt"))
            {
                StreamReader ficheiro = new StreamReader(Tasquinha_da_Ana + "Encomenda " + dateAndTime + ".txt", Encoding.Default);
                TXTEncomenda.Text = ficheiro.ReadToEnd();

                ficheiro.Dispose();
                BTNImpressao.Enabled = true;
                BTNLimpar.Enabled = true;
                BTNGravar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não há nenhuma encomenda criada para o dia de hoje");
            }
        }

        //===============================================================================================================
        private void BTNImpressao_Click(object sender, EventArgs e)
        {
            pre_visualizacao.Document = Documento;
            pre_visualizacao.ShowDialog();
        }

        //===============================================================================================================
        private void Documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 25;
            y += 25;
            string texto = TXTEncomenda.Text;
            Font letra = new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Rectangle rec = new Rectangle(80, y, 700, 800);
            StringFormat alinhamento = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            };

            e.Graphics.DrawString(texto, letra, cor, rec, alinhamento);
        }

        //===============================================================================================================
        private void NovaEncomenda()
        {
            Apagarcampos();

            StreamWriter ficheiro = new StreamWriter(Tasquinha_da_Ana + "Encomenda " + dateAndTime + ".txt", true, Encoding.Default);
            ficheiro.WriteLine((string)TXTEncomenda.Text);

            ficheiro.Dispose();
            TXTNome.Focus();
        }
    }
}
