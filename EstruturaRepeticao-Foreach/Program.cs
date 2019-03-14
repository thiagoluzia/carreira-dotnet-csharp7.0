using System;

namespace EstruturaRepeticao_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] semana = new string[] { "dom", "seg", "ter", "quart", "quint", "sext", "sab" };

            foreach(string dia in semana)
            {
                Console.WriteLine($"Hoje é: {dia}");
            }
            Console.ReadKey();

        }
    }
}
