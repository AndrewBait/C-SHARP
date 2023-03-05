using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lista3_ANDREW_CJ3014916
{
    internal class Program
    {
        public static void Exercicio1()
        {                  

            Console.WriteLine("\nEXERCICIO 1");
            Console.Write("\nDefina o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            float[] vetor = new float[tamanho];

            for(int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Digite o {i+1} numero: ");
                vetor[i] = float.Parse(Console.ReadLine());
            }

            float menor = vetor[0];
            for (int i = 1; i < tamanho; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i]; ;
                }
            }

            float maior = vetor[0];
            for (int i = 1; i < tamanho; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i]; ;
                }
            }

            float soma = 0;
            for (int i = 0; i < tamanho; i++)
            {
                soma += vetor[i];
            }
            float media = soma / tamanho;

            Console.WriteLine($"Menor numero: {menor}");
            Console.WriteLine($"Maior numero: {maior}");
            Console.WriteLine($"Media aritmetica: {media}");

        }

        public static void Exercicio2()
        {
            Console.WriteLine("\nEXERCICIO 2");

            int tamanho = 1;
            while(tamanho > 0)
            {
                Console.Write("\nDefina o tamanho do vetor(digite zero p/ sair): ");
                tamanho = int.Parse(Console.ReadLine());
                int[] vetor = new int[tamanho];

                for (int i = 0;i < tamanho; i++)
                {
                    Console.Write($"Digite o {i+1} numero: ");
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                int soma = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    soma += vetor[i];
                }
                int media = soma / tamanho;
                
                Console.WriteLine($"A media é: {media}");


                for (int i = 0; i < tamanho; i++)
                {
                    if (vetor[i] >= media)
                        Console.WriteLine($"Portanto os numeros maior ou igual a media sao: {vetor[i]}");
                }
            } 

        }

        public static void Exercicio3()
        {
            Console.WriteLine("\nEXERCICIO 3");

            int tamanho = 1;
            while (tamanho > 0)
            {
                Console.Write("\nDefina o tamanho do vetor(digite zero p/ sair): ");
                tamanho = int.Parse(Console.ReadLine());
                int[] vetor = new int[tamanho];

                Console.Write("Digite o valor máximo para os números aleatórios: ");
                int valorMaximo = int.Parse(Console.ReadLine());

                Random random = new Random();
                for (int i = 0; i < tamanho; i++)
                {                    
                    vetor[i] = random.Next(valorMaximo+1);
                }

                int soma = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    soma += vetor[i];
                }
                int media = soma / tamanho;
                Console.WriteLine("A media é: ");


                for (int i = 0; i < tamanho; i++)
                {
                    if (vetor[i] >= media)
                        Console.WriteLine($"Portanto os numeros maior ou igual a media sao: {vetor[i]}");
                }
            }
        }

        public static void Exercicio4()
        {

        }

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("LISTA 3 DE EXERCICIOS");
                Console.WriteLine();
                Console.WriteLine("01- EX01 ");
                Console.WriteLine("02- EX02 ");
                Console.WriteLine("03- EX03 ");
                Console.WriteLine("04- EX04 ");
                Console.WriteLine("0 - Sair");
                Console.Write("\nSelecione o numero do exercicio que deseja realizar: ");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;                   
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }



    }
}
