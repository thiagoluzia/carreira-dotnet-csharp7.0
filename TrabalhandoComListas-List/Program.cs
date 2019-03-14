using System;
using System.Collections.Generic;

namespace TrabalhandoComListas_List
{
    class Veiculo
    {
        //ATRIBUTOS DE UMA CLASSE (SUAS CARACTERISTICAS)
        private string _marca;
        public string Marca
        {
            get => _marca;
            //EFETUANDO COMPARAÇÃO NO ATRIBUTO
            set => _marca = value.Equals("Fusca") ? "OUTRO CARRO" : value; 
            
        }

        private int _anoFabricacao;
        public int anoFabricacao
        {
            get => _anoFabricacao;
            set => _anoFabricacao = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO LISTA DE VEICULOS DO TIPO VEICULO DEVIDO A CLASSE
            List<Veiculo> veiculos = new List<Veiculo>();

            //INSTANCIANDO A CLASSE VEICULO E ATRIBUINDO VALORES
            Veiculo carro = new Veiculo();
            carro.Marca = "Civic";
            carro.anoFabricacao = 1978;
            //ADICIONANDO CARRO EM VEICULOS
            veiculos.Add(carro);

            //INSTANCIANDO A CLASSE VEICULO E ATRIBUINDO VALORES
            Veiculo carro2 = new Veiculo();
            carro2.Marca = "Celta";
            carro2.anoFabricacao = 2012;
            //ADICIONANDO CARRO EM VEICULOS
            veiculos.Add(carro2);

            //INSTANCIANDO A CLASSE VEICULO E ATRIBUINDO VALORES
            Veiculo carro3 = new Veiculo();
            carro3.Marca = "Palio";
            carro3.anoFabricacao = 2015;
            //ADICIONANDO CARRO EM VEICULOS
            veiculos.Add(carro3);


            //VARRENDO A LISTA DE VEICULO PARA ME RETORNA VEICULOS
            foreach(Veiculo veiculo in veiculos)
            {
                Console.WriteLine($"Eu tenho um {veiculo.Marca} de {veiculo.anoFabricacao}");
            }
            Console.ReadKey();
        }
    }
}
