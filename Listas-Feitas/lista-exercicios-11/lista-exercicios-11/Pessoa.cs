using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_11
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
      
    }
}
