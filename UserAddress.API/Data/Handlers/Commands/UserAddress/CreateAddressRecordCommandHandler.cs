using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Commands
{
    public class CreateAddressRecordCommandHandler : IRequestHandler<CreateAddressRecordCommand, Guid>
    {
        private readonly IRepository<AddressRecord> _repository;
        public CreateAddressRecordCommandHandler(IRepository<AddressRecord> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateAddressRecordCommand command, CancellationToken cancellationToken)
        {
            var address = new AddressRecord
            {
                UserName = command.UserName,
                Country = command.Country,
                City = command.City,
                PostalCode = command.PostalCode,
                DateCreated = DateTime.Now
            };
             
            _repository.Insert(address);

            await _repository.SaveChangesAsync();
            return address.Id;
        }
    }
}
