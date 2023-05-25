using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    public static class Questao5
    {
        public static void Executar()
        {
            Console.WriteLine("Resolvendo Q5");
            int num;

            int[] vetorAux = SorteiaNumeros();

            while (true)
            {
                Console.WriteLine("Tente adivinhar o número!");
                num = int.Parse(Console.ReadLine());

                if (Tentativa(vetorAux, num) == true)
                {
                    Console.WriteLine("Encontrei!");
                }
                else
                {
                    Console.WriteLine("Não encontrei!"); 
                }
            }
        }
        
        //Função que gera vetor com 3 números aleatórios

        static int[] SorteiaNumeros()
        {
            Random random = new Random();
            int[] numerosSorteados = new int[3];

            for (int i = 0; i < numerosSorteados.Length; i++)
            {
                numerosSorteados[i] = random.Next(10, 51);
            }
            return numerosSorteados;
                
        }

        //Procedimento que testa se o usuário consegue acertar os números

        static bool Tentativa(int[]numeros, int numeroLido)
        {
            foreach (int item in numeros)
            {
                if (numeroLido == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
