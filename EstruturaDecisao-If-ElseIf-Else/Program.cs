using System;

namespace EstruturaDecisao_If_ElseIf_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESTRUTURA DE DECISAO SIMPLES IF
            double salario;
            double gastosMensais;
            Console.WriteLine("\n EXEMPLO 1 CONDICIONAIS");
            Console.Write("Digite seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());//Converte o texto digitado para um numero double

            Console.Write("Digite seus gastos mensais: ");
            gastosMensais = Convert.ToDouble(Console.ReadLine());

            if (salario < gastosMensais)
            {
                Console.WriteLine("Voce Precisa economizar! ");
            }
            //ESTRUTURA DE DECISAO COMPOSTA
            else
            {
                Console.WriteLine("Você gastou menos do que ganhou, MUITO BEM!");
            }
            //ESTRUTURA EM CASCATA
            Console.WriteLine("\n EXEMPLO 2 CONDICIONAIS EM CASCATA");
            double salario2;
            double gastosMensais2;
            bool temDecimoTerceiro = false;

            //entrada de dados
            Console.Write("Digite seu salário: ");
            salario2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seus gastos mensais: ");
            gastosMensais2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tem Decimo Terceiro? true/false: ");
            bool.TryParse(Console.ReadLine(), out temDecimoTerceiro);

            //condicionais
            if (temDecimoTerceiro)
            {
                salario2 += salario2;
            }
            if (salario2 < gastosMensais2)
            {
                Console.WriteLine("Voce Precisa economizar! ");
            }else if (salario2 == gastosMensais2)
            {
                Console.WriteLine("Você esta Zerado");
            }
            else
            {
                Console.WriteLine("Você gastou menos do que ganhou, MUITO BEM!");
            }

            Console.ReadKey();
        }
    }
}
