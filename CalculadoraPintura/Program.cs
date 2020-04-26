﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a largura do cômodo?");
            double largura = (double.Parse(Console.ReadLine()));

            Console.WriteLine("Qual a profundidade do cômodo?");
            double profundidade = (double.Parse(Console.ReadLine()));

            Console.WriteLine("A área das paredes é: ");
            const double Altura = 2.9; //o prof estipulou 2.9 de altura;

            Calculadora calculadora = new Calculadora(); // instancia da classe calculadora
            Console.WriteLine(calculadora.CalcularAreaParedes(largura, profundidade, Altura)); //atributo areaParede é da classe calculadora

            Console.WriteLine("A área do teto é: ");
            Console.WriteLine(calculadora.CalcularAreaTeto(largura,profundidade));

            Console.WriteLine("A litragem de tinta necessária é: ");
            Console.WriteLine(calculadora.CalcularLitragemNecessaria()); 
            Console.ReadLine();
        }
    }
}
