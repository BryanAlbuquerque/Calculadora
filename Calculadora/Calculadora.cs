using System;
using System.Linq;
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
            string Entrada = txtResult.Text;
            Calculator calculator = new Calculator();

            try
            {
                if (Entrada.Contains('+'))
                {
                    string[] entrada = txtResult.Text.Split('+');
                    int[] numeros = Array.ConvertAll(entrada, int.Parse);

                    txtResult.Text = Calculator.Soma(numeros).ToString();
                }
                else if (Entrada.Contains('-'))
                {
                    string[] entrada = txtResult.Text.Split('-');
                    int[] numeros = Array.ConvertAll(entrada, int.Parse);

                    txtResult.Text = Calculator.Subtracao(numeros).ToString();
                }
                else if (Entrada.Contains('*'))
                {
                    
                    
                }
                else if (Entrada.Contains('/'))
                {
                    
                }
            }
            catch
            {
                MessageBox.Show("Erro ao calcular. Verifique a expressão.");
            }
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
