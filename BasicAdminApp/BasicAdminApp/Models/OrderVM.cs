using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAdminApp.Models
{
    public class OrderVM
    {
        public int id { get; set; }
        public string customerId { get; set; }
        public string shipName { get; set; }
        public string orderDate { get; set; }
    }
}
