using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            string entrada = txtResult.Text;
            string resultado = Calculator.CalcularExpressao(entrada);

            if (resultado == "Erro na expressão")
                MessageBox.Show("Expressão inválida. Verifique os operadores e números.");
            else
                txtResult.Text = resultado;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtResult.Text += btn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var btn in new[] {
                btnZero, btnOne, btnTwo, btnTre, btnFour, btnFive, btnSix,
                btnSeven, btnEight, btnNine, btnDot, btnDiv, btnSoma,
                btnMulti, btnSub, btnPorcent })
            {
                btn.Click += NumberButton_Click;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
        }
    }
}
