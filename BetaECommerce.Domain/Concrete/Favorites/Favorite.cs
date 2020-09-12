using System;
using System.Collections.Generic;
using System.Text;

namespace BetaECommerce.Domain.Concrete.Favorites
{
    public class Favorite:BaseEntity
    {

         public int ProductId { get; set; }

         public int CustomerId { get; set; }

         public int CategoriId { get; set; }
         
    }
}
