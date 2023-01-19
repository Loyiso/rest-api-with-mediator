using MediatR;

#nullable disable

namespace UserAddress.API.Data.Handlers.Commands
{
    public class UpdateVehicleRecordCommand : IRequest<Guid>
    {
        public UpdateVehicleRecordCommand(Guid id, string make, string model, int year, string licencePlateNumber, int mileage)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            LicencePlateNumber = licencePlateNumber;
            Mileage = mileage;
        }

        public Guid Id { get; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicencePlateNumber { get; set; }
        public int Mileage { get; set; }
    }
}
