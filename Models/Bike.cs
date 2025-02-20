using System.ComponentModel.DataAnnotations;

namespace BikeRentalApp.Models
{
    public class Bike
    {
        [Key]
        public int ID_Bike { get; set; }
        public string Model { get; set; } = "Nieznany";
        public string Status { get; set; } = "Dostępny";
        public int ID_Location { get; set; }
    }
}
