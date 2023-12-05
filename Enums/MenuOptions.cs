using ParkingSystem.Models;

namespace ParkingSystem.Enums
{
    public enum MenuOptions
    {
        AddVehicle,
        RemoveVehicle,
        ListVehicle,
        Exit
    }

    public static class MenuOptionsConverter
    {
        public static string GetOptionText(this MenuOptions me)
        {
            switch (me)
            {
                case MenuOptions.AddVehicle:
                    return "1 - Cadastrar veículo";
                case MenuOptions.RemoveVehicle:
                    return "2 - Remover veículo";
                case MenuOptions.ListVehicle:
                    return "3 - Listar veículos";
                case MenuOptions.Exit:
                    return "4 - Encerrar";
            }

            return "Opção Invállida";
        }

        public static void ShowMenu(this MenuOptions me)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine(MenuOptions.AddVehicle.GetOptionText());
            Console.WriteLine(MenuOptions.RemoveVehicle.GetOptionText());
            Console.WriteLine(MenuOptions.ListVehicle.GetOptionText());
            Console.WriteLine(MenuOptions.Exit.GetOptionText());
        }

        public static void SelectOption(this MenuOptions me, string option, Parking parking, bool showMenu)
        {
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
                    showMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}