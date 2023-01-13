using MediatR;

#nullable disable

namespace UserAddress.API.Data.Handlers.Commands
{
    public class CreateProvinceRecordCommand : IRequest<Guid>
    { 
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Image { get; set; }
    } 
}
