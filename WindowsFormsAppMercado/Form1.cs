using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMercado
{
    public partial class Form1 : Form
    {
        double valor_t;
        public Form1()
        {
            InitializeComponent();
        }

        public void bntnovo_Click(object sender, EventArgs e)
        {
            string nome = (string)textProduto.Text;
            int quantidade = int.Parse(textQuantidade.Text);
            double valor = double.Parse(textUnitario.Text);
             valor_t += (valor * quantidade);
           
            lista.Items.Add(nome+"/"+quantidade+"/"+valor) ;

            textProduto.Clear();
            textQuantidade.Clear();
            textUnitario.Clear();

            lbltotal.Text = valor_t.ToString();
        }

        private void bntnova_Click(object sender, EventArgs e)
        {
            valor_t = 0;
            lbltotal.Text = valor_t.ToString("C");
            textProduto.Clear();
            textQuantidade.Clear();
            textUnitario.Clear();
            lista.Items.Clear();
            
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
