using MediatR;

#nullable disable

namespace UserAddress.API.Data.Handlers.Commands
{
    public class UpdateAddressRecordCommand : IRequest<Guid>
    {
        public UpdateAddressRecordCommand(Guid id, string userName, string country, string city, string postalCode)
        {
            Id = id;
            UserName = userName;
            Country = country;
            City = city;
            PostalCode = postalCode;
        }

        public Guid Id { get; }
        public string UserName { get; }
        public string Country { get; }
        public string City { get; }
        public string PostalCode { get; }
    }
}
