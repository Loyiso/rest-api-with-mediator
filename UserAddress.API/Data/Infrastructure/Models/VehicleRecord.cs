#nullable disable

namespace UserAddress.API.Data.Infrastructure.Models
{
    public class VehicleRecord : CommonColumn
    {
        public string Make { get; set; } 
        public string Model { get; set; } 
        public int Year { get; set; } 
        public string LicencePlateNumber { get; set; } 
        public int Mileage { get; set; } 
    }
}
