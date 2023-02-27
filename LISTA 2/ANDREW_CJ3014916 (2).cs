using System;

class Program {
  public static void Exercicio1()
        {
        Console.WriteLine("\nEXERCICIO 01\n");
        const int numValores = 172;
        const int minValor = 23;
        const int maxValor = 9568;

        Random random = new Random();
        
        int menorValor = random.Next(minValor, maxValor + 1);
        int maiorValor = menorValor;
        int somaValoresPares = 0;
        int numValoresPares = 0;

        
        for (int i = 1; i < numValores; i++)
        {
            int valor = random.Next(minValor, maxValor + 1);
            if (valor < menorValor)
            {
                menorValor = valor;
            }
            else if (valor > maiorValor)
            {
                maiorValor = valor;
            }
            if (valor < 100 && valor % 2 == 0)
            {
                somaValoresPares += valor;
                numValoresPares++;
            }
        }
        
        float mediaValoresPares = numValoresPares > 0 ? somaValoresPares / (float)numValoresPares : 0;

       
        Console.WriteLine("Menor valor encontrado: " + menorValor);
        Console.WriteLine("Maior valor encontrado: " + maiorValor);
        Console.WriteLine("Média dos valores pares menores que 100: " + mediaValoresPares);
        Console.ReadKey();          

        }

        public static void Exercicio2()
        {
          Console.WriteLine("\nEXERCICIO 02\n");
          int num;
          int contador = 0;
          int soma = 0;
          float media = 0;
          
          while (true)
          {
              Console.Write("Digite um número inteiro (ou um valor negativo para sair): ");
              num = int.Parse(Console.ReadLine());
              
              if (num < 0)
              {
                  break;
              }
              
              soma += num;
              contador++;
          }
          
          if (contador > 0)
          {
              media = (float) soma / contador;
              Console.WriteLine("A média é: {0}", media);
          }
          else
          {
              Console.WriteLine("Nenhum número válido foi digitado.");
          }           
        }

        public static void Exercicio3()
        {
          Console.WriteLine("\nEXERCICIO 03\n");
          
          Console.Write("Digite o valor de X: ");
          int x = int.Parse(Console.ReadLine());
          
          Console.Write("Digite o valor de Y: ");
          int y = int.Parse(Console.ReadLine());
          
          Console.WriteLine("Números com resto 3 ou 5 na divisão por 7:");
          
          for (int i = x; i <= y; i++)
          {
              if (i % 7 == 3 || i % 7 == 5)
              {
                  Console.WriteLine(i);
              }
          Console.ReadKey();
            }         
           
        }

        public static void Exercicio4()
        {
          Console.WriteLine("\nEXERCICIO 04\n");
          
          Console.Write("Digite um número P positivo: ");
          int p = int.Parse(Console.ReadLine());
          
          for (int i = 0; i < Math.Pow(p, 3); i++)
          {
              if (i % 4 == 0 && i % 6 != 0)
              {
                  Console.WriteLine(i);
              }
          }
          
          Console.ReadKey();           
            
        }

        public static void Exercicio5()
        {
          Console.WriteLine("\nEXERCICIO 05\n");
          
          Console.Write("Digite um número de linhas: ");
          int numLinhas = int.Parse(Console.ReadLine());
          
          int i = 1;
          while (i <= numLinhas)
          {
              Console.WriteLine(new string('*', i));
              i++;
          }
          
          Console.ReadKey();
            
        }

        public static void Exercicio6()
        {
          Console.WriteLine("\nEXERCICIO 06\n");
          
          Console.Write("Digite um número de linhas: ");
          int numLinhas = int.Parse(Console.ReadLine());          
          int i = 1;
          while (i <= numLinhas * 2)
          {
              if (i % 2 != 0)
              {
                  int numEspacos = (numLinhas * 2 - i) / 2;
                  for (int j = 0; j < numEspacos; j++)
                  {
                      Console.Write(" ");
                  }
                  for (int k = 0; k < i; k++)
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              }
              i++;
          }
          
          Console.ReadKey();
        }
        

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("LISTA 2 DE EXERCICIOS");
                Console.WriteLine();
                Console.WriteLine("01- EX01 172 VALORES INT");
                Console.WriteLine("02- EX02 MEDIA CONJUNTO");
                Console.WriteLine("03- EX03 RESTO IGUAL A 3 OU 5");
                Console.WriteLine("04- EX04 P³");
                Console.WriteLine("05- EX05 MEIA PIRAMIDE");
                Console.WriteLine("06- EX06 PIRAMIDE INTEIRA");
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
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;                    
                    case 0:
                        Console.WriteLine("Sair");
                        break;
                    default:
                        Console.WriteLine("OpÃ§Ã£o invÃ¡lida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }
}