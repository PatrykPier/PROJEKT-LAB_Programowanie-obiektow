using System;
using BikeRentalApp.Services;

namespace BikeRentalApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n Witaj w systemie zarządzania wypożyczalnią rowerów!");
                Console.WriteLine("1. Dodaj rower");
                Console.WriteLine("2. Wyświetl wszystkie rowery");
                Console.WriteLine("3. Usuń rower");
                Console.WriteLine("4. Dodaj lokalizację");
                Console.WriteLine("5. Wyświetl wszystkie lokalizacje");
                Console.WriteLine("6. Dodaj użytkownika");
                Console.WriteLine("7. Wyświetl użytkowników");
                Console.WriteLine("8. Usuń użytkownika");
                Console.WriteLine("9. Wyjście");
                Console.Write("Wybierz opcję: ");

                string? choice = Console.ReadLine() ?? "0";

                switch (choice)
                {
                    case "1":
                        Console.Write("Podaj model roweru: ");
                        string model = Console.ReadLine() ?? "Nieznany";
                        Console.Write("Podaj status roweru: ");
                        string status = Console.ReadLine() ?? "Dostępny";
                        Console.Write("Podaj ID lokalizacji: ");
                        if (!int.TryParse(Console.ReadLine(), out int locationId)) locationId = 0;
                        BikeService.AddBike(model, status, locationId);
                        break;

                    case "2":
                        BikeService.DisplayBikes();
                        break;

                    case "3":
                        Console.Write("Podaj ID roweru do usunięcia: ");
                        if (int.TryParse(Console.ReadLine(), out int bikeId))
                            BikeService.DeleteBike(bikeId);
                        else
                            Console.WriteLine("⚠️ Niepoprawne ID!");
                        break;

                    case "4":
                        Console.Write("Podaj ulicę: ");
                        string street = Console.ReadLine() ?? "Nieznana";
                        Console.Write("Podaj numer domu: ");
                        string house = Console.ReadLine() ?? "Nieznany";
                        Console.Write("Podaj kod pocztowy: ");
                        string postcode = Console.ReadLine() ?? "00000";
                        Console.Write("Podaj miasto: ");
                        string city = Console.ReadLine() ?? "Nieznane";
                        LocationService.AddLocation(street, house, postcode, city);
                        break;

                    case "5":
                        LocationService.DisplayLocations();
                        break;

                    case "6":
                        Console.Write("Podaj imię użytkownika: ");
                        string firstName = Console.ReadLine() ?? "Nieznane";
                        Console.Write("Podaj nazwisko: ");
                        string lastName = Console.ReadLine() ?? "Nieznane";
                        Console.Write("Podaj e-mail: ");
                        string email = Console.ReadLine() ?? "brak@brak.pl";
                        Console.Write("Podaj telefon: ");
                        string phone = Console.ReadLine() ?? "000000000";
                        UserService.AddUser(firstName, lastName, email, phone);
                        break;

                    case "7":
                        UserService.DisplayUsers();
                        break;

                    case "8":
                        Console.Write("Podaj ID użytkownika do usunięcia: ");
                        if (int.TryParse(Console.ReadLine(), out int userId))
                            UserService.DeleteUser(userId);
                        else
                            Console.WriteLine(" Niepoprawne ID!");
                        break;

                    case "9":
                        Console.WriteLine(" Zamykanie aplikacji...");
                        return;

                    default:
                        Console.WriteLine(" Niepoprawna opcja! Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}
