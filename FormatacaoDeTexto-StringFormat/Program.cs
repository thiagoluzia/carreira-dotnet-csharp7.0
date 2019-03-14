using System;

namespace FormatacaoDeTexto_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //TRABALHANDO COM FORMATAÇÃO DE STRING - String.Format()
            string nome = "Thiago Moura";
            int idade = 30;

            string frase = String.Format("O cliente {0} tem {1} anos de idade ", nome, idade);
            Console.WriteLine(frase);

            //SOMANDO STRINGS +=
            frase += "ele e cliente desde de ";
            Console.WriteLine(frase);

            //FORMATANDO DATA - DateTime dataCadastro = new DateTime(ano, mes, dia)
            DateTime dataCadastro = new DateTime(2015, 05, 20);
            frase += String.Format("{0}", dataCadastro);
            Console.WriteLine(frase);

            //colocando data no formato brasileiro
            DateTime aniversario = new DateTime(1989, 08, 23);
            frase += String.Format(", e nasceu em {0:dd/MM/yyyy}", aniversario);
            Console.WriteLine(frase);

            Console.ReadKey();
        }
    }
}
