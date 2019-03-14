using System;

namespace Tuplas_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //ANTERIORMENTE = CODIGO DE DIFICIL COMPREENSSÃO
            (string, string, int) estado = ("São Paulo", "São Paulo", 12);
            Console.WriteLine($"O estado de {estado.Item1}, cujo sua capital é {estado.Item2}, tem a população de {estado.Item3} milhoes de habitantes");


            //ATUALMENTE = Criando uma tupla nomeada para facilitar a leitura 
            (string nome, string capital, int populacao, double rpc) pais = ("Brasil", "Brasilia", 200, 1286.33);

            Console.WriteLine($"\n O {pais.nome} cujo sua capital é {pais.capital}, tem a populacao de {pais.populacao} milhoes de habitantes, e sua renda percapita é de apenas {pais.rpc}");
            
            //Armazendo valores de uma tupla em uma variavel global
            string nome = pais.nome;
            var capital = pais.capital;
            Console.WriteLine($"\nO pais {nome} e sua capital {capital}");

            Console.ReadKey();
        }
    }
}
