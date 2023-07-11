using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao4
    {
        public static void Executar()
        {
            //variavel onde vai fazer a contagem de a
            int characterCount = 0;
            //caminho do arquivo
            StreamReader sr = new StreamReader("texto.txt");
            //variavel que vai fazer a leitura da linha do arquivo
            string line;
            //enquanto a linha lida for diferente de nula vai ser lida
            while ((line = sr.ReadLine()) != null)
            {
                //exibir a linha lida na tela
                Console.WriteLine(line);
                //varrer a linha em busca do char a ou A
                foreach (char character in line)
                {
                    if (character == 'a' || character == 'A')
                    {
                        //acrescentar 1 na contagem
                        characterCount++;
                    }
                }
            }
            //fechar arquivo
            sr.Close();
            //mostrar para o usuario a contagem
            Console.WriteLine($"A quantidade de letras 'a' no arquivo é: {characterCount}");
        }
    }
}
