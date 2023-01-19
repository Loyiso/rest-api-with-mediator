using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Commands.Provinces
{
    public class UpdateVehicleRecordCommandHandler : IRequestHandler<UpdateVehicleRecordCommand, Guid>
    {
        private readonly IRepository<VehicleRecord> _repository;

        public UpdateVehicleRecordCommandHandler(IRepository<VehicleRecord> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(UpdateVehicleRecordCommand command, CancellationToken cancellationToken)
        {
            var record = await _repository.Get(command.Id);

            if (record == null)
            {
                return default;
            }
            else
            { 
                record.Make = command.Make;
                record.Model = command.Model;
                record.Year = command.Year;
                record.LicencePlateNumber = command.LicencePlateNumber;
                record.Mileage = command.Mileage; 
                record.DateUpdated = DateTime.Now;

                await _repository.SaveChangesAsync();
                return record.Id;
            }
        }
    }
}
