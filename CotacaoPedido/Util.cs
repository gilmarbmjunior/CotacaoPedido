using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotacaoPedido
{
    internal class Util
    {
        public double normalizeDouble(string value)
        {
            string valorLimpo = new string(value.Where(char.IsDigit).ToArray());
            double valorDouble = double.Parse(valorLimpo) / 100;

            return valorDouble;
        }

        public void txtLimparFormatacao(TextBox textBox)
        {
            string texto = textBox.Text;
            texto = new string(Array.FindAll(texto.ToCharArray(), Char.IsDigit));
            texto = texto.TrimStart('0');
            textBox.Text = texto;
            textBox.SelectionStart = texto.Length;
        }

        public void txtFormatarMoeda(TextBox textBox)
        {
            if (textBox.Text == "")
                textBox.Text = "0";

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                decimal valor = decimal.Parse(textBox.Text) / 100;
                textBox.Text = string.Format("R$ {0:N2}", valor);
            }
        }

        public void txtFormatarPorcentagem(TextBox textBox)
        {
            if (textBox.Text == "")
                textBox.Text = "0";

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                decimal valor = decimal.Parse(textBox.Text) / 100;
                textBox.Text = string.Format("{0:N2} %", valor);
            }
        }

        public void setCursorEnd(TextBox textBox)
        {
            textBox.SelectionStart = textBox.TextLength;
        }

    }
}
