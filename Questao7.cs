using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao7
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a Quantidade De Letras Que vc que:");
            //declarar e ler variavel do teclado
            int qtd = int.Parse(Console.ReadLine()); ;
            //criar vetor que a quantidade de posiçoes é a quantidade de letras que o usario que
            string[] letras = new string[qtd];
            //chamar procedimento
            GravarArquivo(letras, qtd);
            LerArquivo();
            Vogais(letras);
            //fim chamar procedimento
        }

        public static void GravarArquivo(string[] letras, int qtd)
        {
            //caminho do arquivo
            StreamWriter sr = new StreamWriter("Letras.txt");
            //for para varrer
            for (int i = 0; i < qtd; i++)
            {
                //fazer contagem das letras e mostrar para o usuario
                Console.WriteLine($"Digite Uma letra Letra[{i + 1}]");
                //declarar e ler a variarvel
                string letra = Console.ReadLine();
                //atribuir o vetor na letra e armazenar a variavel no vetor em sua posição atual
                letras[i] = letra;
                //gravar no arquivo
                sr.WriteLine(letra);
            }
            //fechar o arquivo
            sr.Close();
            Console.WriteLine("Arquivo Gravado Com Sucesso");
        }

        public static void Vogais(string[] letras)
        {
            // contar as letras que sao vogais
            int contvogal = 0;
            //varrrer o vetor letras
            for (int i = 0; i < letras.Length; i++)
            {
                //se a letra na posição atual for igual a alguma vogal acrescentar 1 na contagem
                if (letras[i].Equals("a") || letras[i].Equals("e") || letras[i].Equals("i") || letras[i].Equals("o") || letras[i].Equals("u"))
                {
                    contvogal++;
                }
            }
            //mostar para o usario a quantidade de vogais
            Console.WriteLine($"A Quantidade De Vogais São: {contvogal}");
        }

        public static void LerArquivo()
        {
            //caminho do arquivo
            StreamReader sr = new StreamReader("Letras.txt");
            //variavel onde vai ler linha do arquivo
            String linha;
            //enquanto a linha for diferente de nullo vai fazer a leitura
            while ((linha = sr.ReadLine()) != null)
            {
                //retirar os espaços
                linha.Trim();
                //mostrar para o usuario a linha lida
                Console.WriteLine(linha);
            }
            //fechar o arquivo
            sr.Close();
            Console.WriteLine("Arquivo Lido Com Sucesso");
        }
    }
}
