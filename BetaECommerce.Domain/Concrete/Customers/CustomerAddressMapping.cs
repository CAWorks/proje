namespace BetaECommerce.Domain.Concrete.Customers
{
    public class CustomerAddressMapping : BaseEntity
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
    }
}
