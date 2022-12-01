using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_7
{
    internal class Livro
    {
        private string nome;
        private string autor;
        private string genero;

        public Livro(string nome, string autor, string genero)
        {
            this.nome = nome;
            this.autor = autor;
            this.genero = genero;
        }
        public void exibeInfo()
        {
            Console.WriteLine("O nome do livro é "+nome+"\nO autor é "+autor+"\nO gênero é "+genero);
        }
    }
}
