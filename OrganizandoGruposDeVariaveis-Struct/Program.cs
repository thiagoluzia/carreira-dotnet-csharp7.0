using System;

namespace OrganizandoGruposDeVariaveis_Struct
{
    //CRINADO UM STRUCT
    public struct Cliente
    {
        public int Matricula;
        public string Nome;
        public string Email;

        //CRIANDO UM METODO
        public void digaOi()
        {
            Console.WriteLine($"Oi {this.Nome}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ACESSANDO O STRUCT
            Cliente cliente = new Cliente();
            //atribundo valores
            cliente.Matricula = 123;
            cliente.Nome = "Thiago";
            cliente.Email = "thiago@email.com";

            //CHAMANDO O METODO
            cliente.digaOi();

            Console.ReadKey();
        }
    }
}
