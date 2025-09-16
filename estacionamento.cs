using System;
using System.Collections.Generic;

namespace estacionamento_evy
{
    public class Estacionamento
    {
        private List<string> veiculos = new List<string>();

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();

            if (!string.IsNullOrEmpty(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inválida.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            else
            {
                Console.WriteLine("\n--- Veículos cadastrados ---");
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            if (!string.IsNullOrEmpty(placa) && veiculos.Remove(placa))
            {
                Console.WriteLine("Veículo removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }
    }
}
