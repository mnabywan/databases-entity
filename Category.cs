using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase
{
    public class Category
    {
        public int CategoryID { get; set; }
        public String Name { get; set; }
        public List<Product> Products { get; set; }
        public string Description { get; set; }

    }
}
