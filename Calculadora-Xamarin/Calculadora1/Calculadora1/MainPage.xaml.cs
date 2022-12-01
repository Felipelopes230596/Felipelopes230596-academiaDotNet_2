using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora1
{
    public partial class MainPage : ContentPage
    {
        int estado = 1;
        string operador;
        double primeiroNumero, segundoNumero;
        public MainPage()
        {
            InitializeComponent();
            btnClear(new object(), new EventArgs());
        }

        private void btnClear(object sender, EventArgs e)
        {
            primeiroNumero = 0;
            segundoNumero = 0;
            estado = 1;
            this.reesultText.Text = "0";
        }

        private void numeroSelecionado(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnTexto = btn.Text;

            if (this.reesultText.Text == "0" || estado < 0)
            {
                this.reesultText.Text = "";
                if (estado < 0)
                {
                    estado *= -1;
                }
            }

            this.reesultText.Text += btnTexto;

            double numero;
            if (double.TryParse(this.reesultText.Text, out numero))
            {
                this.reesultText.Text = numero.ToString("N0");
                if (estado == 1)
                {
                    primeiroNumero = numero;
                }
                else
                {
                    segundoNumero = numero;
                }
            }
        }

        private void operadorSelecionado(object sender, EventArgs e)
        {
            estado = -2;
            Button btn = (Button)sender;
            string btnTexto = btn.Text;
            operador = btnTexto;
        }

        private void calcularResultado(object sender, EventArgs e)
        {
            if (estado == 2)
            {
                double resultado = 0;
                if (operador == "+")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                if (operador == "-")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                if (operador == "X")
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                if (operador == "/")
                {
                    resultado = primeiroNumero / segundoNumero;
                }

                this.reesultText.Text = resultado.ToString("N0");
                primeiroNumero= resultado;
                estado= -1;
            }
        }
    }
}
