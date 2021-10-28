using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class CartItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        //PoCo=Plain CLR Object. Class that doesn't inhearit from anything or implement anything
    }
}
