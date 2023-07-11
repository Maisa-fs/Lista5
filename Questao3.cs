using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao3
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua frase:");
            // ler a string do teclado
            string s = Console.ReadLine();
            //vetor para armazenar os valores da tabela ascii
            int[] ascii = new int[s.Length];
            //for para varrer a frase
            for (int i = 0; i < s.Length; i++)
            {
                //faz a leitura da string s e atribui ela para o vetor ascii
                ascii[i] = s[i];
                // acrescenta tres posições na tabela ascii
                ascii[i] += 3;
            }
            // cria uma frase vazia
            string novafrase = string.Empty;
            //varrer o vetor ascii
            for (int i = 0; i < ascii.Length; i++)
            {
                // faz a conversão para char depois para string e a concactena
                novafrase += Convert.ToChar(ascii[i]).ToString();
            }
            //tratamento para substituir os # gerados para espaçamentos
            string substituir = " ";
            string frasefinal = novafrase.Replace("#", substituir);
            //frase final em maiusculo para ficar igual ao exemplo
            Console.Write(frasefinal.ToUpper());
        }
    }
}
