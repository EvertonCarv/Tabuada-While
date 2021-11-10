using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero, resultado, i;
            i = 1;
            numero = int.Parse(txtNumero.Text);
            while (i <= 10)
            {
                resultado = i * numero;
                lstTabuada.Items.Add(String.Concat(numero, "*", i, "=", resultado));
                i = i + 1;
            }
            /*Declaração das variáveis do tipo inteiro
             * Conversão para int
             * Condição, enquanto o i for menor ou igual a 10
             * Variável resultado realiza o cálculo de i multiplicado pelo número digitado.
             * ListBox adiciona o item e concatena (número * i = resultado)
             * Incremento
             * */
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lstTabuada.Items.Clear();
            txtNumero.Focus();
        }
        private void KeyPress_Allow_Only_Numbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}