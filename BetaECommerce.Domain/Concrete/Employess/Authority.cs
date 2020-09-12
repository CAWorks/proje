using System;
using System.Collections.Generic;
using System.Text;

namespace BetaECommerce.Domain.Concrete.Employess
{
    public class Authority:BaseEntity
    {
        public string AuthorityName { get; set; }

        public string Description { get; set; }
    }
}
