using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Queries.UserAddress
{
    public class GetProvinceRecordQueryHandler : IRequestHandler<GetProvinceRecordQuery, ProvinceRecord>
    {
        private readonly IRepository<ProvinceRecord> _repository;
        public GetProvinceRecordQueryHandler(IRepository<ProvinceRecord> repository)
        {
            _repository = repository;
        }

        public async Task<ProvinceRecord> Handle(GetProvinceRecordQuery query, CancellationToken cancellationToken)
        {
            var record = await _repository.Get(query.Id);
            return record;
        }
    }
}
