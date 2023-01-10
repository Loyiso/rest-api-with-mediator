using MediatR;

#nullable disable

namespace UserAddress.API.Data.Handlers.Commands
{
    public class CreateAddressRecordCommand : IRequest<Guid>
    {
        public CreateAddressRecordCommand(string userName, string country, string city, string postalCode)
        {
            UserName = userName;
            Country = country;
            City = city;
            PostalCode = postalCode;
        }

        public string UserName { get; }
        public string Country { get; }
        public string City { get; }
        public string PostalCode { get; }
    }
}
