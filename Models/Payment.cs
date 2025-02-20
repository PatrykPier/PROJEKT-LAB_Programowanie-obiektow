using System.ComponentModel.DataAnnotations;

namespace BikeRentalApp.Models
{
    public class Payment
    {
        [Key]
        public int ID_Payment { get; set; }
        public decimal Amount { get; set; }
        public string Payment_Method { get; set; } = "Gotówka";
        public DateTime Payment_Date { get; set; } = DateTime.Now;
        public int ID_Rent { get; set; }
    }
}
