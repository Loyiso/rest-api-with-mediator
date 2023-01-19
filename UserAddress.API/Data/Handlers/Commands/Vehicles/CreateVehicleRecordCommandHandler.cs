using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Commands
{
    public class CreateVehicleRecordCommandHandler : IRequestHandler<CreateVehicleRecordCommand, Guid>
    {
        private readonly IRepository<VehicleRecord> _repository;
        public CreateVehicleRecordCommandHandler(IRepository<VehicleRecord> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateVehicleRecordCommand command, CancellationToken cancellationToken)
        {
            var vehicle = new VehicleRecord
            {
                Make = command.Make,
                Model = command.Model,
                Year = command.Year,
                LicencePlateNumber = command.LicencePlateNumber,
                Mileage = command.Mileage,
                DateCreated = DateTime.Now
            };

            _repository.Insert(vehicle);

            await _repository.SaveChangesAsync();
            return vehicle.Id;
        }
    }
}
