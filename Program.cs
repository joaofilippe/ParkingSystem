using ParkingSystem.Enums;
using ParkingSystem.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal hourPrice = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
hourPrice = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Parking parking = new Parking(initialPrice, hourPrice);

MenuOptions menu = new MenuOptions();
string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{   
    menu.ShowMenu();
    
    switch (Console.ReadLine())
    {
        case "1":
            parking.AddVehicle();
            break;

        case "2":
            parking.RemoveVehicle();
            break;

        case "3":
            parking.ListVehicle();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
