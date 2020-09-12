using BetaECommerce.Core.Entity;
using System;

namespace BetaECommerce.Domain.Concrete.Customers
{
    public class Customer : IEntity
    {
        public Customer()
        {
            CustomerGuid = Guid.NewGuid();
        }

        public Guid CustomerGuid { get; set; }

        public int FailedLoginAttempts { get; set; }
        public int? BillingAddressId { get; set; }
        public int? ShippingAddressId { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// Müşteri email adresini değiştirmek istediği senaryoda kullanılacak.
        /// </summary>
        public string EmailToRevalidate { get; set; }
        public string LastIpAddress { get; set; }
        /// <summary>
        /// Geçici süre hesap engelleme
        /// </summary>
        public DateTime? CannotLoginUntilDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public bool Active { get; set; }
        public bool RequireReLogin { get; set; }
        public bool Deleted { get; set; }
    }
}
