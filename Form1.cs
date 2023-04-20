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
        bool ischecked = false;
        int contagemitens;
        float preco = 0.00f;
        readonly string Localizacao = System.AppDomain.CurrentDomain.BaseDirectory;
        readonly string dateAndTime = DateTime.Now.ToString("yyyy-MM-dd");

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Localizacao + "Encomenda " + dateAndTime + ".txt"))
            {
                StreamReader ficheiro = new StreamReader(Localizacao + "Encomenda " + dateAndTime + ".txt", Encoding.Default);
                TXTEncomenda.Text = ficheiro.ReadToEnd();

                ficheiro.Close();
                File.Delete(Localizacao + "Encomenda " + dateAndTime + ".txt");
                BTNImpressao.Enabled = true;
            }
        }

        void BTNGravar_Click(object sender, EventArgs e)
        {
            TXTEncomenda.Text += TXTNome.Text + " - ";

            if (RBKebab.Checked)
            {
                string txt = panelItem.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                TXTEncomenda.Text += txt;

                string tipokebab = panelKebab.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                TXTEncomenda.Text += tipokebab;
				
                switch (panelKebab.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text)
                {
                    case "Durum M":
                        preco += 4.50f;
                        break;
                    case "Durum XL":
                        preco += 5.20f;
                        break;
                    case "Pão normal":
                        preco += 4.40f;
                        break;
                    case "Pão pita":		//TODO: alterar preco
                        preco += 4.60f;
                        break;
                    case "Bolo do caco":	//TODO: alterar preco
                        preco += 4.50f;
                        break;
                    case "Box":
                        preco += 4.90f;
                        break;
                }

                AddIngredientes();
            }
            else if (RBBifana.Checked)
            {
                string txt = panelItem.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                TXTEncomenda.Text += txt;

                string tipobifana = panelBifana.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                TXTEncomenda.Text += tipobifana;

                switch (panelBifana.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text)
                {
                    case "Simples":
                        preco += 3.70f;
                        break;
                    case "Completa":
                        preco += 4.30f;
                        break;
                    case "Bolo do caco":	//TODO: alterar preco
                        preco += 4.00f;
                        break;
                }

                AddIngredientes();
            }
            else if (RBCachorro.Checked)
            {
                string txt = panelItem.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                TXTEncomenda.Text += txt;

                string tipocachorro = panelCachorro.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                TXTEncomenda.Text += tipocachorro;

                switch (panelCachorro.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text)
                {
                    case "Simples":				//TODO: alterar preco
                        preco += 3.50f;
                        break;
                    case "Completo":			//TODO: alterar preco
                        preco += 4.20f;
                        break;
                    case "à Manekas (Duplo)":	//TODO: alterar preco
                        preco += 4.90f;
                        break;
                }

                AddIngredientes();
            }
            else if (RBHamburguer.Checked)
            {
                string txt = panelItem.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                TXTEncomenda.Text += txt;

                string tipohamburguer = panelHamburguer.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                TXTEncomenda.Text += tipohamburguer;


                switch (panelHamburguer.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text)
                {
                    case "Simples":			//TODO: alterar preco
                        preco += 4.00f;
                        break;
                    case "Completo":
                        preco += 4.70f;
                        break;
                    case "Bolo do caco":
                        preco += 4.30f;
                        break;
                    case "à David's":		//TODO: alterar preco
                        preco += 5.00f;
                        break;
                }

                AddIngredientes();
            }
            Apagarcampos();
            TXTNome.Focus();
            BTNImpressao.Enabled = true;
            contagemitens = 0;
            ischecked = false;
        }

        private void AddIngredientes()
        {
            TXTEncomenda.Text += " - ";
            for (int i = 0; i < IngredientesCheckedBox.CheckedItems.Count; i++)
            {
                string s = (string)IngredientesCheckedBox.CheckedItems[i];
                TXTEncomenda.Text += s;
                if (contagemitens == IngredientesCheckedBox.CheckedItems.Count - 1 && OvoCheckBox.Checked == false)
                    TXTEncomenda.Text += " - ";
                else
                {
                    contagemitens++;
                    TXTEncomenda.Text += ", ";
                }
            }

            if (OvoCheckBox.Checked)
            {
                TXTEncomenda.Text += "Ovo - ";
                preco += 0.60f;
            }

            TXTEncomenda.Text += preco + "€" + Environment.NewLine + Environment.NewLine;
        }

        #region Paineis

        private void RBKebab_Checked(object sender, EventArgs e)
        {
            panelKebab.Visible = RBKebab.Checked;
        }

        private void RBBifana_CheckedChanged_1(object sender, EventArgs e)
        {
            panelBifana.Visible = RBBifana.Checked;
        }

        private void RBCachorro_CheckedChanged_1(object sender, EventArgs e)
        {
            panelCachorro.Visible = RBCachorro.Checked;
        }

        private void RBHamburguer_CheckedChanged_1(object sender, EventArgs e)
        {
            panelHamburguer.Visible = RBHamburguer.Checked;
        }
        #endregion

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            Apagarcampos();
            TXTNome.Focus();
        }

        private void Apagarcampos()
        {
            TXTNome.Clear();
            preco = 0.00f;
            OvoCheckBox.Checked = false;
            for (int i = 0; i < IngredientesCheckedBox.Items.Count; i++)
                IngredientesCheckedBox.SetItemChecked(i, false);
            foreach (Control c in panelItem.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.Checked = true;
                }
            }

            foreach (Control c in panelKebab.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.Checked = true;
                }
            }

            foreach (Control c in panelBifana.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.Checked = true;
                }
            }

            foreach (Control c in panelCachorro.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.Checked = true;
                }
            }

            foreach (Control c in panelHamburguer.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.Checked = true;
                }
            }
        }

        private void BTNFechar_Click(object sender, EventArgs e)
        {
            StreamWriter ficheiro = new StreamWriter(Localizacao + "Encomenda " + dateAndTime + ".txt", true, Encoding.Default);
            ficheiro.Write(TXTEncomenda.Text);

            ficheiro.Close();

            Application.Exit();
        }

        private void TXTNome_TextChanged(object sender, EventArgs e)
        {
            if (TXTNome.Text == "")
                BTNGravar.Enabled = false;
            else
                BTNGravar.Enabled = true;
        }

        private void BTNImpressao_Click(object sender, EventArgs e)
        {
            pre_visualizacao.Document = Documento;
            pre_visualizacao.Height = 1280;
            pre_visualizacao.Width = 720;
            pre_visualizacao.ShowDialog();
        }
        private void TodosIngredientes_Click(object sender, EventArgs e)
        {
            if (!ischecked)
            {
                for (int i = 0; i < IngredientesCheckedBox.Items.Count - 5; i++)
                {
                    IngredientesCheckedBox.SetItemChecked(i, true);
                    ischecked = true;
                }
            }
            else
            {
                for (int i = 0; i < IngredientesCheckedBox.Items.Count - 5; i++)
                {
                    IngredientesCheckedBox.SetItemChecked(i, false);
                    ischecked = false;
                }
            }
        }
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
    }
}
