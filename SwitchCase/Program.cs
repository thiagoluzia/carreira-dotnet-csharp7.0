using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //SEM TUPLA OPERAÇÃO DIRETA NA APLICAÇÃO
           /* double saldoCartao, valorCompra;
            char tipoPagamento;

            //entrada de dados pelo usuario
            Console.Write("Informe o saldo do Cartão: ");
            saldoCartao = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da compra: ");
            valorCompra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o tipo de pagamento: C => Credito, D => Debito, M => Dinheiro");
            tipoPagamento = Convert.ToChar(Console.ReadLine());

            //estrutura de escolha
            switch (tipoPagamento)
            {
                case 'C':
                    Console.WriteLine("Pagamente efetuado com Cartão de credito");
                    break;
                case 'D':
                    Console.WriteLine("Pagamento efetuado com cartao de debito");
                    break;
                default:
                    Console.WriteLine("Pagamento feito com dinheiro");
                    break;
            }
            //saida de dados detalhada apos estrutura de escolha
            Console.WriteLine($"Saldo anterior {saldoCartao}, valor da compra {valorCompra}, saldo atual {saldoCartao -= valorCompra}");

            Console.ReadKey();
            */
            //COM TUPLA PEGANDO DADOS EXISTENTES, OU SEJA BANCO DE DADOS OU SERVICOS 



            //entrada de dados 
            Console.Write("Informe o saldo do cartao/banco:");
            var eSaldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor da compra: ");
            var eValor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o tipo de pagamento: \n (D) Debito \n (C) Credito \n (M) Dinheiro \n => ");
            char eTipo = Convert.ToChar(Console.ReadLine());

            //tupla passando por parametros as variaveis locais com valores atribuidos na entrada de dados pelo usuario
            (double saldo, double compra, char tipo) pagamento = (eSaldo, eValor, eTipo);

            //processamento das condiçionais
            switch (pagamento.tipo)
            {
                case 'C' when pagamento.compra > pagamento.saldo://aqui ele faz duas verificações onde as duas tem que serem satisfeitas
                    Console.WriteLine("Pagamente efetuado com Cartão de credito");
                    Console.WriteLine("Compra nao aprovada / Saldo insuficiente");
                    break;
                case 'D' when pagamento.compra > pagamento.saldo:
                    Console.WriteLine("Pagamente efetuado com Debito");
                    Console.WriteLine("Compra nao aprovada / Saldo insuficiente");
                    break;
                default:
                    Console.WriteLine("Compra aprovada com sucesso!");
                    break;
                    
            }

            Console.ReadKey();


        }



    }
}
