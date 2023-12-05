using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class Parking
    {
        private decimal initialPrice;
        private decimal hourPrice;
        private List<string> vehicleList = new List<string>();

        public Parking(
           decimal initialPrice,
           decimal hourPrice
        )
        {
            this.initialPrice = initialPrice;
            this.hourPrice = hourPrice;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string licensePlate = Console.ReadLine();

            this.vehicleList.Add(licensePlate.ToUpper());
        }


        public void RemoveVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string plate = Console.ReadLine().ToUpper();

            if (vehicleList.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                int hours = 0;
                decimal totalValue = 0;

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string hoursInput = Console.ReadLine();
                hours = Int32.Parse(hoursInput);

                totalValue = this.initialPrice + hours * this.hourPrice;

                this.vehicleList.Remove(plate);

                Console.WriteLine($"O veículo {plate} foi removido e o preço total foi de: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListVehicle()
        {
            // Verifica se há veículos no estacionamento
            if (this.vehicleList.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string vehicle in this.vehicleList)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}