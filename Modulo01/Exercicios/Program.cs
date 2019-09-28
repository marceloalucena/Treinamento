using System;
using System.Diagnostics;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Hello World 1!");
            Console.WriteLine("Hello World 2!");

            string nome;
            bool ativo;
            int numero;
            long numero_longo;
            decimal valor;
            DateTime hoje;
            DateTime dataManual;
            char tipo;

            int[] array_int = new int[5];
            string[] array_string = new string[10];

            array_string[0] = "Teste01";
            array_string[1] = "Teste02";
            array_string[2] = "Teste03";
            array_string[3] = "Teste04";
            array_string[4] = "Teste05";
            array_string[5] = "Teste06";
            array_string[6] = "Teste07";
            array_string[7] = "Teste08";
            array_string[8] = "Teste09";
            array_string[9] = "Teste10";

            nome = "Teste";
            ativo = true;
            numero = 1;
            numero_longo = 9999999999;
            valor = 15_59 + 1_01;
            hoje = DateTime.Now; //Data Atual
            dataManual = new DateTime(2019,09,20);
            tipo = 'S';
            Console.WriteLine("Digite um valor:");
            //string variavelUsuario = Console.ReadLine();

            if (ativo)
            {
                Console.WriteLine("Situacao......: Ativo");
            }
            else
            {
                Console.WriteLine("Situacao......: Inativo");
            }

            Console.WriteLine("Nome..........: " + nome);
            Console.WriteLine("Numero........: " + numero);
            Console.WriteLine("Numero Longo..: " + numero_longo);
            Console.WriteLine("Valor.........: " + valor.ToString("00_00"));
            Console.WriteLine("Hoje..........: " + hoje.ToString("dd/MM/yyyy"));
            Console.WriteLine("Tipo.Char.....: " + tipo);

            Console.WriteLine($"Nome..........: {nome}.");
            Console.WriteLine($"Numero........: {numero}.");
            Console.WriteLine($"Numero Longo..: {numero_longo}.");
            Console.WriteLine($"Valor.........: {valor}.");
            Console.WriteLine($"Hoje..........: {hoje.ToString("dd/MM/yyyy")}.");
            Console.WriteLine($"Tipo.Char.....: {tipo}");

            //Console.WriteLine($"Valor.Digitado: {variavelUsuario}.");

            Console.Write($"Array.........: (");
            for (int i = 0; i < array_string.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(",");
                }
                Console.Write(array_string[i]);
            }
            Console.WriteLine(").");


            int j = 0;
            Console.Write($"While.........: (");
            while (j < 11)
            {
                if (j > 0)
                {
                    Console.Write(",");
                }
                Console.Write(j);
                ++j;
            }
            Console.WriteLine(")");
            */
            bool mostrarmenu = true;
            while (mostrarmenu)
            {
                Console.Clear();
                Console.WriteLine("************ Desafio ***************");
                Desafio desafio1 = new Desafio();
                Console.WriteLine(">> Exercício 01 << Fatorial de um número passado como parametro");
                Console.WriteLine(">> Exercício 02 << Fatorial de um número digitado");
                Console.WriteLine(">> Exercício 03 << Verificar qual número é maior");
                Console.WriteLine(">> Exercício 04 << Verificar se o número é par ou impar");
                Console.WriteLine(">> Exercício 05 << Receber dois números e aplicar a operação");
                Console.WriteLine(">> Exercício 06 << Tabuada de um número digitado");
                Console.WriteLine(">> Exercício 07 << Calcular Em Celsius para Fahrenheit");
                Console.WriteLine(">> Exercício 10 << Sair");
                Console.Write("Digite a Exercicio:");
                string exercicio = Console.ReadLine();

                switch (exercicio)
                {
                    case "1":
                    case "01":
                        desafio1.Exercicio01();
                        break;
                    case "2":
                    case "02":
                        desafio1.Exercicio02();
                        break;
                    case "3":
                    case "03":
                        desafio1.Exercicio03();
                        break;
                    case "4":
                    case "04":
                        desafio1.Exercicio04();
                        break;
                    case "5":
                    case "05":
                        desafio1.Exercicio05();
                        break;
                    case "6":
                    case "06":
                        desafio1.Exercicio06();
                        break;

                    case "7":
                    case "07":
                        desafio1.Exercicio07();
                        break;

                    case "10":
                        mostrarmenu = false;
                        break;

                    default:
                        break;
                }
                Console.ReadKey();
            }
        }       
    }
}
