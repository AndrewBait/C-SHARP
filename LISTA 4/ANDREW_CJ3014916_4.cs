using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Length - Retorna o número de caracteres na string
            string str = "Hello World";
            int len = str.Length; // len é 11

            // ToCharArray - Converte a string em uma matriz de caracteres
            char[] charArray = str.ToCharArray();

            // Trim - Remove os espaços em branco no início e no final da string
            string str2 = "   Hello   ";
            string trimmed = str2.Trim(); // trimmed é "Hello"

            // Substring - Retorna uma parte da string
            string str3 = "Hello World";
            string sub = str3.Substring(0, 5); // sub é "Hello"

            // Split - Divide a string em uma matriz de substrings com base em um delimitador
            string str4 = "apple,banana,orange";
            string[] split = str4.Split(','); // split é {"apple", "banana", "orange"}

            // Contains - Verifica se a string contém uma determinada substring
            bool contains = str.Contains("World"); // contains é true

            // EndsWith - Verifica se a string termina com uma determinada substring
            bool endsWith = str.EndsWith("ld"); // endsWith é true

            // Equals - Verifica se duas strings são iguais
            bool equals = str.Equals("Hello World"); // equals é true

            // GetType - Retorna o tipo da instância da string
            Type type = str.GetType(); // type é typeof(string)

            // IndexOf - Retorna o índice da primeira ocorrência de uma substring na string
            int index = str.IndexOf("o"); // index é 4

            // Empty - Representa uma string vazia
            string emptyStr = string.Empty;

            // Insert - Insere uma substring em uma determinada posição na string
            string str5 = "Hello World";
            string inserted = str5.Insert(5, "C# "); // inserted é "Hello C# World"

            // LastIndexOf - Retorna o índice da última ocorrência de uma substring na string
            int lastIndex = str.LastIndexOf("o"); // lastIndex é 7

            // Remove - Remove uma parte da string
            string str6 = "Hello World";
            string removed = str6.Remove(5, 6); // removed é "Hello"

            // Replace - Substitui uma substring por outra na string
            string str7 = "Hello World";
            string replaced = str7.Replace("World", "C#"); // replaced é "Hello C#"

            // StartsWith - Verifica se a string começa com uma determinada substring
            bool startsWith = str.StartsWith("Hello"); // startsWith é true

            // ToLower - Converte a string em minúsculas
            string lower = str.ToLower(); // lower é "hello world"

            // ToUpper - Converte a string em maiúsculas
            string upper = str.ToUpper(); // upper é "HELLO WORLD"

            // ToString - Converte um objeto em uma string
            DateTime date = DateTime.Now;
            string dateStr1 = date.ToString(); // "3/6/2023 2:32:15 PM"
            string dateStr2 = date.ToString("d"); // "3/6/2023"
            string dateStr3 = date.ToString("D"); // "Sunday, March 6, 2023"
            string dateStr4 = date.ToString("M"); // "March 6"
            string dateStr5 = date.ToString("Y"); // "March, 2023"
            string dateStr6 = date.ToString("yyyy-MM-dd"); // "2023-03-06"

            DateTime time = DateTime.Now;
            string timeStr1 = time.ToString(); // "3/6/2023 2:32:15 PM"
            string timeStr2 = time.ToString("t"); // "2:32 PM"
            string timeStr3 = time.ToString("T"); // "2:32:15 PM"
            string timeStr4 = time.ToString("hh:mm:ss tt"); // "02:32:15 PM"

            double number = 1234.56789;
            string numberStr1 = number.ToString(); // "1234.56789"
            string numberStr2 = number.ToString("N"); // "1,234.57"
            string numberStr3 = number.ToString("C"); // "$1,234.57"
            string numberStr4 = number.ToString("0.00"); // "1234.57"


            // string.IsNullOrEmpty - Verifica se a string é nula ou vazia
            string str8 = null;
            bool isNullOrEmpty = string.IsNullOrEmpty(str8); // isNullOrEmpty é true




        }
    }
}
