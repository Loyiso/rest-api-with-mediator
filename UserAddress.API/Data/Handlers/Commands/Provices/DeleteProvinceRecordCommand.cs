using MediatR;

namespace UserAddress.API.Data.Handlers.Commands
{
    public class DeleteProvinceRecordCommand : IRequest<Guid>
    {
        public Guid Id { get; }

        public DeleteProvinceRecordCommand(Guid id)
        {
            Id = id;
        }
    }
}
