using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_7
{
    public class Carro
    {
        public string modelo;
        public string marca;
        public string motor;
        public string categoria;
        public int diaria;

        
        public void setCategoria(int categoria)
        {           
            if (categoria == 1)
            {
                this.marca = "Kia";
                this.modelo = "Sorento";
                this.motor = "3.6";
                this.diaria = 470;
                this.categoria = "Suv";
            }
            else if (categoria == 2)
            {
                this.marca = "Toyota";
                this.modelo = "Corolla";
                this.motor = "2.0";
                this.diaria = 280;
                this.categoria = "Sedan";
            }
            else if (categoria == 3)
            {
                this.marca = "Hyundai";
                this.modelo = "Hb20";
                this.motor = "1.0 Turbo";
                this.diaria = 120;
                this.categoria = "Hatch";
            }
        }


    }
}
