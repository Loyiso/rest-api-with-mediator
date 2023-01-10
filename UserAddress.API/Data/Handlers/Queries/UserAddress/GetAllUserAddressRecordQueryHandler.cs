using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Queries
{
    public class GetAllAddressRecordQueryHandler : IRequestHandler<GetAllAddressRecordQuery, IEnumerable<AddressRecord>>
    {
        private readonly IRepository<AddressRecord> _repository;
        public GetAllAddressRecordQueryHandler(IRepository<AddressRecord> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<AddressRecord>> Handle(GetAllAddressRecordQuery query, CancellationToken cancellationToken)
        {
            var records = await _repository.GetAll();
            return records;
        }
    }
}
