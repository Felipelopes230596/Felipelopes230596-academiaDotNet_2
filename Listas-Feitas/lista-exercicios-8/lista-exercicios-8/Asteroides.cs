using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_8
{
    public class Asteroides
    {        
        private int posicaoX;
        private int posicaoY;
        private int tamanho;
        private int velocidade;
        private int energia;

        public int PosicaoX { get => posicaoX; set => posicaoX = value; }
        public int PosicaoY { get => posicaoY; set => posicaoY = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        
        public int Veelocidade { get => velocidade; set => velocidade = value; }
        public int Energia { get => energia; set => energia = value; }

        public Asteroides()
        {

        }

        public Asteroides(int posicaoX, int posicaoY, int tamanho, int velocidade, int energia)
        {
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
            this.energia = energia;
            this.tamanho = tamanho;
            this.velocidade = velocidade;
        }
        public Asteroides(int posicaox, int posicaoY)
        {
            this.posicaoY = posicaoY;
            this.posicaoX = posicaox;
        }
    }
}
