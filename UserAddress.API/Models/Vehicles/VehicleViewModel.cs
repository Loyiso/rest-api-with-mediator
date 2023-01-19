using MediatR;

using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UserAddress.API.Models.Vehicles
{
    public class VehicleViewModel
    {
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string LicencePlateNumber { get; set; }
        [Required]
        public int Mileage { get; set; }
    }
}
