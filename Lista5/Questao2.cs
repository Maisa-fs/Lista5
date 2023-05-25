using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    public static class Questao2
    {
        public static void Executar()
        {
            Console.WriteLine("Resolvendo Q2");

            int[] NotasAlunos = new int[10];

            NotasAlunos = PreencherVetor(NotasAlunos);

            CalculaMedia(NotasAlunos);

            static int[] PreencherVetor(int[] notas)
            {
                Random rd  =  new Random();

                for (int i = 0; i < notas.Length; i++)
                {
                    notas[i] = rd.Next(0, 101);
                }
                return notas;
            }

            static void CalculaMedia(int[] notas)
            {
                double media, somatorio = 0;
                int cont = 0;

                foreach (int item in notas)
                {
                    somatorio += item; 
                }
                media = somatorio / notas.Length;

                for (int i = 0; i < notas.Length; i++)
                {
                    if (notas[i] > media)
                        cont++;
                }

                Console.WriteLine($"A média da turma é: {media}");
                Console.WriteLine($"Total de alunos acima da média: {somatorio}");

            }
        }
    }
}
