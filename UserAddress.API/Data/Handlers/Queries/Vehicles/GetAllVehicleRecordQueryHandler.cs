using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Queries
{
    public class GetAllVehicleRecordQueryHandler : IRequestHandler<GetAllVehicleRecordQuery, IEnumerable<VehicleRecord>>
    {
        private readonly IRepository<VehicleRecord> _repository;
        public GetAllVehicleRecordQueryHandler(IRepository<VehicleRecord> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<VehicleRecord>> Handle(GetAllVehicleRecordQuery query, CancellationToken cancellationToken)
        {
            var records = await _repository.GetAll();
            return records;
        }
    }
}
