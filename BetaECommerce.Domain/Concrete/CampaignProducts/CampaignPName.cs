using System;
using System.Collections.Generic;
using System.Text;

namespace BetaECommerce.Domain.Concrete.CampaignProducts
{
    public class CampaignPName:BaseEntity
    {
        public string CampaignName { get; set; }

        public string CampaignContents { get; set; }

        public string CampaignResim { get; set; }

        public decimal CampaignPrice { get; set; }

        public int Starts { get; set; }
        
        public DateTime StartingDate { get; set; }

        public DateTime EndDate { get; set; }

       



    }
}
