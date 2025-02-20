using System;
using System.Collections.Generic;
using System.Linq;
using BikeRentalApp.Models;
using BikeRentalApp.Data;

namespace BikeRentalApp.Services
{
    public class RentService
    {
        public static void RentBike(int userId, int bikeId)
        {
            var rents = TextFileDb.LoadRents();
            var bikes = TextFileDb.LoadBikes();

            var bike = bikes.FirstOrDefault(b => b.ID_Bike == bikeId);
            if (bike == null)
            {
                Console.WriteLine(" Nie znaleziono roweru.");
                return;
            }

            int newId = rents.Count + 1;
            rents.Add(new Rent { ID_Rent = newId, Rent_Date = DateTime.Now, ID_User = userId, ID_Bike = bikeId });
            TextFileDb.SaveRents(rents);
            Console.WriteLine(" Rower został wypożyczony!");
        }

        public static void ReturnBike(int rentId)
        {
            var rents = TextFileDb.LoadRents();
            var rent = rents.FirstOrDefault(r => r.ID_Rent == rentId);
            if (rent != null)
            {
                rent.Return_Date = DateTime.Now;
                TextFileDb.SaveRents(rents);
                Console.WriteLine(" Rower został zwrócony!");
            }
            else
            {
                Console.WriteLine(" Nie znaleziono wypożyczenia.");
            }
        }

        public static void DisplayRents()
        {
            var rents = TextFileDb.LoadRents();
            Console.WriteLine("\n Lista wypożyczeń:");
            foreach (var rent in rents)
            {
                string returnDate = rent.Return_Date.HasValue ? rent.Return_Date.Value.ToString("yyyy-MM-dd HH:mm") : "Nadal wypożyczony";
                Console.WriteLine($"ID: {rent.ID_Rent}, Użytkownik: {rent.ID_User}, Rower: {rent.ID_Bike}, Wypożyczenie: {rent.Rent_Date}, Zwrot: {returnDate}");
            }
        }
    }
}
