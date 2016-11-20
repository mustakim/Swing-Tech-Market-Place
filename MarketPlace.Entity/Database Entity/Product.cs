using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entity.Database_Entity
{
    public class Product
    {
        [Key]
        public int Sl { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Tag { get; set; }
        public string Catagory { get; set; }
        public double BuyingPrice { get; set; }
        public double SellingPrice { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
        // Size? what is dataType?
    }
}
