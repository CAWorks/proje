using BetaECommerce.Core.Enums;

namespace BetaECommerce.Domain.Concrete.Customers
{
    public class CustomerPassword : BaseEntity
    {
        public CustomerPassword()
        {
            PasswordFormat = PasswordFormat.Clear;
        }

        public int CustomerId { get; set; }
        public string Password { get; set; }
        public int PasswordFormatId { get; set; }
        public string PasswordSalt { get; set; }

        public PasswordFormat PasswordFormat
        {
            get => (PasswordFormat)PasswordFormatId;
            set => PasswordFormatId = (int)value;
        }

    }
}
