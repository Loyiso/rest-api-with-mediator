using MediatR;

#nullable disable

namespace UserAddress.API.Data.Handlers.Commands
{
    public class CreateVehicleRecordCommand : IRequest<Guid>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicencePlateNumber { get; set; }
        public int Mileage { get; set; }
    } 
}
