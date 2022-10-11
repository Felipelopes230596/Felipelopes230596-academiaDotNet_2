using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_7
{
    public class Cliente
    {
        private string nome;
        private string endereco;
        private string dataNascimento;

        public void getDadosCliente(string nome, string endereco, string dataNascimento)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.dataNascimento = dataNascimento;
        }
    }
}
