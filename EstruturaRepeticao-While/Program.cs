using System;

namespace EstruturaRepeticao_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO SIMPLES
            /*int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();
       
            */

            //EXEMPLO:  COM ARRAY UTILIZANDO O METODO Length PARA CONTAR OS VALORE NO ARRAY
            int i = 0;

            string[] nome = { "Thiago", "Tarcyla", "Alesandra" };

            while(i < nome.Length)
            {
                Console.WriteLine($"Olá {nome[i]}!");
                i++;
            }
            Console.WriteLine();

            //EXEMPLO: WHILE TESTA ANTES DE EXECUTAR
            i = 0;

             while (i <= 10)
            {
                Console.WriteLine($"Num => {i}");
                i++;
            }
            Console.WriteLine();


            //EXEMPLO: DO WHILE EXECUTA O CODIGO PARA TESTA NO FINAL (CUIDADO)
            i = 15;

            do
            {
                Console.WriteLine($"Num => {i}");
                i++;
            } while (i <= 10);

            Console.ReadKey();
        }
    }
}
