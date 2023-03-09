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
                        /*!!pela dificuldade assisti uma video aula em linguagem C para aplicar neste exercicico
            segue o link do video base: https://www.youtube.com/watch?v=WPVrj4CyCvM&t=728s*/

            int l, c, linha, coluna, jogador, ganhou, jogadas, opcao;
            char[,] jogo = new char[3, 3];

            do
            {
                jogador = 1;
                ganhou = 0;
                jogadas = 0;

                for (l = 0; l < 3; l++)
                {
                    for (c = 0; c < 3; c++)
                    {
                        jogo[l, c] = ' ';
                    }
                }

                do
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t 0   1   2\n\n");
                    for (l = 0; l < 3; l++)
                    {
                        for (c = 0; c < 3; c++)
                        {
                            if (c == 0)
                                Console.Write("\t");

                            Console.Write(" {0} ", jogo[l, c]);

                            if (c < 2)
                                Console.Write("|");

                            if (c == 2)
                                Console.Write("  {0}", l);
                        }

                        if (l < 2)
                            Console.WriteLine("\n\t-----------");

                        Console.WriteLine();
                    }

                    do
                    {
                        Console.WriteLine("\nJOGADOR 1 = 0\nJOGADOR 2 = X\n");
                        Console.WriteLine($"\nJOGADOR {jogador}: Escolha a linha de ENTER, escolha coluna e de ENTER: ");

                        linha = int.Parse(Console.ReadLine());
                        coluna = int.Parse(Console.ReadLine());
                    }
                    while (linha < 0 || linha > 2 || coluna < 0 || coluna > 2 || jogo[linha, coluna] != ' ');

                    if (jogador == 1)
                    {
                        jogo[linha, coluna] = '0';
                        jogador++;
                    }
                    else
                    {
                        jogo[linha, coluna] = 'X';
                        jogador = 1;
                    }

                    jogadas++;

                    if (jogo[0, 0] == '0' && jogo[0, 1] == '0' && jogo[0, 2] == '0' ||
                        jogo[1, 0] == '0' && jogo[1, 1] == '0' && jogo[1, 2] == '0' ||
                        jogo[2, 0] == '0' && jogo[2, 1] == '0' && jogo[2, 2] == '0')
                    {
                        Console.WriteLine("\nParabens! O jogador 1 venceu por linha!\n");
                        ganhou = 1;
                    }

                    if (jogo[0, 0] == 'X' && jogo[0, 1] == 'X' && jogo[0, 2] == 'X' ||
                        jogo[1, 0] == 'X' && jogo[1, 1] == 'X' && jogo[1, 2] == 'X' ||
                        jogo[2, 0] == 'X' && jogo[2, 1] == 'X' && jogo[2, 2] == 'X')
                    {
                        Console.WriteLine("\nParabens! O jogador 2 venceu por linha!\n");
                        ganhou = 1;
                    }

                    if (jogo[0, 0] == '0' && jogo[1, 0] == '0')

                        // salvar coordenadas
                        if (jogador == 1)
                        {
                            jogo[linha, coluna] = '0';
                            jogador++;
                        }
                        else
                        {
                            jogo[linha, coluna] = 'X';
                            jogador = 1;
                        }
                    jogadas++;

                    // alguém ganhou por linha
                    if (jogo[0, 0] == '0' && jogo[0, 1] == '0' && jogo[0, 2] == '0' ||
                       jogo[1, 0] == '0' && jogo[1, 1] == '0' && jogo[1, 2] == '0' ||
                       jogo[2, 0] == '0' && jogo[2, 1] == '0' && jogo[2, 2] == '0')
                    {
                        Console.WriteLine("\nParabens! O jogador 1 venceu por linha!\n");
                        ganhou = 1;
                    }

                    if (jogo[0, 0] == 'X' && jogo[0, 1] == 'X' && jogo[0, 2] == 'X' ||
                       jogo[1, 0] == 'X' && jogo[1, 1] == 'X' && jogo[1, 2] == 'X' ||
                       jogo[2, 0] == 'X' && jogo[2, 1] == 'X' && jogo[2, 2] == 'X')
                    {
                        Console.WriteLine("\nParabens! O jogador 2 venceu por linha!\n");
                        ganhou = 1;
                    }

                    // alguém ganhou por coluna
                    if (jogo[0, 0] == '0' && jogo[1, 0] == '0' && jogo[2, 0] == '0' ||
                    jogo[0, 1] == '0' && jogo[1, 1] == '0' && jogo[2, 1] == '0' ||
                    jogo[0, 2] == '0' && jogo[1, 2] == '0' && jogo[2, 2] == '0')
                    {
                        Console.WriteLine("\nParabens! O jogador 1 venceu por coluna!\n");
                        ganhou = 1;
                    }

                    if (jogo[0, 0] == 'X' && jogo[1, 0] == 'X' && jogo[2, 0] == 'X' ||
                        jogo[0, 1] == 'X' && jogo[1, 1] == 'X' && jogo[2, 1] == 'X' ||
                        jogo[0, 2] == 'X' && jogo[1, 2] == 'X' && jogo[2, 2] == 'X')
                    {
                        Console.WriteLine("\nParabens! O jogador 2 venceu por coluna!\n");
                        ganhou = 1;
                    }

                    if (jogo[0, 0] == '0' && jogo[1, 1] == '0' && jogo[2, 2] == '0' ||
                                   jogo[0, 2] == '0' && jogo[1, 1] == '0' && jogo[2, 0] == '0')
                    {
                        Console.WriteLine("\nParabens! O jogador 1 venceu por diagonal!\n");
                        ganhou = 1;
                    }

                    if (jogo[0, 0] == 'X' && jogo[1, 1] == 'X' && jogo[2, 2] == 'X' ||
                        jogo[0, 2] == 'X' && jogo[1, 1] == 'X' && jogo[2, 0] == 'X')
                    {
                        Console.WriteLine("\nParabens! O jogador 2 venceu por diagonal!\n");
                        ganhou = 1;
                    }

                    if (jogadas == 9 && ganhou == 0)
                    {
                        Console.WriteLine("\nEMPATE!\n");
                    }

                    Console.WriteLine("\nDeseja jogar novamente?\n1 - SIM\n0 - NAO");
                    opcao = int.Parse(Console.ReadLine());
                }
                while (opcao == 1);
            }
            while (opcao != 0);
        }

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("LISTA 3 DE EXERCICIOS");
                Console.WriteLine();
                Console.WriteLine("01- MENOR, MAIOR, MEDIA ");
                Console.WriteLine("02- MAIORES QUE A MEDIA ");
                Console.WriteLine("03- MAIORES QUE A MEDIA RANDOMICAMENTE");
                Console.WriteLine("04- JOGO DA VELHA");
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
