using MediatR;

using UserAddress.API.Data.Infrastructure.Models;

namespace UserAddress.API.Data.Handlers.Queries
{
    public class GetAllVehicleRecordQuery : IRequest<IEnumerable<VehicleRecord>>
    { 
    } 
}