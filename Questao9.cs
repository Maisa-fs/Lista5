using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao9
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a Quantidade De Alunos Para Cadastro");
            //declarar variavel e ler do teclado
            int qtdAlunos = int.Parse(Console.ReadLine());
            //declarar variaveis
            int matricula = 0;
            int telefone = 0;
            //chamar o procedimento
            CriarArquivo(qtdAlunos, matricula, telefone);
            Console.WriteLine("Voce Gostaria de Ler o Arquivo? Sim/Nao");
            //declarar variavel e ler do teclado
            string resposta = Console.ReadLine().ToUpper();
            //se a resposta for sim chamar o procedimento que lê o arquivo e faz a pergunta novamente
            while (resposta.Equals("SIM"))
            {
                LerArquivo();
                Console.WriteLine("Voce Gostaria de Ler o Arquivo de Novo? Sim/Nao");
                resposta = Console.ReadLine();
            }
        }

        public static void CriarArquivo(int a, int b, int c)
        {
            //criar arquivo
            StreamWriter arquivo = new StreamWriter("CadastroAlunos.txt", true);
            //for para fazer a repetição
            for (int i = 0; i < a; i++)
            {
                //escrever no arquivo o aluno
                arquivo.WriteLine($"Aluno: {i + 1}");
                //escrever a matricula
                Console.WriteLine("Digite a Matricula");
                arquivo.WriteLine("Matricula:");
                b = (int.Parse(Console.ReadLine()));
                arquivo.Write($"{b}\n");
                //fim matricula
                //escrever o telefone
                Console.WriteLine("Digite o telefone Somente Numeros Sem o DDD");
                arquivo.WriteLine("Telefone:");
                c = int.Parse(Console.ReadLine());
                arquivo.Write($"{c}\n");
                //fim telefone
            }
            arquivo.Close();
        }

        public static void LerArquivo()
        {
            //ler o arquivo
            StreamReader ler = new StreamReader("CadastroAlunos.txt");
            //declarar variavel
            string linha;
            //ler linha enquanto for diferente de nulo 
            while ((linha = ler.ReadLine()) != null)
            {
                //imprimir na tela a linha lida
                Console.WriteLine(linha);
            }
            //fechar o arquivo
            ler.Close();
        }
    }
}
