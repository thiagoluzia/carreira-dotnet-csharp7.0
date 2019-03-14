using System;

namespace TratamentoDeExcecoes_Throw
{
    class Program
    {
        //CLASSE
        class Pessoa
        {
            //ATRIBUTOS
            private string _nome;
            public string Nome { get; set; }

            private int _idade;
            //TRATAMENTO DE EXCECOES NO METODO
            public int Idade
            {
                get => _idade;
                set => _idade = value < 0 || value > 120 ? throw new Exception($"IDADE INVALIDA") : value;

            }
        }

        static void Main(string[] args)
        {
            //INSTANCIANDO A CLASSE
            Pessoa pessoa = new Pessoa();
            //ATRIBUINDO VALORES AOS ATRIBUTOS
            pessoa.Nome = "Thiago";
            pessoa.Idade = 50;

            //SAIDA
            Console.WriteLine($"TESTE IDADE VALIDA {pessoa.Nome} - {pessoa.Idade}");

            //CASO DE CERTO EXECUTA ESSE BLOCO DE CODIGO
            try
            {
                //TRATAMENTO DE ERRO DE FORMA MAIS AMIGAVEL

                pessoa.Nome = "Alesandra";
                pessoa.Idade = 150;
                Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}
