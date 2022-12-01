using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_9
{
    public class Utilidade
    {
        private string email;

        public string Email { get => email; set => email = value; }

        public static void populaListaEmail(List<Utilidade> lista, string nomeArquivo)
        {
            StreamReader leitura = new StreamReader(nomeArquivo);
            string linha="";
            string[] dadosLinha;
            do
            {
                Utilidade utilidade = new Utilidade();
                linha = leitura.ReadLine();
                dadosLinha = linha.Split();
                utilidade = dadosLinha[0];

                lista.Add(dadosLinha[0]);
                
            } while (!leitura.EndOfStream);
        }

        
    }
}
