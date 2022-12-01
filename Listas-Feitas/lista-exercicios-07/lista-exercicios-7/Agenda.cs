using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lista_exercicios_7
{
    public class Agenda
    {
        public List<string> nomes = new List<string> { "felipe", "mariana", "amanda", "clara", "reinaldo", "sebastiao", "beatriz", "alexandre", "elisa", "romulo" };
        public List<int> idades = new List<int> { 15, 22, 35, 40, 18, 19, 30, 25, 23, 72 };
        public List<float> alturas = new List<float> { 180, 170, 175, 190, 165, 190, 185, 187, 178, 177 };



        public void armazenaPessoa(string nome, int idade, float altura)
        {           
                nomes.Add(nome);
                idades.Add(idade);
                alturas.Add(altura);                
        }
        public void removePessoa(string nome)
        {
            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomes[i] == nome)
                {
                    nomes[i] = "";
                    idades[i] = 0;
                    alturas[i] = 0;
                    Console.WriteLine("Removido com sucesso!");
                }

            }
        }
        public void buscaPessoa(string nome)
        {

            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomes[i].Contains(nome))
                {
                    Console.WriteLine("\nPesquisando...\nNome encontrado com sucesso!");
                    Console.WriteLine("\nNome: " + nomes[i] + "\nIdade: " + idades[i] + "\nAltura: " + alturas[i] + "\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Nome não encontrado!");
                }

            }

        }

        public void imprimeAgenda()
        {

            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomes[i] == "")
                {
                    continue;
                }
                Console.WriteLine("Nome: " + nomes[i] + "\nIdade: " + idades[i] + "\nAltura: " + alturas[i] + "\n");
            }

        }

    }
}
