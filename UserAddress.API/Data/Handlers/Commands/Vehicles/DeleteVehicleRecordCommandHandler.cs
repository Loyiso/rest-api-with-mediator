using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Commands
{
    public class DeleteVehicleRecordCommandHandler : IRequestHandler<DeleteVehicleRecordCommand, Guid>
    {
        private readonly IRepository<VehicleRecord> _repository;

        public DeleteVehicleRecordCommandHandler(IRepository<VehicleRecord> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(DeleteVehicleRecordCommand command, CancellationToken cancellationToken)
        {
            var record = await _repository.Get(command.Id);

            if (record == null)
            {
                return default;
            }
            else
            {
                _repository.Delete(record);

                await _repository.SaveChangesAsync();
                return record.Id;
            }
        }
    }
}
