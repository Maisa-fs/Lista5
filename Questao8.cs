using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao8
    {
        public static void Executar()
        {
            //declar variavel e ler do teclado
            int qtd = int.Parse(Console.ReadLine());
            //criar vetor onde contem os valores do alugel
            double[] aluguel = new double[qtd];
            //for para preencher o vetor
            for (int i = 0; i < aluguel.Length; i++)
            {
                Console.WriteLine($"Digite o valor do aluguel do veiculo[{i + 1}]");
                //declarar e ler a variavel do teclado
                double valor = double.Parse(Console.ReadLine());
                aluguel[i] = valor;
            }

            //chamar as funções com os seus parâmetros
            double a = FaturamentoAnual(aluguel);
            Console.WriteLine($"Faturamento Anual: R${a}");
            double b = Multa(aluguel, qtd);
            Console.WriteLine($"O Valor da Multa do Mes é: R${b}");
            double c = Manutencao(qtd);
            Console.WriteLine($"Se continuar a quantidade da frota atual [{qtd}]Veiculos a manuntençao anual será: R${c}");
            CriarArquivo(a, b, c, qtd);
            //fim chamada das funções
        }

        public static double FaturamentoAnual(double[] a)
        {
            //declarar variaveis
            double soma = 0;
            double faturamento;
            //fazer a soma dos valores do aluguel
            foreach (double valor in a)
            {
                soma += valor;
            }
            //calcular o faturamento anual
            faturamento = soma / 3 * 12;
            //retornar o valor da variavel faturamento
            return faturamento;
        }

        public static double Multa(double[] a, int b)
        {
            //declar variavel
            double soma = 0;
            //fazer a soma dos valores do aluguel
            foreach (double valor in a)
            {
                soma += valor;
            }
            //calcular a media do aluguel
            double media = soma / a.Length;
            //fazer o decimo da qtd de veiculos
            double decimo = b * 0.1;
            //calcular a multa final 
            double multafinal = (media * decimo) * 0.2;
            //retornar o valor da variavel multafinal
            return multafinal;
        }

        public static double Manutencao(int a)
        {
            //calcular o gasto da manutenção dos veiculos
            double gasto = ((a * 12) * 0.02) * 600;
            //retornar o valor da variavel gasto
            return gasto;
        }

        public static void CriarArquivo(double a, double b, double c, int d)
        {
            //criar o arquivo txt chamado resultado
            StreamWriter criar = new StreamWriter("resultado.txt");
            //escrever nas linhas
            criar.WriteLine($"Faturamento Anual: R${a}");
            criar.WriteLine($"O Valor da Multa do Mes é: R${b}");
            criar.WriteLine($"Se continuar a quantidade da frota atual [{d}]Veiculos a manuntençao anual será: R${c}");
            //fim escrever
            //fechar arquivo
            criar.Close();
        }
    }
}
