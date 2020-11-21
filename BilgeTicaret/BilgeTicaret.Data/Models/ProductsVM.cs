using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeTicaret.Data.Models
{
    public class ProductsVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsActive { get; set; }
    }

}
