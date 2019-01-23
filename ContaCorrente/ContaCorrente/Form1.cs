using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente
{
    public partial class Form1 : Form
    {
        Conta conta = new Conta();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int valor = Convert.ToInt32(textBox1.Text);
            conta.Depositar(valor);
            textBox1.Clear();
            MessageBox.Show("Foi depositado: R$ " + valor + " reais");

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

             MessageBox.Show("Saldo atual: R$ " +  conta.Saldo + " reais");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(textBox2.Text);
                conta.Sacar(valor);
                textBox2.Clear();
                MessageBox.Show("Foi sacado: R$ " + valor + " reais");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int transferir = Convert.ToInt32(textBox3.Text);

            conta.Transferir(transferir, conta);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
