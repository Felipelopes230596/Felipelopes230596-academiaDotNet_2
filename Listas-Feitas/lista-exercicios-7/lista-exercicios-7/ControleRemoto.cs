using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_7
{
    public class ControleRemoto
    {

        public void volumeMais(Televisao televisao)
        {
            televisao.setVolume(televisao.getVolume() + 1);
            Console.WriteLine("Volume +1");
        }

        public void volumeMenos(Televisao televisao)
        {
            if (televisao.getVolume() >= 0)
            {
                televisao.setVolume(televisao.getVolume() - 1);
                Console.WriteLine("Volume -1");
            }
            else
            {
                Console.WriteLine("Volume zerado");
                
            }
            
        }

        public void trocaCanal(int canal, Televisao televisao)
        {
            televisao.setCanal(canal);
            Console.WriteLine("\nCanal alterado");
        }

        

    }
}
