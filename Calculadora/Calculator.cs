using System;
using System.Windows.Forms;

namespace Calculadora
{
    internal class Calculator
    {
        public int Soma(params int[] numeros)
        {
            int resultado = 0;
            foreach (int n in numeros)
                resultado += n;
            return resultado;
        }

        public double Subtracao(params double[] numeros)
        {
            double resultado = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
                resultado -= numeros[i];
            return resultado;
        }

        public double Multiplicacao(params double[] numeros)
        {
            double resultado = 1;
            foreach (double n in numeros)
                resultado *= n;
            return resultado;
        }

        public double Divisao(params double[] numeros)
        {
            double resultado = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    MessageBox.Show("Divisão por zero não é permitida.");
                    return 0;
                }
                resultado /= numeros[i];
            }
            return resultado;
        }
    }
}
