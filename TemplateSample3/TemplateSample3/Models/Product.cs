using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSample3.Models
{
    public class Product
    {
        public string name { get; set; }
        public decimal unitPrice { get; set; }
        public Category category { get; set; }
    }

    public class Category
    {
        public string description { get; set; }
    }
}
