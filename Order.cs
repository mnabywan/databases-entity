using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase
{
    public class Order
    {
        public int OrderID { get; set; }
        public List <Product> Products { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }
        
        [ForeignKey("Customer")]
        public string CompanyName { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
