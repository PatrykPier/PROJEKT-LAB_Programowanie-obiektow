using System.ComponentModel.DataAnnotations;

namespace BikeRentalApp.Models
{
    public class Rent
    {
        [Key]
        public int ID_Rent { get; set; }
        public DateTime Rent_Date { get; set; } = DateTime.Now;
        public DateTime? Return_Date { get; set; }
        public int ID_User { get; set; }
        public int ID_Bike { get; set; }
    }
}
