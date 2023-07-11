using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao6
    {
        public static void Executar()
        {
            //variavel onde faz a soma da quantidade de numeros divisores
            int valoresdiv = 0;
            Console.WriteLine("num");
            //declarar e ler variavel do teclado
            int num = int.Parse(Console.ReadLine());
            //for para varrer
            for (int i = 1; i <= num; i++)
            {
                //se o numero atual o restante for igual a 0 o numero atual e divisor
                if (num % i == 0)
                {
                    //somar o valor atual e atribuir a variavel valoresdiv
                    valoresdiv += i;
                    //mostrar para o usuario o num divisor
                    Console.WriteLine($"Esté Número é Divisor pelo: {i}");
                }
            }
            //mostrar para o usuario a soma dos valores divisores
            Console.WriteLine($"valores divisores soma:{valoresdiv}");
            //chamar o procedimento gravararquivo
            GravarArquivo(valoresdiv);
        }

        public static void GravarArquivo(int valoresdiv)
        {
            //caminho para criar o arquivo
            StreamWriter sr = new StreamWriter("Num_Divs.txt");
            //escrever no arquivo a soma dos valores divisores
            sr.WriteLine($"valores divisores soma:{valoresdiv}");
            //fechar arquivo
            sr.Close();
        }
    }
}
