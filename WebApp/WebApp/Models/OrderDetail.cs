using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApp.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        
        public int Quantity { get; set; }
        
        public int OrderId { get; set; }
        
        public int BookId { get; set; }

        // Navigate
        public virtual Order Order { get; set; }
        public virtual Book Book { get; set; }
    }
}
