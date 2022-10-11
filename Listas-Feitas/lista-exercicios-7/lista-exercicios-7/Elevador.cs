using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_7
{
    public class Elevador
    {
        private int andar = 0;
        private int totalAndares;
        private int capacidade;
        private int nOcupantes;

        public void setInicializa(int totalAndares, int capacidade)
        {
            this.totalAndares = totalAndares;
            this.capacidade = capacidade;
        }
        public void entra()
        {
            if (nOcupantes < capacidade)
            {
                nOcupantes += +1;
                Console.WriteLine("Pessoa entrou!\nNo momento são "+nOcupantes+" pessoa(s) no elevador!");
            }
            else
            {
                Console.WriteLine("Elevador cheio!");
            }
        }

        public void sai()
        {
            if (nOcupantes > 0)
            {
                nOcupantes += -1;
                Console.WriteLine("Pessoa saiu!\nNo momento são "+nOcupantes+" pessoa(s) no elevador!");
            }
            else
            {
                Console.WriteLine("Não é possivel retirar pessoa pois o elevador está vazio!");
            }
        }

        public void sobe()
        {
            if (andar < totalAndares)
            {
                andar += +1;
                if (andar > 0)
                {
                    Console.WriteLine("Subiu um andar!\nAgora está no " + andar + "º andar!");
                }
            }
            else
            {
                Console.WriteLine("Impossivel subir, esse já é o ultimo andar!");
            }
        }
               

        public void desce()
        {
            if (andar > 0)
            {
                andar += -1;
                if (andar > 0)
                {
                    Console.WriteLine("Desceu um andar!\nAgora está no " + andar + "º andar!");
                }
                else
                {
                    Console.WriteLine("Desceu um andar!\nAgora está no térreo!");
                }

            }
            else
            {
                Console.WriteLine("Impossivel descer, esse já é o térreo!");
            }
        }
    }
}
