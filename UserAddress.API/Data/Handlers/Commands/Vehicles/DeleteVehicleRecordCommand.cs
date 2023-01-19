using MediatR;

namespace UserAddress.API.Data.Handlers.Commands
{
    public class DeleteVehicleRecordCommand : IRequest<Guid>
    {
        public Guid Id { get; }

        public DeleteVehicleRecordCommand(Guid id)
        {
            Id = id;
        }
    }
}
