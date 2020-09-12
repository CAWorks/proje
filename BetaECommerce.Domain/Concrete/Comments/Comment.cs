using BetaECommerce.Domain.Concrete.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetaECommerce.Domain.Concrete.Comments
{
    public class Comment
    { 

        public string titlecomment { get; set; }
        public string comment { get; set; }
        public int CustomerId { get; set; }
        public bool status { get; set; }

     
        

    }
}
