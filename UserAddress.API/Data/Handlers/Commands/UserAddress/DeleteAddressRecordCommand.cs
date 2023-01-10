using MediatR;

namespace UserAddress.API.Data.Handlers.Commands
{
    public class DeleteAddressRecordCommand : IRequest<Guid>
    {
        public Guid Id { get; }

        public DeleteAddressRecordCommand(Guid id)
        {
            Id = id;
        }
    }
}
