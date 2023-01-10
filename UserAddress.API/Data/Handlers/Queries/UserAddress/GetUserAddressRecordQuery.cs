using MediatR;
using UserAddress.API.Data.Infrastructure.Models;

namespace UserAddress.API.Data.Handlers.Queries
{
    public class GetAddressRecordQuery : IRequest<AddressRecord>
    {
        public Guid Id { get; }

        public GetAddressRecordQuery(Guid id)
        {
            Id = id;
        } 
    }
}