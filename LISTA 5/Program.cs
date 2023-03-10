using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Exercicio1()
        {
            //Console.WriteLine("Digite o nome do Usuário: ");
            var usuario = Console.ReadLine();
            var maquina = Environment.MachineName;
            var data = DateTime.Now;
            String UserName = Environment.UserName;
            String UserName1 = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            //Console.WriteLine(usuario);
            Console.WriteLine($"Voce esta utillizando a maquina {maquina}");
            Console.WriteLine(data);
            Console.WriteLine(UserName);
            Console.WriteLine(UserName1);











        }
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("LISTA 5 DE EXERCICIOS");
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
                   /* case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;*/
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
}
