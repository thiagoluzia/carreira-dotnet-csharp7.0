using System;

namespace TrabalhandoComData_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //PEGANDO DATA E HORA RECORRENTE - DateTime.Now
            Console.WriteLine("{0}", DateTime.Now);

            //ADICIONANDO DIAS NA DATA ATUAL - DateTime.Now.AddDays(2)
            Console.WriteLine("{0}", DateTime.Now.AddDays(2));

            //SUBTRAINDO DIAS NA DATA ATUAL - DateTime.Now.AddDays(-2)
            Console.WriteLine("{0}", DateTime.Now.AddDays(-2));

            //ADICIONANDO HORAS NA HORA ATUAL - 
            Console.WriteLine("{0}", DateTime.Now.AddHours(2));

            Console.ReadKey();
        }
    }
}
