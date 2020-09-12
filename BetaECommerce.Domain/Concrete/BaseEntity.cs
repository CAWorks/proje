using BetaECommerce.Core.Entity;
using System;

namespace BetaECommerce.Domain.Concrete
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool Deleted { get; set; }
    }
}
