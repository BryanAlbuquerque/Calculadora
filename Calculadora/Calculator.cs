using System;
using System.Net;
using System.Windows.Forms;

namespace Calculadora
{
    internal class Calculator
    {
        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }

        public static int Subtracao(params int[] numeros)
        {
            int subtracao = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                subtracao -= numeros[i];
            }
            return subtracao;
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
