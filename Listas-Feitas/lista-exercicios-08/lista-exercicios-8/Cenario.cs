using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_8
{
    public class Cenario
    {
        private string _descricao { get; set; }
        private DateTime _date { get; set; }
        private float _altura { get; set; }

        public Cenario(string descricao, DateTime data,  float altura)
        {
            this._descricao = descricao;
            this._date = data;
            this._altura = altura;
        }

        public void imprimirDados()
        {
            Console.WriteLine($"Descrição: {_descricao}\nData: {_date}\nAltura: {_altura} ");
        }

        public void calcular()
        {
            DateTime resultado = DateTime.Now;
            Console.WriteLine($"O tempo de criação é {(resultado - _date)}");
        }
    }
}
