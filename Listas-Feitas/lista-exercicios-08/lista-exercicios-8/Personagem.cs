using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_8
{
    public class Personagem
    {
        private string nome;
        private int poder;

        public string getNome()
        {
            return nome;
        }

        public int getPoder()
        {
            return poder;
        }
        public Personagem()
        {

        }
        public Personagem(string nome, int poder)
        {
            this.nome = nome;
            this.poder = poder;
        }

        public void ExibirDados()
        {
            Console.WriteLine("\nNome: "+nome+"\nPoder: "+poder);
        }
    }
}
