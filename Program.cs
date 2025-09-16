using System;
using estacionamento_evy; // precisa importar o namespace da classe

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();
        bool sair = false;

        do
        {
            Console.WriteLine("\n=== Menu Estacionamento ===");
            Console.WriteLine("[1] Adicionar veículo");
            Console.WriteLine("[2] Listar veículos");
            Console.WriteLine("[3] Remover veículos");
            Console.WriteLine("[0] Sair");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;
                case "2":
                    estacionamento.ListarVeiculos();
                    break;
                case "3":
                    estacionamento.RemoverVeiculo();
                    break;
                case "0":
                    sair = true;
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        } while (!sair);
    }
}
