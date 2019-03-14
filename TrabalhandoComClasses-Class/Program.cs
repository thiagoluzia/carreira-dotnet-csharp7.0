using System;

namespace TrabalhandoComClasses_Class
{
    class Program
    {
        //CRIANDO UMA CLASSE
        class Carro
        {
            //ATRIBUTOS DE UMA CLASSE (SUAS CARACTERISTICAS)
            private string _marca;
            public string Marca
            {
                get => _marca;
                set => _marca = value;
                /*EFETUANDO COMPARAÇÃO NO ATRIBUTO
                 * set => _marca = value.Equals("Fusca") ? "OUTRO CARRO" : value; 
                 * 
                 */
            }

            private int _anoFabricacao;
            public int anoFabricacao
            {
                get => _anoFabricacao;
                set => _anoFabricacao = value;
            }
        }

        static void Main(string[] args)
        {
            //INSTANCIANDO UMA CLASSE 
            Carro carro = new Carro();
            carro.Marca = "Fusca";
            carro.anoFabricacao = 1978;

            //CONCATENANDO OS ATRIBUTOS DA CLASSE (VARIAVEIS)
            Console.WriteLine($"Eu tenho um {carro.Marca} e seu ano e de {carro.anoFabricacao}");

            Console.ReadKey();
        }
    }
}
