using System;
using System.Collections.Generic;
using System.Text;

namespace BetaECommerce.Domain.Concrete.Employess
{
    public class Employes:BaseEntity
    {
        public string Nameandlastname { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public string userimage { get; set; }


        public int AdressId { get; set; }

        public int AuthorityId { get; set;  }

    }
}
