using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("\nEXERCICIO 01\n");
            Console.Write("Digite o valor do salario minimo atual:");
            float salarioMinimo = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor do salario da pessoa:");
            float salarioPessoa = float.Parse(Console.ReadLine());

            float salarioLiquido = (salarioPessoa * (1 - 0.085f)) / salarioMinimo;
            Console.WriteLine($"A pessoa ganha {salarioLiquido} salario minimo liquido.");
        }

        public static void Exercicio2()
        {
            Console.WriteLine("\nEXERCICIO 02\n");
            Console.WriteLine("Digite o valor em metros:");
            float metros = float.Parse(Console.ReadLine());

            float centimetros = metros * 100;
            Console.WriteLine($"{metros} metros correspondem a {centimetros} centimetros.");

            float milimetros = metros * 1000;
            Console.WriteLine($"{metros} metros correspondem a {milimetros} milimetros.");
        }

        public static void Exercicio3()
        {
            Console.WriteLine("\nEXERCICIO 03\n");
            Console.WriteLine("Digite a temperatura em Fahrenheit:");
            int fahrenheit = int.Parse(Console.ReadLine());

            float celsius1 = (fahrenheit - 32.0f) * (5.0f / 9.0f);
            Console.WriteLine($"{fahrenheit} graus Fahrenheit correspondem a {celsius1} graus Celsius.");

            int celsius2 = (int)((fahrenheit - 32) * 5 / 9);
            Console.WriteLine($"{fahrenheit} graus Fahrenheit correspondem a {celsius2} graus Celsius.");
        }

        public static void Exercicio4()
        {
            Console.WriteLine("\nEXERCICIO 04\n");
            Console.Write("Digite seu peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());
            float imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine($"Seu IMC e de: {imc}, pontanto voce esta abaixo do peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine($"Seu IMC eh de: {imc}, pontanto voce esta com peso normal");
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                Console.WriteLine($"Seu IMC eh de: {imc}, pontanto voce esta com excesso de peso");
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.WriteLine($"Seu IMC eh de: {imc}, pontanto voce esta com obesidade clase ");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine($"Seu IMC eh de: {imc}, pontanto voce esta com obesidade classe 2");
            }
            else if (imc >= 40.0)
            {
                Console.WriteLine($"Seu IMC eh de: {imc}, pontanto voce esta com obesiddade classe 3");
            }
        }

        public static void Exercicio5()
        {
            Console.WriteLine("\nEXERCICIO 05\n");
            Console.Write("Digite o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o peso do primeiro numero: ");
            float peso1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Digite o peso do segundo numero: ");
            float peso2 = float.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            float num3 = float.Parse(Console.ReadLine());

            Console.Write("Digite o peso do terceiro numero: ");
            float peso3 = float.Parse(Console.ReadLine());

            float mediaPonderada = (num1 * peso1 + num2 * peso2 + num3 * peso3) / (peso1 + peso2 + peso3);

            Console.WriteLine($"A media ponderada fica em: {mediaPonderada} ");
        }

        public static void Exercicio6()
        {
            Console.WriteLine("\nEXERCICIO 06\n");
            Console.WriteLine("Segunda lei de Newton");
            Console.WriteLine();

            Console.Write("Digite a massa de um objeto em kg: ");
            float massa = float.Parse(Console.ReadLine());

            Console.Write("Digite a aceleracao em m/s: ");
            float aceleracao = float.Parse(Console.ReadLine());

            float forca = massa * aceleracao;
            Console.WriteLine($"A forca resultante fica em: {forca}N");
        }

        public static void Exercicio7()
        {
            Console.WriteLine("\nEXERCICIO 07\n");
            Console.WriteLine("Calculo Salario atualizado");
            Console.WriteLine();

            Console.Write("Digite o valor do seu salario: ");
            float salario = float.Parse(Console.ReadLine());

            float aumento = (salario * 1.337f) + salario;

            Console.WriteLine($"Com um reajuste de 33.7% seu salario aumentou para: R${aumento}");
        }

        public static void Exercicio8()
        {
            Console.WriteLine("\nEXERCICIO 08\n");
            Console.WriteLine("CotaÃ§Ã£o do dolar");
            Console.WriteLine();

            Console.Write("Digite um valor em real: ");
            float real = float.Parse(Console.ReadLine());

            Console.Write("Digite a cotacao do dolar de hoje: ");
            float dolar = float.Parse(Console.ReadLine());

            float cotacaohoje = real / dolar;

            Console.WriteLine($"R${real} equivalem a US${cotacaohoje}");
        }

        public static void Exercicio9()
        {
            Console.WriteLine("\nEXERCICIO 09\n");
            Console.WriteLine("CÃ¡lculo valores");
            Console.WriteLine();

            Console.Write("Digite um valor inteiro: ");
            int num = int.Parse(Console.ReadLine());

            int antecessor = (num * 3) - 1;
            int sucessor = (num * 2) + 1;
            int total = antecessor + sucessor;

            Console.Write($"A soma do antecessor do seu triplo com o sucessor do seu dobro fica em: {total} ");
        }

        public static void Exercicio10()
        {
            Console.WriteLine("\nEXERCICIO 10\n");
            Console.WriteLine("Numeros separados");
            Console.WriteLine();

            Console.WriteLine("Digite um nÃºmero inteiro de 4 di­gitos:");
            string numero = Console.ReadLine();

            Console.WriteLine(numero.Substring(0, 1));
            Console.WriteLine(numero.Substring(1, 1));
            Console.WriteLine(numero.Substring(2, 1));
            Console.WriteLine(numero.Substring(3, 1));
        }

        public static void Exercicio11()
        {
            Console.WriteLine("\nEXERCICIO 11\n");
            Console.WriteLine("Investimento Marquesito");
            Console.WriteLine();

            Console.WriteLine("Valor banca: R$1000.00");

            float primeiro = 1000 / (float)1.124;
            Console.WriteLine($"Valor primeiro dia: R${primeiro}");

            float segundo = primeiro * (float)1.018;
            Console.WriteLine($"Valor segundo dia: R${segundo}");

            float terceiro = segundo * (float)1.056;
            Console.WriteLine($"Valor terceiro dia: R${terceiro}");

            float quarto = terceiro / (float)1.045;
            Console.WriteLine($"Valor quarto dia: R${quarto}");
        }

        public static void Exercicio12()
        {
            Console.WriteLine("\nEXERCICIO 12\n");
            Console.Write("Digite sua altura em metros: ");
            float altura = float.Parse(Console.ReadLine());

            Console.Write("Digite 'm' para homem ou 'f' para mulher: ");
            char genero = char.Parse(Console.ReadLine());

            double pesoIdeal;
            if (genero == 'm')
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }

            Console.WriteLine($"Seu peso ideal eh: {pesoIdeal} kg");
        }

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("LISTA DE EXERCICIOS");
                Console.WriteLine();
                Console.WriteLine("01- EX01 CALCULO SALARIO MINIMO");
                Console.WriteLine("02- EX02 CONVERSOR PARA cm E mm");
                Console.WriteLine("03- EX03 FAHRENHEIT EM CALSIUS");
                Console.WriteLine("04- EX04 IMC");
                Console.WriteLine("05- EX05 MEDIA PONDERADA");
                Console.WriteLine("06- EX06 FORMULA DE FISICA");
                Console.WriteLine("07- EX07 REAJUSTE SALARIO");
                Console.WriteLine("08- EX08 COTACAO DOLAR");
                Console.WriteLine("09- EX09 SOMA ANTECESSOR DO TRIPLO");
                Console.WriteLine("10- EX10 4 DIGITOS POR LINHA");
                Console.WriteLine("11- EX11 MARQUESITO");
                Console.WriteLine("12- EX12 PESO IDEAL");
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
                    case 7:
                        Exercicio7();
                        break;
                    case 8:
                        Exercicio8();
                        break;
                    case 9:
                        Exercicio9();
                        break;
                    case 10:
                        Exercicio10();
                        break;
                    case 11:
                        Exercicio11();
                        break;
                    case 12:
                        Exercicio12();
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
}

