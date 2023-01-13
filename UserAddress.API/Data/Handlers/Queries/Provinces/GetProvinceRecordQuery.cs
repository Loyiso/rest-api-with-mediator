using MediatR;
using UserAddress.API.Data.Infrastructure.Models;

namespace UserAddress.API.Data.Handlers.Queries
{
    public class GetProvinceRecordQuery : IRequest<ProvinceRecord>
    {
        public Guid Id { get; }

        public GetProvinceRecordQuery(Guid id)
        {
            Id = id;
        } 
    }
}