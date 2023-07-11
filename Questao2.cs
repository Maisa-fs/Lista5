using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao2
    {
        public static void Executar()
        {
            //variavel que sera atribuida a frase do teclado
            string frase;
            //variavel da frase final vazia
            string semvogal = string.Empty;
            //variavel onde contem as vogais minusculo e em maiusculo
            string removervogais = "aeiouAEIOU";
            Console.WriteLine("Digite Uma Frase:");
            //ler variavel do teclado
            frase = Console.ReadLine();
            //mostrar para o usuario a variavel original
            Console.WriteLine($"Frase Original: {frase}");
            //foreach para varrer a frase
            foreach (char letra in frase)
            {
                //se o que conter na variavel letra for diferente da variavel onde ta as vogais concate a letra restante
                if (!removervogais.Contains(letra))
                {
                    semvogal += letra;
                }
            }
            //mostrar para o usuario a variavel ondem contem a frase sem as vogais
            Console.WriteLine($"Frase Sem as Vogais: {semvogal}");
        }
    }
}
