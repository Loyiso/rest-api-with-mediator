using MediatR;

#nullable disable

namespace UserAddress.API.Data.Handlers.Commands
{
    public class UpdateProvinceRecordCommand : IRequest<Guid>
    {
        public UpdateProvinceRecordCommand(Guid id, string name, string description, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image; 
        }

        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Image { get; } 
    }
}
