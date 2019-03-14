using System;
using System.Collections;

namespace Filas_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando e instanciado uma fila 
            Queue nome = new Queue();

            //Atribuindo valores na fila
            nome.Enqueue("thiago");
            nome.Enqueue("tarcyla");
            nome.Enqueue("alesandra");
            nome.Enqueue("joao");

            //Contando itens na fila
            Console.WriteLine($"Temos {nome.Count} na fila");

            //Lendo valores na fila
            Console.WriteLine($"O segundo iten é {nome.ToArray().GetValue(1) }");

            //Retirando o primeiro valor da fila
            nome.Dequeue();
            Console.WriteLine($"Agora temos  {nome.Count} na fila");

            Console.ReadKey();
        }
    }
}
