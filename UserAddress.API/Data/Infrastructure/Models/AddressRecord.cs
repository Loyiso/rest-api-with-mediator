#nullable disable

namespace UserAddress.API.Data.Infrastructure.Models
{
    public class AddressRecord : CommonColumn
    {
        public string UserName { get; set; } 
        public string Country { get; set; } 
        public string City { get; set; } 
        public string PostalCode { get; set; } 
    }
}
