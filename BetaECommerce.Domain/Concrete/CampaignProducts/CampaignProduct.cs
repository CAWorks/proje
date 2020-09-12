using BetaECommerce.Domain.Concrete.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetaECommerce.Domain.Concrete.CampaignProducts
{
    public class CampaignProduct:BaseEntity
    {
        public int ProductId { get; set; }

        public int CampaignPNameId { get; set; }


    }
}
