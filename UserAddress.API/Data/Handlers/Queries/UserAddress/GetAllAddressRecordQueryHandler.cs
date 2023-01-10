using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Queries.UserAddress
{
    public class GetAllAddressRecordQueryHandler : IRequestHandler<GetAddressRecordQuery, AddressRecord>
    {
        private readonly IRepository<AddressRecord> _repository;
        public GetAllAddressRecordQueryHandler(IRepository<AddressRecord> repository)
        {
            _repository = repository;
        }

        public async Task<AddressRecord> Handle(GetAddressRecordQuery query, CancellationToken cancellationToken)
        {
            var record = await _repository.Get(query.Id);
            return record;
        }
    }
}
