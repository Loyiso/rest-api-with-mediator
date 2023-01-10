using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Commands.UserAddress
{
    public class UpdateAddressRecordCommandHandler : IRequestHandler<UpdateAddressRecordCommand, Guid>
    {
        private readonly IRepository<AddressRecord> _repository;

        public UpdateAddressRecordCommandHandler(IRepository<AddressRecord> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(UpdateAddressRecordCommand command, CancellationToken cancellationToken)
        {
            var record = await _repository.Get(command.Id);

            if (record == null)
            {
                return default;
            }
            else
            {
                record.UserName = command.UserName;
                record.Country = command.Country;
                record.City = command.City;
                record.PostalCode = command.PostalCode;
                record.DateUpdated = DateTime.Now;

                await _repository.SaveChangesAsync();
                return record.Id;
            }
        }
    }
}
