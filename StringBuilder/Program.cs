using System;
using System.Text;

namespace ManipulacaoEfetiva
{
    class Program
    {
        static void Main(string[] args)
        {

        //CONCATENANDO COM - Append
        StringBuilder builder = new StringBuilder();
        builder.Append("Thiago");
        builder.Append(" Moura\n");

        Console.WriteLine(builder);

        //CONCATENANDO E PULANDO LINHA - AppendLine
        builder.AppendLine("Thiago pula");
        builder.Append("linha");
        Console.WriteLine(builder);

        //FORMATANDO - AppenFormat
        DateTime nascimento = new DateTime(1989, 08, 23);
        builder.AppendFormat("\nThiago Moura nasceu em {0:dd/MM/yyyy}",nascimento);

        Console.WriteLine(builder);

        Console.ReadKey();
        }
    }
}
