using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao10
    {
        public static void Executar()
        {
            Console.WriteLine("Digite A Quantidade de Numeros");
            //declarar variavel e ler do teclado
            int qtd = int.Parse(Console.ReadLine());
            //chamar o procedimento
            CriarArquivo(qtd);
        }

        public static void Media(double[] flutuante)
        {
            double media = 0;
            double soma = 0;
            double maximo = flutuante[0];
            double minimo = flutuante[0];
            //for para varrer o vetor e somar os valores na variavel soma
            for (int i = 0; i < flutuante.Length; i++)
            {
                soma += flutuante[i];
            }
            //calcular a media
            media = soma / flutuante.Length;
            Console.WriteLine($"A Sua Media é: {media}");
            //foreach para verificar se o valor e menor que da variavel passado com referencia
            foreach (double valor in flutuante)
            {
                //se for verdade substituir o valor encontrado na variavel minimo
                if (valor < minimo)
                {
                    minimo = valor;
                }
            }
            Console.WriteLine($"O Valor Minimo é: {minimo}");
            //foreach para verificar se o valor e maior que da variavel passado com referencia
            foreach (double valor in flutuante)
            {
                //se for verdade substituir o valor encontrado na variavel maximo
                if (valor > maximo)
                {
                    maximo = valor;
                }
            }
            Console.WriteLine($"O Valor Maximo é: {maximo}");
        }

        public static void CriarArquivo(int qtd)
        {
            //criar arquivo
            StreamWriter arquivo = new StreamWriter("PontosFlutuantes.txt");
            //criar vetor
            double[] flutuante = new double[qtd];
            //estrutura de repetição
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite o valor do Seu Ponto Flutuante com virgula");
                //ler do teclado e armazenar no vetor na posição atual
                flutuante[i] = double.Parse(Console.ReadLine());
                //gravar no arquivo
                arquivo.WriteLine(flutuante[i]);
            }
            //fechar o arquivo
            arquivo.Close();
            //chamar o procedimento
            Media(flutuante);
        }
    }
}
