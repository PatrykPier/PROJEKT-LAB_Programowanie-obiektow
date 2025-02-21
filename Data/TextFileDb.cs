using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BikeRentalApp.Models;

namespace BikeRentalApp.Data
{
    public static class TextFileDb
    {
        private const string BikeFilePath = "C:\\Users\\patyk\\OneDrive\\Pulpit\\Json\\bikes.json";
        private const string UserFilePath = "C:\\Users\\patyk\\OneDrive\\Pulpit\\Json\\users.json";
        private const string RentFilePath = "C:\\Users\\patyk\\OneDrive\\Pulpit\\Json\\rents.json";
        private const string PaymentFilePath = "C:\\Users\\patyk\\OneDrive\\Pulpit\\Json\\payments.json";
        private const string LocationFilePath = "C:\\Users\\patyk\\OneDrive\\Pulpit\\Json\\locations.json";

        private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions { WriteIndented = true };

        public static void SaveBikes(List<Bike> bikes) => File.WriteAllText(BikeFilePath, JsonSerializer.Serialize(bikes, jsonOptions));
        public static List<Bike> LoadBikes() => File.Exists(BikeFilePath) ? JsonSerializer.Deserialize<List<Bike>>(File.ReadAllText(BikeFilePath), jsonOptions) ?? new List<Bike>() : new List<Bike>();

        public static void SaveUsers(List<User> users) => File.WriteAllText(UserFilePath, JsonSerializer.Serialize(users, jsonOptions));
        public static List<User> LoadUsers() => File.Exists(UserFilePath) ? JsonSerializer.Deserialize<List<User>>(File.ReadAllText(UserFilePath), jsonOptions) ?? new List<User>() : new List<User>();

        public static void SaveRents(List<Rent> rents) => File.WriteAllText(RentFilePath, JsonSerializer.Serialize(rents, jsonOptions));
        public static List<Rent> LoadRents() => File.Exists(RentFilePath) ? JsonSerializer.Deserialize<List<Rent>>(File.ReadAllText(RentFilePath), jsonOptions) ?? new List<Rent>() : new List<Rent>();

        public static void SavePayments(List<Payment> payments) => File.WriteAllText(PaymentFilePath, JsonSerializer.Serialize(payments, jsonOptions));
        public static List<Payment> LoadPayments() => File.Exists(PaymentFilePath) ? JsonSerializer.Deserialize<List<Payment>>(File.ReadAllText(PaymentFilePath), jsonOptions) ?? new List<Payment>() : new List<Payment>();

        public static void SaveLocations(List<Location> locations) => File.WriteAllText(LocationFilePath, JsonSerializer.Serialize(locations, jsonOptions));
        public static List<Location> LoadLocations() => File.Exists(LocationFilePath) ? JsonSerializer.Deserialize<List<Location>>(File.ReadAllText(LocationFilePath), jsonOptions) ?? new List<Location>() : new List<Location>();
    }
}
