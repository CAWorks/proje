using System;
using System.Collections.Generic;
using System.Text;

namespace BetaECommerce.Domain.Concrete.County
{
    public class County:BaseEntity
    {
        public string CountyName { get; set; }

        public int CityId { get; set; }
    }
}
