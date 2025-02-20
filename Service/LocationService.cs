using System;
using System.Collections.Generic;
using System.Linq;
using BikeRentalApp.Models;
using BikeRentalApp.Data;

namespace BikeRentalApp.Services
{
    public class LocationService
    {
        public static void AddLocation(string street, string house, string postcode, string city)
        {
            var locations = TextFileDb.LoadLocations();
            int newId = locations.Count + 1;
            locations.Add(new Location { ID_Location = newId, StreetName = street, HouseNumber = house, PostCode = postcode, City = city });
            TextFileDb.SaveLocations(locations);
            Console.WriteLine(" Lokalizacja dodana do bazy!");
        }

        public static void DisplayLocations()
        {
            var locations = TextFileDb.LoadLocations();
            Console.WriteLine("\n📍 Lista lokalizacji:");
            foreach (var location in locations)
            {
                Console.WriteLine($"ID: {location.ID_Location}, Adres: {location.StreetName} {location.HouseNumber}, {location.PostCode} {location.City}");
            }
        }
    }
}
