using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao1
    {
        public static void Executar()
        {
            //variavel para onde vai fazer a contagem dos espaços
            int contEspaco = 0;
            //variavel onde vai conter a frase lida do teclado
            string s;
            Console.WriteLine("Digite Uma Frase:");
            //ler variavel do teclado
            s = Console.ReadLine();
            //varrer a string
            foreach (char caracter in s)
            {
                //se conter o caracter de espaço fazer a contagem
                if (caracter == ' ')
                {
                    contEspaco++;
                }

            }
            //exibir a variavel na tela
            Console.WriteLine($"Quntidade de espaços na frase: {contEspaco}");
        }
    }
}
