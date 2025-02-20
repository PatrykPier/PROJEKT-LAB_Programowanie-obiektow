using System;
using System.Collections.Generic;
using System.Linq;
using BikeRentalApp.Models;
using BikeRentalApp.Data;

namespace BikeRentalApp.Services
{
    public class PaymentService
    {
        public static void MakePayment(int rentId, decimal amount, string method)
        {
            var payments = TextFileDb.LoadPayments();
            int newId = payments.Count + 1;
            payments.Add(new Payment { ID_Payment = newId, ID_Rent = rentId, Amount = amount, Payment_Method = method, Payment_Date = DateTime.Now });
            TextFileDb.SavePayments(payments);
            Console.WriteLine(" Płatność została zarejestrowana!");
        }

        public static void DisplayPayments()
        {
            var payments = TextFileDb.LoadPayments();
            Console.WriteLine("\n Lista płatności:");
            foreach (var payment in payments)
            {
                Console.WriteLine($"ID: {payment.ID_Payment}, Wypożyczenie: {payment.ID_Rent}, Kwota: {payment.Amount} zł, Metoda: {payment.Payment_Method}, Data: {payment.Payment_Date}");
            }
        }
    }
}
