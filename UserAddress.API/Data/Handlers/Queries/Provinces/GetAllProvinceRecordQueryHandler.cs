using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Queries
{
    public class GetAllProvinceRecordQueryHandler : IRequestHandler<GetAllProvinceRecordQuery, IEnumerable<ProvinceRecord>>
    {
        private readonly IRepository<ProvinceRecord> _repository;
        public GetAllProvinceRecordQueryHandler(IRepository<ProvinceRecord> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProvinceRecord>> Handle(GetAllProvinceRecordQuery query, CancellationToken cancellationToken)
        {
            var records = await _repository.GetAll();
            return records;
        }
    }
}
