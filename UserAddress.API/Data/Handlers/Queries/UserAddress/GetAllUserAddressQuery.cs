using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Queries
{
    public class GetAllAddressRecordQuery : IRequest<IEnumerable<AddressRecord>>
    { 
    } 
}