using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Commands.Provinces
{
    public class DeleteProvinceRecordCommandHandler : IRequestHandler<DeleteProvinceRecordCommand, Guid>
    {
        private readonly IRepository<ProvinceRecord> _repository;

        public DeleteProvinceRecordCommandHandler(IRepository<ProvinceRecord> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(DeleteProvinceRecordCommand command, CancellationToken cancellationToken)
        {
            var record = await _repository.Get(command.Id);

            if (record == null)
            {
                return default;
            }
            else
            {
                _repository.Delete(record);

                await _repository.SaveChangesAsync();
                return record.Id;
            }
        }
    }
}
