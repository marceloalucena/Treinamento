using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Desafio
    {
        public void FatorialQuatro()
        {
            Console.WriteLine("Fatorial Número 4 é 4x3x2x1="+(4*3*2*1));
        }

        
        private int CalcularFatorial(int numero)
        {
            int resultado = 1;
            for (int i = 2; i<=numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public void Fatorial(int numero)
        {
            Console.WriteLine($"Fatorial do número {numero} é {CalcularFatorial(numero)}");
        }

        public void Exercicio01()
        {
            Console.WriteLine(">> Exercício 01 << Fatorial de um número estático (4)");
            Desafio desafio1 = new Desafio();
            desafio1.FatorialQuatro();

            Console.WriteLine(">> Exercício 01 << Fatorial de um número passado como parametro");
            desafio1.Fatorial(10);

        }

        public void Exercicio02()
        {
            Console.WriteLine(">> Exercício 02 << Fatorial de um número digitado");
            string str_num_02_1 = Console.ReadLine();
            int num_02_1 = Convert.ToInt32(str_num_02_1);
            Fatorial(num_02_1);
        }

        public void Exercicio03()
        {
            Console.WriteLine(">> Exercício 03 << Verificar qual número é maior");
            Console.Write("Digite o Primeiro Número:");
            string str_num_03_1 = Console.ReadLine();
            int num_03_1 = Convert.ToInt32(str_num_03_1);
            Console.Write("Digite o Segundo Número:");
            string str_num_03_2 = Console.ReadLine();
            int num_03_2 = Convert.ToInt32(str_num_03_2);
            if (num_03_1 == num_03_2)
            {
                Console.WriteLine($"O número {num_03_1} é igual ao número {num_03_2}.");
            }
            else if (num_03_1 > num_03_2)
            {
                Console.WriteLine($"O número {num_03_1} é maior que o número {num_03_2}.");
            }
            else
            {
                Console.WriteLine($"O número {num_03_2} é maior que o número {num_03_1}.");
            }
        }

        public void Exercicio04()
        {
            Console.WriteLine(">> Exercício 04 << Verificar se o número é par ou impar");
            Console.Write("Digite um Número:");
            string str_num_04_1 = Console.ReadLine();
            int num_04_1 = Convert.ToInt32(str_num_04_1);
            if ((num_04_1 % 2) == 0)
            {
                Console.WriteLine($"O número {num_04_1} é par.");
            }
            else
            {
                Console.WriteLine($"O número {num_04_1} é impar.");
            }

        }

        public void Exercicio05()
        {
            Console.WriteLine(">> Exercício 05 << Receber dois números e aplicar a operação");
            Console.Write("Digite o Primeiro Número:");
            string str_num_05_1 = Console.ReadLine();
            int num_05_1 = Convert.ToInt32(str_num_05_1);
            Console.Write("Digite o Segundo Número:");
            string str_num_05_2 = Console.ReadLine();
            int num_05_2 = Convert.ToInt32(str_num_05_2);
            Console.Write("Digite o Operador:");
            string operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.WriteLine($"O resultadao da soma de {num_05_1} com {num_05_2} é {num_05_1 + num_05_2}.");
                    break;
                case "-":
                    Console.WriteLine($"O resultadao da subtração de {num_05_1} com {num_05_2} é {num_05_1 - num_05_2}.");
                    break;
                case "/":
                    Console.WriteLine($"O resultadao da divisão de {num_05_1} com {num_05_2} é {num_05_1 / num_05_2}.");
                    break;
                case "*":
                    Console.WriteLine($"O resultadao da multiplicação de {num_05_1} com {num_05_2} é {num_05_1 * num_05_2}.");
                    break;
                default:
                    Console.WriteLine("Você não digitou um operador conhecido (+ - / *)");
                    break;
            }
        }

        public void Exercicio06()
        {
            Console.WriteLine(">> Exercício 06 << Tabuada de um número digitado");
            Console.Write("Digite um Número:");
            string str_num = Console.ReadLine();
            int num = Convert.ToInt32(str_num);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num}*{i}={num*i}");
            }
        }

        public void Exercicio07()
        {
            Console.WriteLine(">> Exercício 07 << Calcular Em Celsius para Fahrenheit");
            Console.Write("Digite a Temperatura:");
            string str_num = Console.ReadLine();
            int num = Convert.ToInt32(str_num);
            Console.Write("A Temperatura digitada está em C-Celsius ou F-Fahrenheit:");
            string str_tipo = Console.ReadLine();
            switch (str_tipo.ToUpper())
            {
                case "C":
                    Console.WriteLine($" {str_num}Celsius é igual a {CelsiusToFahrenheit(num)} Fahrenheit");
                    break;

                case "F":
                    Console.WriteLine($" {str_num}Fahrenheit é igual a {FahrenheitToCelsius(num)} Celsius");
                    break;

                default:
                    Console.WriteLine("Você não digitou um valor conhecido (C F).");
                    break;
            }
        }

        private float CelsiusToFahrenheit(int temperatura)
        {
            float resultado = 0;
            resultado = ((temperatura * 9) / 5) +32;
            return resultado;
        }

        private float FahrenheitToCelsius(int temperatura)
        {
            float resultado = 0;
            resultado = ((temperatura - 32) * 5) / 9;
            return resultado;
        }
    }
}
