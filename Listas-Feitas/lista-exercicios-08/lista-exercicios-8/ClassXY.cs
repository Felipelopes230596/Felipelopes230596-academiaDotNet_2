using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_8
{
    public class ClassXY
    {
        private int _x; 
        private int _y;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }


        public ClassXY(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        
        public void exibeDados()
        {
            Console.WriteLine($"({X}, {Y})");
        }


    }
}
