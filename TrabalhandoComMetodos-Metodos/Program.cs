using System;

namespace TrabalhandoComMetodos_Metodos
{
    class Program
    {
        //CLASSE
        class Carro
        {
            private string _marca;
            public string Marca
            {
                get => _marca;
                set => _marca = value;
            }

            private int _anoFabricacao;
            public int anoFabricacao
            {
                get => _anoFabricacao;
                set => _anoFabricacao = value;
            }

            //CRIANDO UM METODO
            public void buzinar()
            {
                Console.WriteLine("bibibi");
            }
            //CRIANDO METODOS COM ATRIBUTOS
            public void virar(string direcao)
            {
                if (direcao.Equals("D"))
                {
                    Console.WriteLine("Virando a direita");
                }
                else
                {
                    Console.WriteLine("Virando a esquerda");
                }
            }
        }

        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "Fusca";
            carro.anoFabricacao = 1978;

            Console.WriteLine($"Eu tenho um {carro.Marca} e seu ano e de {carro.anoFabricacao}");

            //ACESSANDO O METODO
            carro.buzinar();

            //ACESSANDO O METODO QUE FOI FEITO COM ATRIBUTOS
            carro.virar("D");
            carro.virar("E");

            Console.ReadKey();
        }
    }
}
