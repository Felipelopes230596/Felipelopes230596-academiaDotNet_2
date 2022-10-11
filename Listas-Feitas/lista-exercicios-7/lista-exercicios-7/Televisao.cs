using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_7
{
    public class Televisao
    {
        private int canal;
        private int volume;
                
        public void setCanal(int canal)
        {
            this.canal = canal;
        }

        public void setVolume(int volume)
        {
            this.volume = volume ;
        }

        public int getVolume()
        {
            return volume;
        }

        public int getCanal()
        {
            return canal;
        }
    }
}
