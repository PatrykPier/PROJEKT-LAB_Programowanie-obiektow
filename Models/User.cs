using System.ComponentModel.DataAnnotations;

namespace BikeRentalApp.Models
{
    public class User
    {
        [Key]
        public int ID_User { get; set; }
        public string FirstName { get; set; } = "Nieznane";
        public string LastName { get; set; } = "Nieznane";
        public string Email { get; set; } = "brak@email.com";
        public string Phone { get; set; } = "000000000";
        public DateTime Registration_Date { get; set; } = DateTime.Now;
    }
}
