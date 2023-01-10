using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Commands.ExamTest
{
    public class DeleteAddressRecordCommandHandler : IRequestHandler<DeleteAddressRecordCommand, Guid>
    {
        private readonly IRepository<AddressRecord> _repository;

        public DeleteAddressRecordCommandHandler(IRepository<AddressRecord> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(DeleteAddressRecordCommand command, CancellationToken cancellationToken)
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
