using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase
{
    public class Customer
    {
        [Key]
        public string CompanyName { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "City cannot be null")]
        public string City { get; set; }

        [Required(ErrorMessage = "Address cannot be null")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Postal code cannot be null")]
        public string PostalCode { get; set; }        
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}
