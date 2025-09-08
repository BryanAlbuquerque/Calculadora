using System;
using System.Data;

namespace Calculadora
{
    internal class Calculator
    {
        public static string CalcularExpressao(string expressao)
        {
            try
            {
                var resultado = new DataTable().Compute(expressao, null);
                return resultado.ToString();
            }
            catch
            {
                return "Erro na expressão";
            }
        }
    }
}
