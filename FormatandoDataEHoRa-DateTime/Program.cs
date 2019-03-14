using System;

namespace FormatandoDataEHoRa_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //SIMULAÇÃO PEGANDO UMA DATA DE CADASTRO - DateTIme.Parse()
            string dataCadastro = "2010-04-02 08:30:00";
            DateTime data = DateTime.Parse(dataCadastro);
            Console.WriteLine($"Thiago Moura se cadastrou em {data}");

            //PASSANDO UMA DATA FIXA
            DateTime dataFixa = new DateTime(1989, 08, 23, 08, 30, 00);
            Console.WriteLine($"A data fixa é: {dataFixa}");

            //FORMATANDO FORMATO DA HORA
            string horaFormatada = string.Format("{0:HH}h {0:mm}", dataFixa);
            Console.WriteLine($"Formatando a hora {horaFormatada}");

            //FORMATANDO HORA
            string dataFormatada = string.Format("{0:dd/MM/yyyy}", dataFixa);
            Console.WriteLine(dataFormatada);

            Console.ReadKey();
        }
    }
}
