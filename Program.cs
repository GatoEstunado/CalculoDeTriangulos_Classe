// Bibliotecas
﻿using System;
using System.Globalization;

// Programa com a classe 
namespace Course
{
    // Classe Triangulo
    public class Triangulo
    {
        // Dar os valores do triangulo para as variaveis A, B, C.
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        
        // Gerar o programa que vai calcular a area dos triangulos
        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
            // Retornar a area
            return area;
        }
    }
    
    // Programa principal
    public class Program
    {
        
        // Funcao que recebe as informacoes
        // Programa principal
        public static void Main(string[] args)
        {
            // Recebe as medidas dos triangulo X e Y
            Triangulo x = LerTriangulo("X");
            Triangulo y = LerTriangulo("Y");
            
            // Calcula os valores dos triangulos X e Y
            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();
            
            // Interface do usuario, para recerber as informacoes dos triangulos X e Y
            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // IF para que se X maior que Y, informar
            if (areaX > areaY)
            {
                // COUT do C#
                Console.WriteLine("Maior area: X");
            }
            // ELSE para que se X  não maior que Y, informar
            else
            {
                // COUT do C#
                Console.WriteLine("Maior area: Y");
            }
        }

        // Funcao para alocar as informacoes do programa principal
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            // Gerar um triangulo novo, atraves da classe Triangulo
            Triangulo triangulo = new Triangulo();

            // PARSE para ler e vincular os valores na READLINE a variaveis A, B, C.
            // Interface para o usuario colocar os valores do triangulos
            Console.WriteLine("Entre com as medidas do triangulo " + nomeTriangulo + ":");
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Retornar o triangulo
            return triangulo;
        }
    }

}


