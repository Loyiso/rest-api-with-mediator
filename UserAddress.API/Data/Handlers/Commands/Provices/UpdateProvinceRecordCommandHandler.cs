using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Commands.Provinces
{
    public class UpdateProvinceRecordCommandHandler : IRequestHandler<UpdateProvinceRecordCommand, Guid>
    {
        private readonly IRepository<ProvinceRecord> _repository;

        public UpdateProvinceRecordCommandHandler(IRepository<ProvinceRecord> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(UpdateProvinceRecordCommand command, CancellationToken cancellationToken)
        {
            var record = await _repository.Get(command.Id);

            if (record == null)
            {
                return default;
            }
            else
            {
                record.Name = command.Name;
                record.Description = command.Description;
                record.Image = command.Image; 
                record.DateUpdated = DateTime.Now;

                await _repository.SaveChangesAsync();
                return record.Id;
            }
        }
    }
}
