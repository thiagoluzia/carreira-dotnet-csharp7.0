using System;

namespace OrganizandoConstantes_Enums
{
    class Program
    {
        //CRINADO UM ENUM
        public enum DiasSemana
        {
            Domingo, segunda, terca, quarta, quinta, sexta, sabado
        }

        static void Main(string[] args)
        {
            //ACESSANDO ENUM
            int x = (int)DiasSemana.Domingo;
            int y = (int)DiasSemana.sexta;
            Console.WriteLine("Domingo = {0}", x);
            Console.WriteLine("Quinta = {0} ", y);

            Console.ReadKey();
        }
    }
}
