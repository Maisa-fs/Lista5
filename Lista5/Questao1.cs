using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    public static class Questao1
    {
        public static void Executar()
        {
            Console.WriteLine("Resolvendo Q1"); 

            int[] N = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Entre com valor para N[{i}]");
                N[i] = int.Parse(Console.ReadLine());
            }

            int menor = N[0];
            int posicao = 0;

            for (int i = 0; i < 20; i++)
            {
                if (N[i] < menor)
                {
                    menor = N[i];
                    posicao = i;
                }
            }
            Console.WriteLine($"O menor elemento do vetor N é {menor} e foi encontrado na posição {posicao}");
        }
    }
}
