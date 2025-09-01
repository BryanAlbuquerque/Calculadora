using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string[] result = txtResult.Text.Split('+', '-', '*', '/');

            if (txtResult.Text.Contains('+'))
            {
                double som = Convert.ToDouble(result[0]) + Convert.ToDouble(result[1]);
                txtResult.Text = som.ToString();
            }
            else if (txtResult.Text.Contains('-'))
            {
                double sub = Convert.ToDouble(result[0]) - Convert.ToDouble(result[1]);
                txtResult.Text = sub.ToString();
            }
            else if (txtResult.Text.Contains('*'))
            {
                double mult = Convert.ToDouble(result[0]) * Convert.ToDouble(result[1]);
                txtResult.Text = mult.ToString();
            }
            else if (txtResult.Text.Contains('/'))
            {
                double div = Convert.ToDouble(result[0]) / Convert.ToDouble(result[1]);
                txtResult.Text = div.ToString();
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtResult.Text += btn.Text; // pega o texto do botão clicado e concatena
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnZero.Click += NumberButton_Click;
            btnOne.Click += NumberButton_Click;
            btnTwo.Click += NumberButton_Click;
            btnTre.Click += NumberButton_Click;
            btnFour.Click += NumberButton_Click;
            btnFive.Click += NumberButton_Click;
            btnSix.Click += NumberButton_Click;
            btnSeven.Click += NumberButton_Click;
            btnEight.Click += NumberButton_Click;
            btnNine.Click += NumberButton_Click;

            btnDot.Click += NumberButton_Click;
            btnDiv.Click += NumberButton_Click;
            btnSoma.Click += NumberButton_Click;
            btnMulti.Click += NumberButton_Click;
            btnSub.Click += NumberButton_Click;
            btnPorcent.Click += NumberButton_Click;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

        }
    }
}
