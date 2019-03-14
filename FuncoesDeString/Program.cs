using System;
using System.Globalization;

namespace FuncoesDeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com algumas funções da string. Usaremos um frase (Pangrama: que usa todas as letras do alfabeto)
            string frase = "Hoje à noite, seu luz, decidir xeretar a gaveta do vovô: achei lingüiça, pão e fubá";

            //QUANTIDADE DE CARACTERES DA STRING - Length
            Console.WriteLine(frase.Length);

            //SEPARAR FRASE POR VIRGULAS TRAVES DE UM ARRAY - Split(",")
            string[] partes = frase.Split(",");
            for (int i = 0; i < partes.Length; i++)//varrendo o array
            {
                Console.WriteLine(partes[i]);
            }

            //REMOVENDO ESPAÇOS - Trim(), TrimEnd(Remove a direita), TrimStart(Remove a esquerda)
            string[] partes2= frase.Split(",");
            for (int i = 0; i < partes.Length; i++)//varrendo o array
            {
                Console.WriteLine(partes[i].Trim());
            }

            //PROCURANDO PALAVRAS OU FRASES DENTRO DE OUTRA, SOBRECARGA - Contains(parametro)
            string subFrase = "xeretar";
            var achou = frase.Contains(subFrase);
            Console.WriteLine(achou);

            //POSIÇÃO ENCONTRADA - IndexOf(parametro)
            int posicao = frase.IndexOf(subFrase);
            Console.WriteLine(posicao);

            //PEGANDO PARTES DE UMA FRASE - substring(parametroInicial, parametroFinal)
            int posInicial = frase.IndexOf(subFrase);//que e nossa subFrase acima de xeretar
            int posFinal = 10;//10caracteres depois da palavra xeretar

            string sub = frase.Substring(posInicial, posFinal);
            Console.WriteLine(sub);

            //omitindo o final 
            sub = frase.Substring(posInicial);
            Console.WriteLine(sub);

            //TRANSFORMANDO UM TEXTO EM MAIUSCULO OU MINUSCULO - ToUpper(), ToLower()
            Console.WriteLine(frase.ToUpper());
            Console.WriteLine(frase.ToLower());

            //SUBSTITUINDO ALGUMAS COISAS - Repleace(atual, nova)
            string novaTrocada = frase.Replace("vovô", "titia");
            Console.WriteLine(novaTrocada);

            //ignorando algumas letras caso nao saiba o que esta procurando na formatacao exata
            novaTrocada = frase.Replace("VOvô", "Mamãe", true, CultureInfo.InvariantCulture);
            Console.WriteLine(novaTrocada);



            Console.ReadKey();
        }
    }
}
