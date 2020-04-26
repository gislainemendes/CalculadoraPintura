using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Calculadora
    {
        private double areaParedes; // utilizar modificador de acesso para determinar a visibilidade do atributo
        private double areaTeto;

        public double CalcularAreaParedes(double largura, double profundidade, double altura)
        {
            areaParedes = 2 * (largura + profundidade) * altura;  // case sensitive, informar os parametros iguais dentro do método
            return areaParedes;
        }

        public double CalcularAreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade; // case sensitive, informar os parametros iguais dentro do método
            return areaTeto;
        }

        public double CalcularLitragemNecessaria()
        {
            return (areaParedes + areaTeto) / 10;//10 é o valor estimado de rendimento da tinta
        }
    }
}
