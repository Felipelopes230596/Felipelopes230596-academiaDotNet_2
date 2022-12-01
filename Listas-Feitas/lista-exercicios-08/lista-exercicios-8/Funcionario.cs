using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicios_8
{
    public class Funcionario
    {
        private string _departamento;
        private double _salario;
        private string _dataInicio;
        private string _rg;
        private bool _ativo;

        public string Departamento { get => _departamento; set => _departamento = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public string DataInicio { get => _dataInicio; set => _dataInicio = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        public void bonifica(int bonus)
        {
            _salario += bonus;
        }

        public void demite()
        {
            _ativo = false;
        }
    }
}
