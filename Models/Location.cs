using System.ComponentModel.DataAnnotations;

namespace BikeRentalApp.Models
{
    public class Location
    {
        [Key]
        public int ID_Location { get; set; }
        public string StreetName { get; set; } = "Nieznana";
        public string HouseNumber { get; set; } = "0";
        public string PostCode { get; set; } = "00000";
        public string City { get; set; } = "Nieznane";
    }
}
