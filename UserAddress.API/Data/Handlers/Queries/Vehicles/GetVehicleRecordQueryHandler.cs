using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Queries
{
    public class GetVehicleRecordQueryHandler : IRequestHandler<GetVehicleRecordQuery, VehicleRecord>
    {
        private readonly IRepository<VehicleRecord> _repository;
        public GetVehicleRecordQueryHandler(IRepository<VehicleRecord> repository)
        {
            _repository = repository;
        }

        public async Task<VehicleRecord> Handle(GetVehicleRecordQuery query, CancellationToken cancellationToken)
        {
            var record = await _repository.Get(query.Id);
            return record;
        }
    }
}
