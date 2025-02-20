using System;
using System.Collections.Generic;
using System.Linq;
using BikeRentalApp.Models;
using BikeRentalApp.Data;

namespace BikeRentalApp.Services
{
    public class UserService
    {
        public static void AddUser(string firstName, string lastName, string email, string phone)
        {
            var users = TextFileDb.LoadUsers();
            int newId = users.Count + 1;
            users.Add(new User { ID_User = newId, FirstName = firstName, LastName = lastName, Email = email, Phone = phone, Registration_Date = DateTime.Now });
            TextFileDb.SaveUsers(users);
            Console.WriteLine(" Użytkownik dodany do bazy!");
        }

        public static void DisplayUsers()
        {
            var users = TextFileDb.LoadUsers();
            Console.WriteLine("\n Lista użytkowników:");
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.ID_User}, Imię: {user.FirstName}, Nazwisko: {user.LastName}, Email: {user.Email}, Telefon: {user.Phone}");
            }
        }

        public static void DeleteUser(int id)
        {
            var users = TextFileDb.LoadUsers();
            var user = users.FirstOrDefault(u => u.ID_User == id);
            if (user != null)
            {
                users.Remove(user);
                TextFileDb.SaveUsers(users);
                Console.WriteLine(" Użytkownik został usunięty.");
            }
            else
            {
                Console.WriteLine(" Nie znaleziono użytkownika.");
            }
        }
    }
}
