using System;

namespace EstruturaRepeticao_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO SIMPLES 
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Num => {i}");

            }
            Console.WriteLine();
            

            //EXEMPLO COM ARRAY
            string[] nome = new string[] { "Thiago", "Tarcyla", "Alesandra" };

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"Olá {nome[i]}");
            }
            Console.WriteLine();

            //EXEMPLO CONTAGEM SIMPLES
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
