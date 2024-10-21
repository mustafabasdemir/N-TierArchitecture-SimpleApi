using N_TierArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_TierArchitecture.Core.DTOs
{
    public class SaleDto:BaseDto
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int TolalPrice { get; set; }


        public CustomerDto Customer { get; set; }
        public ProductDto Product { get; set; }

    }
}
