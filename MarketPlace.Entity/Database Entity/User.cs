using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entity.Database_Entity
{
    
    public class User
    {
        [Key]
        public int Sl { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
    }
}
