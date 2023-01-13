using UserAddress.API.Data.Infrastructure.Models;
using UserAddress.API.Data.Repositories;
using MediatR;

namespace UserAddress.API.Data.Handlers.Commands
{
    public class CreateProvinceRecordCommandHandler : IRequestHandler<CreateProvinceRecordCommand, Guid>
    {
        private readonly IRepository<ProvinceRecord> _repository;
        public CreateProvinceRecordCommandHandler(IRepository<ProvinceRecord> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateProvinceRecordCommand command, CancellationToken cancellationToken)
        {
            var province = new ProvinceRecord
            {
                Name = command.Name,
                Description = command.Description,
                Image = command.Image, 
                DateCreated = DateTime.Now
            };
             
            _repository.Insert(province);

            await _repository.SaveChangesAsync();
            return province.Id;
        }
    }
}
