using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_7
{
    internal class Pessoa
    {
        private string nome;
        private string genero;
        private int idade;
        private double altura;
        private double peso;

        public Pessoa(string nome, string genero, int idade, double altura, double peso)
        {
            this.nome = nome;
            this.genero = genero;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }
        public void exibeInfo()
        {
            Console.WriteLine("O nome é "+nome+"\nO gênero é "+genero+"\nA idade é "+idade+"\nA altura é "+altura+"\nO peso é "+peso);
        }
    }
}
