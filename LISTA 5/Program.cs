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
            Console.WriteLine("Digite o nome do Usuário: ");
            var usuario = Console.ReadLine();
            Console.Clear();
            var maquina = Environment.MachineName;
            var data =  DateTime.Now;
            int hora = data.Hour;                      
            

            if (hora >= 6 && hora < 12)
            {
                Console.Write("Bom dia!");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.Write("Boa tarde!");
            }
            else
            {
                Console.Write("Boa noite!");
            }

            Console.WriteLine(usuario);
            Console.WriteLine($"Voce esta utilizando a máquina {maquina}");
            Console.Write("Hoje é ");
            Console.WriteLine(data.ToString("F"));  
        }

        static void Exercicio2()
        {
            string texto = "3.2649195;9300419;8240871%2791073;3917173;9851056#9925124,4763040.0965918;9309297%1010589;5634190,7310819#0258142,0929306.0592849#2628868;1392209;4941711%6802169%3655235.1180040#6889981;4529558,3395538;3095206.8162707,5306168%3277453.0758859,8014857.6402319%2329297.7429486#4680437%5500518#7865391#2873377#8086382#5447877%5426116,5085634%7224325#5798439,1178516%4312072.0796522.9304179;0434651%6509028#4787438#8491024%3015385,5290222%5294927%5561596.0460024%1321386,1368206;3408249,6508625.7336954%8002371;7576263%3747889#7408701%0201462#4900590;9622169#0048623%4969522%4528884#4990786.3003232;6365305%3586311.5647329%3264194;2114295,3171009;9876958,4020305,1632979%0031475.2552181%2602640.5303671.8059160%4988532.4693670%9150725,3340225,6376627.0780785;0990199.4341820.0463039%3299347,7393254%4523854#6603120%9368998#5944279,9085068#8137433,3239866,6379195#7431356.5898614.5810497.3487996#5400022#6149677,8533754%6088682%2032031.6332587,7284531#9239331%8866454,3964222#3314980#8428029.2546101;7316677%0460178;8789264;9316756.1965642;7585590,7383219;9062609,8482023,5717895;2684729;0466794%5370084,0484922;4599156,5815576%3414149.1343440#16129";
            string semletra = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (Char.IsDigit(texto[i]))
                {
                    semletra += texto[i];
                }
            }
            Console.WriteLine(semletra);
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
                    case 2:
                         Exercicio2();
                         break;
                     /*case 3:
                         Exercicio3();
                         break;
                     case 4:
                         Exercicio4();
                         break;*/
                    case 0:
                        Console.WriteLine("Sair");
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
