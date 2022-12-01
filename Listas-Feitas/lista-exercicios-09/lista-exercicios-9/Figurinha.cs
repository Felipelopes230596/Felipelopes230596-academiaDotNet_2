using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_9
{
    public class Figurinha
    {
        public string CodigoFigurinha { get; set; }
        public string Selecao { get; set; }
        public string NomeJogador { get; set; }

        public Figurinha(string codigo, string selecao, string jogador)
        {
            CodigoFigurinha = codigo;
            Selecao = selecao;
            NomeJogador = jogador;
        }
    }
}
