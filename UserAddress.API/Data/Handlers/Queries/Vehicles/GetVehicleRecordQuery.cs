using MediatR;
using UserAddress.API.Data.Infrastructure.Models;

namespace UserAddress.API.Data.Handlers.Queries
{
    public class GetVehicleRecordQuery : IRequest<VehicleRecord>
    {
        public Guid Id { get; }

        public GetVehicleRecordQuery(Guid id)
        {
            Id = id;
        } 
    }
}