using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Programação é prática, então pratiquemos...

            Dictionary<int, string> cidades = new Dictionary<int, string>();

            // Cidades adicionadas por padrão!
            cidades.Add(1, "Rio de Janeiro");
            cidades.Add(2, "São Paulo");
            cidades.Add(3, "Paraná");
            cidades.Add(4, "Brasilia");
            cidades.Add(5, "Goias");

            Console.WriteLine("Digite um número referente a uma cidade: ");
            string cidade = Console.ReadLine();
            int numero;
            bool canConvert = int.TryParse(cidade, out numero);  // Retorna true se conseguir converter para número!

            if (numero < cidades.Count)  // Verifica se o número digitado, contém no Dictionary cidades
            {
                if (canConvert == true)  // Verifica se o número digitado é um número e é inteiro.
                {
                    Console.WriteLine(cidades[numero]);
                }
                else
                {
                    Console.WriteLine("Você não digito um número inteiro!");
                }
            }
            else  // Se o número não existir... vamos adicionar
            {
                Console.WriteLine("Esta cidade não esta em nosso sistema!! Se quiser pode adicionar sua cidade apartir do numero 6.");
                Console.WriteLine("Digite o número da sua cidade:");
                int nuNovaCidade = int.Parse(Console.ReadLine());
                Console.WriteLine("Agora digite o nome da sua cidade:");
                string noNovaCidade = Console.ReadLine();
                if (!(cidades.ContainsKey(nuNovaCidade)) && !(cidades.ContainsValue(noNovaCidade)))  // Verifica se não existe a chave e o valor no Dictionary
                {
                    cidades.Add(nuNovaCidade, noNovaCidade);
                    Console.WriteLine("Cidade adicionada...");
                    Console.WriteLine("Listando Cidades");
                    for (int i = 1; i <= cidades.Count; i++)
                    {
                        Console.WriteLine(cidades[i]);
                    }
                }
                else  // Se existir a chave e o valor...
                {
                    Console.WriteLine("Já temos essa cidade em nosso sistema.");
                }
            }
            
        }

    }

}