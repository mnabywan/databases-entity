using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        [Column("Unitprice", TypeName = "money")]
        public decimal UnitPrice { get; set; }
    }
}
