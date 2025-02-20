using System;
using System.Collections.Generic;
using System.Linq;
using BikeRentalApp.Models;
using BikeRentalApp.Data;

namespace BikeRentalApp.Services
{
    public class BikeService
    {
        public static void AddBike(string model, string status, int locationId)
        {
            var bikes = TextFileDb.LoadBikes();
            int newId = bikes.Count + 1;
            bikes.Add(new Bike { ID_Bike = newId, Model = model ?? "Nieznany", Status = status ?? "Dostępny", ID_Location = locationId });
            TextFileDb.SaveBikes(bikes);
            Console.WriteLine(" Rower dodany do bazy!");
        }

        public static void DisplayBikes()
        {
            var bikes = TextFileDb.LoadBikes();
            Console.WriteLine("\n📜 Lista rowerów:");
            foreach (var bike in bikes)
            {
                Console.WriteLine($"ID: {bike.ID_Bike}, Model: {bike.Model}, Status: {bike.Status}, Lokalizacja: {bike.ID_Location}");
            }
        }

        public static void DeleteBike(int id)
        {
            var bikes = TextFileDb.LoadBikes();
            var bike = bikes.FirstOrDefault(b => b.ID_Bike == id);
            if (bike != null)
            {
                bikes.Remove(bike);
                TextFileDb.SaveBikes(bikes);
                Console.WriteLine(" Rower został usunięty.");
            }
            else
            {
                Console.WriteLine(" Nie znaleziono roweru.");
            }
        }

        public static void UpdateBike(int id, string newModel, string newStatus)
        {
            var bikes = TextFileDb.LoadBikes();
            var bike = bikes.FirstOrDefault(b => b.ID_Bike == id);
            if (bike != null)
            {
                bike.Model = newModel ?? "Nieznany";
                bike.Status = newStatus ?? "Dostępny";
                TextFileDb.SaveBikes(bikes);
                Console.WriteLine(" Rower zaktualizowany!");
            }
            else
            {
                Console.WriteLine(" Nie znaleziono roweru.");
            }
        }
    }
}
