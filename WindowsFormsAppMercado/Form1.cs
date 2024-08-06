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
        public Form1()
        {
            InitializeComponent();
        }

        public void bntnovo_Click(object sender, EventArgs e)
        {
            string nome = (string)textProduto.Text;
            int quantidade = int.Parse(textQuantidade.Text);
            double valor = double.Parse(textUnitario.Text);
           

            lista.Items.Add(nome+"/"+quantidade+"/"+valor) ;

            textProduto.Clear();
            textQuantidade.Clear();
            textUnitario.Clear();


        }

        private void bntnova_Click(object sender, EventArgs e)
        {
            textProduto.Clear();
            textQuantidade.Clear();
            textUnitario.Clear();
            lista.Items.Clear();
            
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
