using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    public static class Questao5
    {
        public static void Executar()
        {
            //caminho do arquivo
            StreamReader sr = new StreamReader("ler.txt");
            //ler a primeira linha
            string linha = sr.ReadLine();
            int i = 0;
            //for para varrer enqunto a linha for diferente de nula
            for (i = 0; linha != null; i++)
            {
                //fazer a apresetação primeiro pois a primeira linha ja foi lida
                Console.WriteLine(linha);
                //ler linha
                linha = sr.ReadLine();
            }
            //mostrar ao usario a quantidade de linhas
            Console.WriteLine($"A Quantidade de Linhas é: {i}");
            sr.Close();
            //fechar arquivo
        }
    }
}
